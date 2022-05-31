using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMozd
{
    public partial class Form1 : Form
    {
        int mozog = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKozep_Click(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void btnFentre_Click(object sender, EventArgs e)
        {
            Top = 0;
        }

        private void btnFeljebb_Click(object sender, EventArgs e)
        {
            if (Top >= mozog )
            {
                Top -= mozog;
            }
        }

        private void btnLejjebb_Click(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Height - Height > Top)
            {
                Top += mozog;
            }
        }

        private void btnLentre_Click(object sender, EventArgs e)
        {
            Top = Screen.PrimaryScreen.WorkingArea.Height - Height;
        }

        private void btnBalra_Click(object sender, EventArgs e)
        {
            if (Left >= mozog)
            {
                Left -= mozog;
            }
        }

        private void btnBalSzel_Click(object sender, EventArgs e)
        {
            Left = 0;
        }

        private void btnJobbra_Click(object sender, EventArgs e)
        {
            if (Left <= Screen.PrimaryScreen.WorkingArea.Width - Width )
            {
                Left += mozog;
            }
        }

        private void btnJobbSzel_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.WorkingArea.Width - Width;
        }
    }
}
