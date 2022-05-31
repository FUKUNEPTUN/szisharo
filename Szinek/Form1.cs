using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szinek
{
    public partial class Form1 : Form
    {
        bool k = false,l = false; 
        public Form1()
        {
            InitializeComponent();
            szinez();
            sbMeret_Scroll();
        }
        private void lblNegyzet_Click(object sender, EventArgs e)
        {

        }

        private void sbMeret_Scroll(object sender = null, ScrollEventArgs e = null)
        {
            if (!l)
            {
                Random random = new Random();
                int o = random.Next(10, 100);
                lblNegyzet.Width = o;
                lblNegyzet.Height = o;
                lblNegyzetMeret.Text = Convert.ToString(o);
                sbMeret.Value = o;
                l = true;
            }
            else
            {
                lblNegyzet.Width = sbMeret.Value;
                lblNegyzet.Height = sbMeret.Value;
                lblNegyzetMeret.Text = Convert.ToString(sbMeret.Value);
            }

            
        }


        private void szinez(object sender = null, ScrollEventArgs e = null)
        {
      
            if (!k)
            {
                Random random = new Random();
                sbKek.Value = random.Next(0, 256);
                sbPiros.Value = random.Next(0, 256);
                sbZold.Value = random.Next(0, 256);
                k = true;

            }
            lblNegyzet.BackColor = Color.FromArgb(sbPiros.Value, sbZold.Value, sbKek.Value);
            lblkekszin.Text = Convert.ToString(sbKek.Value);
            lblpirosszin.Text = Convert.ToString(sbPiros.Value);
            lblzoldszin.Text = Convert.ToString(sbZold.Value);

        }

        private void lblkekszin_Click(object sender, EventArgs e)
        {

        }
    }
}
