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
        int mozog = 5,noveked = 25;
        double allit = 0.1;
        int sav = 40;

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

        private void btnMerekCsok_Click(object sender, EventArgs e)
        {

            if (Height >= groupBox1.Top + groupBox1.Height + sav)
            {
                Height -= noveked;
            }
            if (Width >= groupBox1.Left + groupBox1.Width)
            {
                Width -= noveked;
            }
        }

        private void btnAtlatNo_Click(object sender, EventArgs e)
        {
           if (Opacity > 0.2)
            {
                Opacity -= allit;
            }
        }

        private void btnAtlatCsok_Click(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += allit;
            } 
        }

        private void btnMeretNo_Click(object sender, EventArgs e)
        {
            if (Screen.PrimaryScreen.WorkingArea.Height - Height >= Top)
            {
                Height += noveked;
            }
            if (Screen.PrimaryScreen.WorkingArea.Width - Width >= Left)
            {
                Width += noveked;
            }
        }

    }
}
