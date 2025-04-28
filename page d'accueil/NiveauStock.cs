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
    public partial class NiveauStock : Form
    {
        public NiveauStock()
        {
            InitializeComponent();
        }

        private void NiveauStock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_Niveau_Stock.Vue_Niveau_Stock'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vue_Niveau_StockTableAdapter.Fill(this.dS_Selection_Niveau_Stock.Vue_Niveau_Stock);

        }
    }
}
