using System.Collections.Generic;
using System.Drawing;

namespace GroundControl
{
    public static class BazookaHelpers
    {
        public static string GetGroup(string data)
        {
            var idx = data.IndexOf(":");
            if (idx == -1) return string.Empty;
            return data.Substring(0, idx);
        }


        public static Color GroupColor(string name)
        {
            if (string.IsNullOrEmpty(name)) return Color.Gray;
            var index = GroupIndex(name);
            index %= 10;
            switch (index)
            {
                case 0:
                    return Color.DarkRed;
                case 1:
                    return Color.DarkOrange;
                case 2:
                    return Color.DarkKhaki;
                case 3:
                    return Color.DarkSeaGreen;
                case 4:
                    return Color.DarkOliveGreen;
                case 5:
                    return Color.DarkCyan;
                case 6:
                    return Color.DarkBlue;
                case 7:
                    return Color.Indigo;
                case 8:
                    return Color.DarkMagenta;
                default:
                    return Color.DeepPink;
            }
        }
        public static SolidBrush GroupBackground(string name)
        {
            var group = BazookaHelpers.GetGroup(name);
            return new SolidBrush(GroupColor(group));
        }

        public static List<string> Groups { get; set; }

        public static int GroupIndex(string group)
        {
            return Groups.IndexOf(group);
        }

        public static string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

    }
}
