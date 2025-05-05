using LIB_BLL;
using LIB_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page_d_accueil
{
    public partial class ListeDepot : Form
    {
        public ListeDepot()
        {
            InitializeComponent();
        }

        private void ListeDepot_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_Liste_Depot.Depot'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.depotTableAdapter.Fill(this.dS_Selection_Liste_Depot.Depot);

        }

        private void btnAjouterDepot_Click(object sender, EventArgs e)
        {
            Depot unDepot = new Depot(txtNom.Text, txtVille.Text, txtPays.Text, txtLongitude.Text, txtLatitude.Text);
            int res = DepotDAO.creer(unDepot);
            if (res == 1)
            {
                MessageBox.Show("Ajout effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur l'ajout");
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Depot unDepot = new Depot(txtNom.Text, txtVille.Text, txtPays.Text, txtLongitude.Text, txtLatitude.Text);
            int res = DepotDAO.supprimer(unDepot);
            if (res == 1)
            {
                MessageBox.Show("Suppression effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur  la suppression");
            }


        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            Depot unDepot = new Depot(txtNom.Text, txtVille.Text, txtPays.Text, txtLongitude.Text, txtLatitude.Text);
            int res = DepotDAO.modifier(unDepot);
            if (res == 1)
            {
                MessageBox.Show("Modification effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur la modification");
            }
        }
    }
}

