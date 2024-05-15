using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class pharmacist : Form
    {
        public pharmacist()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           Login back = new Login();
            back.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            INFO iNFO = new INFO(); 
            iNFO.Show();
            Hide();
        }

        private void pharmacist_Load(object sender, EventArgs e)
        {

        }
    }
}
