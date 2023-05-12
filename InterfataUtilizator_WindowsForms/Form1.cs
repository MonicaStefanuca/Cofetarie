using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;



namespace InterfataUtilizator_WindowsForms
{
    public partial class Produs : Form
    {
        public Produs(int v)
        {
            InitializeComponent();
        }

        private void Produs_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdaugaProdus f2 = new AdaugaProdus(); //this is the change, code for redirect  
            f2.ShowDialog();
        }
    }
}
