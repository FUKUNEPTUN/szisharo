using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void btnEloall_Click(object sender, EventArgs e)
        {
            HalmazGeneral(LBx_a, Convert.ToInt32(TBx_A.Text));
            HalmazGeneral(LBx_b, Convert.ToInt32(TBx_B.Text));
            Metszet(LBx_a, LBx_b, LBx_Metsz);
            Unio(LBx_a, LBx_b, LBx_Unio);
            Minusz(LBx_a, LBx_b, LBx_A_B);
            Minusz(LBx_b, LBx_a, LBx_B_A);
        }
        private void HalmazGeneral(ListBox LB,  int N)
        {
            int elem;
            LB.Items.Clear();
            for(int i = 0; i < N; i++)
            {
                do
                {
                    elem = random.Next(N * 5);
                } while (Bennevan(LB, elem));
                LB.Items.Add(elem);
            }
        }
        private bool Bennevan(ListBox LB, object elem)
        {
            for(int i = 0; i < LB.Items.Count; i++)
                if(LB.Items[i] . Equals (elem )) return true;
            return false;
        }
        private void Unio(ListBox LBx_A, ListBox LBx_B, ListBox LBx_Unio)
        {
            LBx_Unio.Items.Clear();
            Unio_For(LBx_A, LBx_B, LBx_Unio);
            Unio_For(LBx_B, LBx_A, LBx_Unio);
        }
        private void Unio_For(ListBox LBx, ListBox LBx1, ListBox LBx_Unio)
        {
            for (int i = 0; i < LBx.Items.Count; i++)
            {
                if (!Bennevan(LBx_Unio, LBx.Items[i]))
                {
                    LBx_Unio.Items.Add(LBx.Items[i]);
                }
            }
        }
        private void Metszet(ListBox LBx_A, ListBox LBx_B, ListBox LBx_Metsz)
        {
            LBx_Metsz.Items.Clear();
            for(int i = 0; i < LBx_A.Items.Count; i++)
            {
                if(Bennevan (LBx_B, LBx_A.Items[i]))
                {
                    LBx_Metsz.Items.Add(LBx_A.Items[i]);
                }
            }
        }
        private void Minusz(ListBox LBx_A, ListBox LBx_B, ListBox LBx_Minusz)
        {
            LBx_Minusz.Items.Clear();
            for (int i = 0; i < LBx_A.Items.Count; i++)
            {
                if (!Bennevan(LBx_B, LBx_A.Items[i]))
                {
                    LBx_Minusz.Items.Add(LBx_A.Items[i]);
                }
            }
        }
    }
}
