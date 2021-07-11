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
        public static Color GroupColor(string groupName)
        {
            if (groupName == string.Empty) return Color.Gray;
            var first = groupName.GetHashCode() + groupName.Length;
            first %= 16;
            switch (first)
            {
                case 0:
                    return Color.Aqua;
                case 1:
                    return Color.Coral;
                case 2:
                    return Color.BlueViolet;
                case 3:
                    return Color.Brown;
                case 4:
                    return Color.Chartreuse;
                case 5:
                    return Color.Crimson;
                case 6:
                    return Color.Chocolate;
                case 7:
                    return Color.CadetBlue;
                case 8:
                    return Color.CornflowerBlue;
                case 9:
                    return Color.DarkCyan;
                case 10:
                    return Color.DarkGreen;
                case 11:
                    return Color.DarkMagenta;
                case 12:
                    return Color.DarkOliveGreen;
                case 13:
                    return Color.DeepPink;
                case 14:
                    return Color.DarkGoldenrod;
                case 15:
                    return Color.DarkSalmon;
                default:
                    return Color.Orchid;
            }
        }

        public static SolidBrush GroupBackground(string column)
        {
            var idx = column.IndexOf(":");
            var groupName = idx != -1 ? column.Substring(0, idx) : string.Empty;
            if (groupName == string.Empty) return new SolidBrush(Color.Black);
            return new SolidBrush(GroupColor(groupName));
        }
    }
}
