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
    public partial class profilem : Form
    {
        public profilem()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 profile1 = new Form1();
            profile1.ShowDialog();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            User2 profile2 = new User2();
            profile2.ShowDialog();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user3 profile3 = new user3();
            profile3.ShowDialog();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User4 profile4 = new User4();
            profile4.ShowDialog();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainmenu back = new mainmenu();
            back.ShowDialog();
            Hide();
        }
    }
}
