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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin back = new Admin();
            back.Show();
            Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            profilem pro = new profilem();
            pro.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            userview view = new userview();
            view.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adduser add = new adduser();
            add.Show();
            Hide();
            
        }
    }
}
