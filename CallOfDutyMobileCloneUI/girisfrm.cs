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
    public partial class girisfrm : Form
    {
        public girisfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


        

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            
            

            sayac++;
            progressBar1.Value = sayac;
            label2.Text = " % " + progressBar1.Value.ToString();
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                anasayfafrm ana = new anasayfafrm();
                ana.Show();
                this.Hide();
               

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             WindowState =  FormWindowState.Minimized;
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
    }
}
