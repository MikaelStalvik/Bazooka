using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagnetWinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frm1 = new TestForm() {Text = "Main", Visible = true };
            var frm2 = new TestForm() { Text = "Child", Visible = true };
            Application.Run(frm1);
        }
    }
}
