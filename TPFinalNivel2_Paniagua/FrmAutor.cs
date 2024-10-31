using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPFinalNivel2_Paniagua
{
    public partial class FrmAutor : Form
    {
        public FrmAutor()
        {
            InitializeComponent();
        }

        private void pbxGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/aylindaiana");
        }

        private void pbxLN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/aylin-paniagua/");
        }

        private void pbxPortfolio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://aylindaiana.github.io/Aylin-Portfolio/");
        }

        private void pbxGmail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:aylindaianapaniagua@gmail.com");
        }

    }
}
