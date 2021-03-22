using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CallOfDutyMobileCloneUI
{
    public partial class kullaniciGirisi : Form
    {
        public kullaniciGirisi()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            IWebDriver goweb = new ChromeDriver();
            goweb.Navigate().GoToUrl("https://profile.callofduty.com/cod-mobile/loginMobileGame?");
        }
        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
           
        }

        private void bunifuCustomLabel2_MouseHover(object sender, EventArgs e)
        {
            bunifuCustomLabel2.ForeColor = Color.Blue;
        }

        private void bunifuCustomLabel2_MouseLeave(object sender, EventArgs e)
        {
            bunifuCustomLabel2.ForeColor = Color.DarkGoldenrod;
        }

        private void bunifuMaterialTextbox1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuMaterialTextbox2_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = " ";
        }

        private void bunifuMaterialTextbox2_MouseHover(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = " ";
        }

        private void kullaniciGirisi_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici,parola;
            kullanici = "boxingdeath";
            parola = "6fcQSPM.123";
            if (bunifuMaterialTextbox1.Text==kullanici && bunifuMaterialTextbox2.Text == parola)
            {
                girisfrm giris = new girisfrm();
                giris.Show();
                this.Hide();
            }
            else if (!(bunifuMaterialTextbox1.Text == kullanici) && (bunifuMaterialTextbox2.Text == parola))
            {
                MessageBox.Show("Üzgünüm kullanıcı adınızı yanlış girdiniz...");
            }
            else if ((bunifuMaterialTextbox1.Text == kullanici) && !(bunifuMaterialTextbox2.Text == parola))
            {
                MessageBox.Show("Üzgünüm parolanızı yanlış girdiniz...");
            }
            else
            {
                MessageBox.Show("Üzgünüm kullanıcı adınızı ve parolanızı yanlış girdiniz...");
            }




            
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            
            if (bunifuCheckbox2.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void bunifuMaterialTextbox1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
