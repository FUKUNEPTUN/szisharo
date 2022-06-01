using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formDinamic
{
    public partial class Form1 : Form
    {
        double atlag; int osszeg, db, min = int.MaxValue, max = int.MinValue;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(100) + 1;
            Label label = new Label();
            label.Location = new Point(e.X, e.Y);
            label.Text = rnd.ToString();
            label.AutoSize = true;
            int red = random.Next(0, 256), green = random.Next(0, 256), blue= random.Next(0,256);
            label.BackColor = Color.FromArgb(red, green, blue);
            Controls.Add(label);
            db++;
            osszeg += rnd;
            atlag = osszeg / (double)db;
            if(min > rnd ) min = rnd; 
            if(max<rnd ) max = rnd;
            lblSzoveg.Text = string.Format("Darabszám :   {0} ,   összeg :   {1} ,   átlag :   {2} , " + "minimum :   {3} ,  maximum:   {4}. ", db, osszeg, atlag, min, max);
        }
    }
}
