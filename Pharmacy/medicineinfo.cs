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
    public partial class medicineinfo : Form
    {
        public medicineinfo()
        {
            InitializeComponent();
        }

        private void medicineinfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            INFO iNFO = new INFO();
            iNFO.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
