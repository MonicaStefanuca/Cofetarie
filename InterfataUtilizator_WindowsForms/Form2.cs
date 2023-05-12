using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

using NivelStocareDate;
using EvidentaProduse;
using System.Net.Http.Headers;

namespace InterfataUtilizator_WindowsForms
{
    public partial class AdaugaProdus : Form
    {
        static string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
        AdministrareProduse_FisierText adminProduse = new AdministrareProduse_FisierText(numeFisier);
        public AdaugaProdus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void adauga_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvidentaProduse.Produs p = new EvidentaProduse.Produs(Convert.ToInt32(idProdus.Text), NumeProdus.Text, Convert.ToInt32(pretProdus.Text), Convert.ToInt32(gramajProdus.Text), descriereProdus.Text, Convert.ToInt32(NumarProdusePreparate.Text));
            adminProduse.AddProdus(p);
        }

        private void NumarProdusePreparate_Click(object sender, EventArgs e)
        {

        }
    }
}
