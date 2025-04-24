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
    public partial class Inventaire : Form
    {
        public Inventaire()
        {
            InitializeComponent();
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Vue_Selection_Inventaire.Vue_Inventaire'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vue_InventaireTableAdapter.Fill(this.dS_Vue_Selection_Inventaire.Vue_Inventaire);

        }
    }
}
