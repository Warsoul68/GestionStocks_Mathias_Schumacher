using LIB_BLL;
using LIB_DAL;
using System;
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
                cbCategorie.Items.Add(c);
            }
            foreach (Fabricant f in FabricantDAO.getTousLesFabricant())
            {
                cbFabricant.Items.Add(f);
            }
            foreach (Unite u in UniteDAO.getTouteLesUnites())
            {
                cbUnite.Items.Add(u);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Categorie c = (Categorie)cbCategorie.SelectedItem;
            Fabricant f = (Fabricant)cbFabricant.SelectedItem;
            Unite u = (Unite)cbUnite.SelectedItem;

            string codeCategorie = c.getCodeCategorie();
            int idFabricant = f.getIdF();
            string codeUnite = u.getCodeUnite();

            Article unArticle = new Article(txtRef.Text, txtLibelle.Text, codeUnite, codeCategorie, idFabricant);

            int res = ArticleDAO.creer(unArticle);
            if (res == 1)
            {
                MessageBox.Show("Ajout effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur l'ajout");
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
