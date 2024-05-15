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
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SEARCH sEARCH = new SEARCH();   
            sEARCH.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            INVENTORY iNVENTORY = new INVENTORY();
            iNVENTORY.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DEATAILS dEATAILS = new DEATAILS();
            dEATAILS.Show();
        }
    }
}
