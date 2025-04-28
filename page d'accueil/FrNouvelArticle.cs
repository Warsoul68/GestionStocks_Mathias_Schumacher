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
    public partial class FrNouvelArticle : Form
    {
        public FrNouvelArticle()
        {
            InitializeComponent();
        }

        private void FrNouvelArticle_Load(object sender, EventArgs e)
        {
            foreach (Categorie c in CategorieDAO.getTouteLesCategorie())
            {
                cbCategorie.Items.Add(c.getLibelleCC());
            }
            foreach (Fabricant f in FabricantDAO.getTousLesFabricant())
            {
                cbFabricant.Items.Add(f.getNomEntreprise());
            }
            foreach (Unite u in UniteDAO.getTouteLesUnites())
            {
                cbUnite.Items.Add(u.getlibelleCU());
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
