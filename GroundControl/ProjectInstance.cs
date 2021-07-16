using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GroundControl
{
    public static class ProjectInstance
    {
        public static RocketProject m_Project { get; set; }
        public static string m_ProjectFilename { get; private set; }

        public static void OpenProject(string filename)
        {
            try
            {
                // Open file
                using (var reader = new FileStream(filename, FileMode.Open))
                {
                    // Load data
                    XmlSerializer ser = new XmlSerializer(typeof(RocketProject));
                    m_Project = ser.Deserialize(reader) as RocketProject;
                    BazookaHelpers.Groups = new List<string>(m_Project.GetGroups());

                    // Groups
                    var groups = m_Project.GetGroups().OrderBy(x => x).ToList();
                    var trks = new List<TrackInfo>();
                    foreach (var group in groups)
                    {
                        foreach (var track in m_Project.Tracks)
                        {
                            var idx = track.Name.IndexOf(":");
                            if (string.IsNullOrEmpty(group) && idx == -1)
                            {
                                trks.Add(track);
                            }
                            else
                            {
                                if (track.Name.StartsWith(group + ":"))
                                {
                                    trks.Add(track);
                                }
                            }
                        }
                    }
                    // Group colors
                    foreach (var group in groups)
                    {
                        var infoItem = m_Project.GroupInfo.FirstOrDefault(x => x.Name.Equals(group));
                        if (infoItem == null)
                        {
                            var htmlColor = BazookaHelpers.ColorToHex(BazookaHelpers.GroupColor(group));
                            m_Project.GroupInfo.Add(new GroupInfo
                            {
                                Name = group,
                                Color = htmlColor
                            });
                        }
                    }

                    m_Project.Tracks = trks;

                    // Update project file status
                    m_ProjectFilename = filename;

                    // Fix bookmarks
                    foreach (var bookmark in m_Project.Bookmarks)
                        if (bookmark.Number == -1)
                            bookmark.Number =
                                Enumerable.Range(1, 9)
                                    .FirstOrDefault(index => !m_Project.Bookmarks.Any(b => b.Number == index));

                }
            }
            catch (Exception ex)
            {
                m_Project = null;
                MessageBox.Show("Error while loading the file.\n" + ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool SaveProject(string filename)
        {
            try
            {
                using (var writer = new FileStream(filename, FileMode.Create))
                {
                    // Load data
                    var ser = new XmlSerializer(typeof(RocketProject));
                    ser.Serialize(writer, m_Project);
                }

                // Update project file status
                m_ProjectFilename = filename;
                return true;
            }
            catch (Exception ex)
            {
                return false;
                MessageBox.Show("Error while saving file.\n" + ex.Message, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void NewProject()
        {
            m_ProjectFilename = "";
            m_Project = new RocketProject();
        }

        public static void UpdateGroupColor(string name, string color)
        {
            var grp = m_Project.GroupInfo.FirstOrDefault(x => x.Name.Equals(name));
            if (grp != null)
            {
                grp.Color = color;
            }
        }
    }
}
