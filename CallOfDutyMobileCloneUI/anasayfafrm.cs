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
    public partial class anasayfafrm : Form
    {
        public anasayfafrm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) // windows penceresi eğer kodlandığı şekilde yani normal vaziyette ise.
            {
                WindowState = FormWindowState.Maximized; // ekranı en büyük yap.

                //int btndelx =btnDelete.Location.X;

                // tamamen kod ile ekran büyüyü küçüldüğü zaman butonların yerinin bozulmamasını yine sağ yukarı çaprazda kalmalarını sağlaıdk bu kod sayesinde.
                int a = 300;

                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X = btnDelete.Location.X + a;
                pt.Y = btnDelete.Location.Y;


                pt0.X = btnMinimum.Location.X + a;
                pt0.Y = btnMinimum.Location.Y;


                pt1.X = btnMinMax.Location.X + a;
                pt1.Y = btnMinMax.Location.Y;

                btnDelete.Location = pt;
                btnMinimum.Location = pt0;
                btnMinMax.Location = pt1;

            }
            else
            {
                // eğer büyük vaziyetteyse ekran yani normal vaziyette değil ise o zaman;
                WindowState = FormWindowState.Normal;
                int a = 300;
                int btndelx = btnDelete.Location.X;
                int btndely = btnDelete.Location.Y;
                int btnminx = btnMinimum.Location.X;
                int btnminy = btnMinimum.Location.Y;
                int btnmaxx = btnMinMax.Location.X;
                int btnmaxy = btnMinMax.Location.Y;

                Point pt = new Point();
                Point pt0 = new Point();
                Point pt1 = new Point();

                pt.X = btndelx - a;
                pt.Y = btndely;


                pt0.X = btnminx - a;
                pt0.Y = btnminy;


                pt1.X = btnmaxx - a;
                pt1.Y = btnmaxy;

                btnDelete.Location = pt;
                btnMinimum.Location = pt0;
                btnMinMax.Location = pt1;

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }
        int a = 49;
        private void anasayfafrm_Load(object sender, EventArgs e)
        {
            
            progressBar1.Value =a;
            

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            btnayar.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            btnayar.Visible = false;
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            btnark.Visible = true;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            btnark.Visible = false;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            btnmsj.Visible = true;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            btnmsj.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            btninfo.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            btninfo.Visible = false;
        }

        private void panel5_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picturea1_MouseHover(object sender, EventArgs e)
        {
            picture1.BackColor = Color.DarkGoldenrod;
        }

        private void picturea2_MouseHover(object sender, EventArgs e)
        {
            picture2.BackColor = Color.DarkGoldenrod;
        }

        private void picturea3_MouseHover(object sender, EventArgs e)
        {
            picture3.BackColor = Color.DarkGoldenrod;
        }


        private void formgetir1(Form frm)
        {

            
                panelGecis.Controls.Clear();

                frm.MdiParent = this; // mdi olarak alacağımız formu belirliyoruz.
                panelGecis.Controls.Add(frm); // panelde kontrol edeceğimiz formu seçiyoruz.
                frm.Show();
            
            
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            magazafrm maga = new magazafrm();
            formgetir1(maga);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            malzemefrm malz = new malzemefrm();
            formgetir1(malz);
        }
    }
}
