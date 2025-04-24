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
    public partial class FrCategorieVisualise : Form
    {
        public FrCategorieVisualise()
        {
            InitializeComponent();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {

        }

        private void FrCategorieVisualise_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_ParametreCategorie.Categorie'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categorieTableAdapter.Fill(this.dS_Selection_ParametreCategorie.Categorie);

        }
    }
}
