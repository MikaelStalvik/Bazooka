using System.Windows.Forms;

namespace GroundControl
{
    public partial class ManageBookmarksForm : Form
    {
        private RocketProject _project;
        public ManageBookmarksForm(RocketProject project)
        {
            _project = project;
            InitializeComponent();
            Populate();
        }

        private void Populate()
        {
            listBox1.Items.Clear();
            var i = 0;
            foreach (var bookmark in _project.Bookmarks)
            {
                listBox1.Items.Add(bookmark.GetCanonical(i));
                i++;
            }
            UpdateUi();
        }
        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            _project.Bookmarks.Add(new Bookmark());
            Populate();
        }

        private void UpdateUi()
        {
            textBoxDesc.Enabled = listBox1.SelectedItem != null;
            numericUpDownRow.Enabled = textBoxDesc.Enabled;
            buttonRemove.Enabled = textBoxDesc.Enabled;
        }

        private void listBox1_SelectedValueChanged(object sender, System.EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                textBoxDesc.Text = string.Empty;
                numericUpDownRow.Text = string.Empty;
            }
            else
            {
                var idx = listBox1.SelectedIndex;
                var bookmark = _project.Bookmarks[idx];
                textBoxDesc.Text = bookmark.Description;
                numericUpDownRow.Value = bookmark.Row;
            }
            UpdateUi();
        }

        private void buttonRemove_Click(object sender, System.EventArgs e)
        {
            var idx = listBox1.SelectedIndex;
            _project.Bookmarks.RemoveAt(idx);
            Populate();
        }

        private void textBoxDesc_TextChanged(object sender, System.EventArgs e)
        {
            var idx = listBox1.SelectedIndex;
            var bm = _project.Bookmarks[idx];
            bm.Description = textBoxDesc.Text;
        }

        private void numericUpDownRow_ValueChanged(object sender, System.EventArgs e)
        {
            var idx = listBox1.SelectedIndex;
            var bm = _project.Bookmarks[idx];
            bm.Row = (int) numericUpDownRow.Value;
        }
    }
}
