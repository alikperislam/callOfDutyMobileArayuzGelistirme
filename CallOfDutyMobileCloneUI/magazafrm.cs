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
    public partial class magazafrm : Form
    {
        public magazafrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void magazafrm_Load(object sender, System.EventArgs e)
        {
            malzemefrm mal = new malzemefrm();
            //MessageBox.Show(mal.deger1);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
