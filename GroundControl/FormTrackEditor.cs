using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GroundControl
{
    public partial class FormTrackEditor : Form
    {
        private List<TrackInfo> m_Tracks;

        public event EventHandler BeforeChange;
        public event EventHandler TracksChanged;
        public event EventHandler TracksRemoved;

        public FormTrackEditor()
        {
            InitializeComponent();
            
            new MagnetWinForms.MagnetWinForms(this);
        }

        private void listTracks_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listTracks_DragDrop(object sender, DragEventArgs e)
        {
            // Get drop index
            var point = listTracks.PointToClient(new Point(e.X, e.Y));
            var index = listTracks.InsertionMark.NearestIndex(point);
            
            // Get the list of items to drop
            var items = e.Data.GetData(typeof(ListViewItem[])) as ListViewItem[];

            // decide on move order
            items = (index > items[0].Index) ? items : items.Reverse().ToArray();

            // Fire before change notification
            BeforeChange?.Invoke(this, null);

            foreach (var item in items)
            {
                // Remove from list
                listTracks.Items.Remove(item);
                m_Tracks.Remove(item.Tag as TrackInfo);
                
                // Insert in new position
                listTracks.Items.Insert(index, item);
                m_Tracks.Insert(index, item.Tag as TrackInfo);
            }

            // Fire tracks change notification
            TracksChanged?.Invoke(this, null);
        }

        private void listTracks_MouseMove(object sender, MouseEventArgs e)
        {
            // Are we starting a drag?
            if (e.Button == MouseButtons.Left)
            {
                // Anything selected?
                if (listTracks.SelectedItems.Count == 0)
                    return;

                listTracks.DoDragDrop(listTracks.SelectedItems.Cast<ListViewItem>().ToArray(), DragDropEffects.Move);
            }
        }

        public void SetTracks(List<TrackInfo> tracks)
        {
            // Remember track list
            m_Tracks = tracks;

            // Add items to list
            listTracks.Items.Clear();
            //m_Tracks.ForEach(t=>listTracks.Items.Add(new ListViewItem() {Text = t.Name, Checked = t.Visible, Tag = t}));

            var groupNames = new HashSet<string>();
            foreach (var track in m_Tracks)
            {
                if (track.Name.IndexOf(":") != -1)
                {
                    groupNames.Add(track.Name.Substring(0, track.Name.IndexOf(":")));
                }
            }

            foreach (var name in groupNames)
            {
                var group = new ListViewGroup(name, HorizontalAlignment.Left);
                listTracks.Groups.Add(group);
            }

            foreach (var track in m_Tracks)
            {
                var item = listTracks.Items.Add(new ListViewItem
                    {Text = track.Name, Checked = track.Visible, Tag = track});
                if (track.Name.IndexOf(":") != -1)
                {
                    var groupToFind = track.Name.Substring(0, track.Name.IndexOf(":"));
                    foreach (var o in listTracks.Groups)
                    {
                        var g = (ListViewGroup) o;
                        if (g.Header.Equals(groupToFind))
                        {
                            item.Group = g;
                            break;
                        }
                    }
                }
            }
            //m_Tracks.ForEach(t => listTracks.Items.Add(new ListViewItem() { Text = t.Name, Checked = t.Visible, Tag = t, Group = grp}));

            // Resize by content
            listTracks.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            
            //
            // Groups
            var groups = new HashSet<string>();
            foreach (var track in m_Tracks)
            {
                var idx = track.Name.IndexOf(":");
                if (idx != -1)
                {
                    var groupExtracted = track.Name.Substring(0, idx);
                    groups.Add(groupExtracted);
                }
                else
                {
                    groups.Add("<Default>");
                }
            }

            foreach (var item in groups)
            {
                checkedListBoxGroups.Items.Add(item, true);
            }

            checkedListBoxGroups.ItemCheck += checkedListBoxGroups_ItemCheck;
        }

        private void listTracks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            m_Tracks[e.Index].Visible = e.NewValue == CheckState.Checked;

            // Fire tracks change notification
            TracksChanged?.Invoke(this, null);
        }

        private void listTracks_Resize(object sender, EventArgs e)
        {
            listTracks.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void listTracks_KeyDown(object sender, KeyEventArgs e)
        {
            // Was delete key pressed?
            if (e.KeyCode == Keys.Delete)
            {
                // Is there anything selected?
                if (listTracks.SelectedItems.Count > 0)
                {
                    // Compose message
                    var msgText = "Delete ";
                    msgText += (listTracks.SelectedItems.Count == 1) ? ((TrackInfo)listTracks.SelectedItems[0].Tag).Name : listTracks.SelectedItems.Count + " Tracks";
                    msgText += "?";

                    // Ask user
                    if (MessageBox.Show(this, msgText, @"Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        // Fire before change notification
                        BeforeChange?.Invoke(this, null);

                        // Remove items
                        var itemsToRemove = listTracks.SelectedItems.Cast<ListViewItem>().ToList();
                        foreach (var item in itemsToRemove)
                        {
                            listTracks.Items.Remove(item);
                            m_Tracks.Remove(item.Tag as TrackInfo);
                        }

                        // Fire tracks change notification
                        TracksRemoved?.Invoke(this, null);

                    }
                }
                e.Handled = true;
            }
        }

        private void listTracks_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Check if label has text 
            if (!string.IsNullOrWhiteSpace(e.Label))
            {
                // Fire before change notification
                BeforeChange?.Invoke(this, null);

                // Assign edited value back to track
                ((TrackInfo)listTracks.Items[e.Item].Tag).Name = e.Label;

                // Fire tracks change notification
                TracksChanged?.Invoke(this, null);
            }
        }

        private void FormTrackEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Are we shuting down?
            if (e.CloseReason == CloseReason.FormOwnerClosing)
                return;

            // Do not really close the form, just hide it
            e.Cancel = true;
            Visible = false;
        }

        private void checkedListBoxGroups_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var item = (string)checkedListBoxGroups.Items[e.Index];
            foreach (var litem in listTracks.Items)
            {
                var listViewItem = (ListViewItem) litem;
                if (listViewItem.Text.StartsWith(item))
                {
                    listViewItem.Checked = e.NewValue == CheckState.Checked;
                    Debug.WriteLine("Found: " + listViewItem.Text);
                }
            }
        }
    }
}
