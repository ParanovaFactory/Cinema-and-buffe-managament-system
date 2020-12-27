using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Büfe_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        int kasatutar;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay, top;
            misir = Convert.ToInt32(txtm.Text);
            bilet = Convert.ToInt32(txtb.Text);
            su = Convert.ToInt32(txts.Text);
            cay = Convert.ToInt32(txtc.Text);
            top = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblt.Text = top.ToString() +  "TL" ;

            kasatutar = kasatutar + top;
            lblk.Text = kasatutar.ToString() + "TL";
        }

        private void lblk_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtb.Text = " ";
            txtc.Text = " ";
            txtm.Text = " ";
            txts.Text = " ";
            txtm.Focus();
        }
    }
}
