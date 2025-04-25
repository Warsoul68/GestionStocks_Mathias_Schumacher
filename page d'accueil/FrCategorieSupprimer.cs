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
    public partial class FrCategorieSupprimer : Form
    {
        public FrCategorieSupprimer()
        {
            InitializeComponent();
        }

        private void FrCategorieSupprimer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_Parametre_Categorie.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.dS_Selection_Parametre_Categorie.Categorie);

        }
    }
}
