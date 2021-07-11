using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MagnetWinForms
{
    public partial class TestForm : Form
    {
        private MagnetWinForms m_MagnetWinForms;

        public TestForm()
        {
            InitializeComponent();

            m_MagnetWinForms = new MagnetWinForms(this);
        }
    }
}
