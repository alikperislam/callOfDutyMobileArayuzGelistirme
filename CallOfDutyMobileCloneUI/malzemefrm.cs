using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallOfDutyMobileCloneUI
{
    public partial class malzemefrm : Form
    {
        public malzemefrm()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            btnm16.Visible = true;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            btnm16.Visible = false;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btntype25.Visible = true;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btntype25.Visible = false;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            btntip25.Visible = true;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            btntip25.Visible = false;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            btnmsmc.Visible = true;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            btnmsmc.Visible = false;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            btnpdw57.Visible = true;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            btnpdw57.Visible = false;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            btnarctic.Visible = true;
        }
        

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            btnarctic.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            btndlq.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            btndlq.Visible = false;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            btnm21.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            btnm21.Visible = false;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            btnj358.Visible = true;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            btnj358.Visible = false;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            btnmw11.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            btnmw11.Visible = false;
        }

        private void pictureBox13_MouseHover(object sender, EventArgs e)
        {
            btnm4.Visible = true;
        }

        private void pictureBox13_MouseLeave(object sender, EventArgs e)
        {
           btnm4.Visible = false;
        }

        private void pictureBox12_MouseHover(object sender, EventArgs e)
        {
            btnrpd.Visible = true;
        }

        private void pictureBox12_MouseLeave(object sender, EventArgs e)
        {
            btnrpd.Visible = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        public string deger1;
        public string deger2;
        public string deger3;
        public string deger4;
        public string karakter;

        private void btnOkeySilahlar_Click(object sender, EventArgs e)
        {

            deger1 = combo1.Text;
            deger2 = combo2.Text;
            deger3 = combo3.Text;
            deger4 = combo4.Text;
            karakter = combokarakter.Text;

        }
        private void malzemefrm_Load(object sender, System.EventArgs e)
        {
            
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        
        private void btngeri_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (deger1=="BOŞ")
            {
                lbl1.Text = "default";

                
            }
            else if (deger1=="M - 16")
            {
                lbl1.Text = "M - 16";
                picture1.Image = Properties.Resources.m16;
            }
            else if (deger1 == "TİP 25")
            {
                lbl1.Text = "TİP 25";
                picture1.Image = Properties.Resources.tip25;
            }
            else if (deger1 == "MSMC")
            {
                lbl1.Text = "MSMC";
                picture1.Image = Properties.Resources.msmc;
            }
            else if (deger1 == "PDW 57")
            {
                lbl1.Text = "PDW 57";
                picture1.Image = Properties.Resources.pdw57;
            }
            else if (deger1 == "TYPE - 25")
            {
                lbl1.Text = "TYPE 25";
                picture1.Image = Properties.Resources.type25;
            }


            if (deger2 == "BOŞ")
            {
                lbl2.Text = "default";
                

            }
            else if (deger2 == "ARCTİC.50")
            {
                lbl2.Text = "ARCTİC.50";
                picture2.Image = Properties.Resources.arctic50;
            }
            else if (deger2 == "DLQ - 33")
            {
                lbl2.Text = "DLQ - 33";
                picture2.Image = Properties.Resources.dlq33;
            }
            else if (deger2 == "M - 21")
            {
                lbl2.Text = "M - 21";
                picture2.Image = Properties.Resources.m21;
            }




            if (deger3 == "BOŞ")
            {
                lbl3.Text = "default";

            }
            else if (deger3 == "J - 358")
            {
                lbl3.Text = "J - 358";
                picture3.Image = Properties.Resources.J358;
            }
            else if (deger3 == "MW - 11")
            {
                lbl3.Text = "MW - 11";
                picture3.Image = Properties.Resources.MW11;
            }



            if (deger4 == "BOŞ")
            {
                lbl4.Text = "default";

            }
            else if (deger4 == "M - 41")
            {
                lbl4.Text = "M - 41";
                picture4.Image = Properties.Resources.m4lmg;
            }
            else if (deger4 == "RPD")
            {
                lbl4.Text = "RPD";
                picture4.Image = Properties.Resources.rpd;
            }



            if (karakter == "BOŞ")
            {
                lblKARAK.Text = "default";

            }
            else if (karakter == "NİCKY")
            {
                lblKARAK.Text = "NİCKY";
                pictureKARAK.Image = Properties.Resources.nicky;


            }
            else if (karakter == "KİND")
            {
                lblKARAK.Text = "KİND";
                pictureKARAK.Image = Properties.Resources.kind;
            }
            else if (karakter == "PABLO")
            {
                lblKARAK.Text = "PABLO";
                pictureKARAK.Image = Properties.Resources.pablo;
            }
        }
    }
}
