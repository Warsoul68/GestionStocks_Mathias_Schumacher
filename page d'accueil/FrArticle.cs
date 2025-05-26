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
    public partial class FrArticle : Form
    {
        public FrArticle()
        {
            InitializeComponent();
        }

        private void FrArticle_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_Vue_FrArticle.Vue_Selection_frArticle'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vue_Selection_frArticleTableAdapter.Fill(this.dS_Selection_Vue_FrArticle.Vue_Selection_frArticle);

            foreach (Article a in ArticleDAO.getTousLesArticle())
            {
                cbReRef.Items.Add(a.getReferenceA());
                cbLibelleArticle.Items.Add(a.getLibelleA());
            }

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

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Categorie c = (Categorie)cbCategorie.SelectedItem;
            Fabricant f = (Fabricant)cbFabricant.SelectedItem;
            Unite u = (Unite)cbUnite.SelectedItem;

            string codeCategorie = c.getCodeCategorie();
            int idFabricant = f.getIdF();
            string codeUnite = u.getCodeUnite();

            Article unArticle = new Article(txtRef.Text, txtLibelle.Text, codeUnite, codeCategorie, idFabricant);
            int res = ArticleDAO.supprimer(unArticle);
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
            Categorie c = (Categorie)cbCategorie.SelectedItem;
            Fabricant f = (Fabricant)cbFabricant.SelectedItem;
            Unite u = (Unite)cbUnite.SelectedItem;
                           
            string codeCategorie = c.getCodeCategorie();
            int idFabricant = f.getIdF();
            string codeUnite = u.getCodeUnite();

            Article unArticle = new Article(txtRef.Text, txtLibelle.Text, codeUnite, codeCategorie, idFabricant);
            int res = ArticleDAO.modifier(unArticle);
            if (res == 1)
            {
                MessageBox.Show("Modification effectuée");
            }
            else
            {
                MessageBox.Show("Problème sur la modification");
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string referenceArticle = cbReRef.Text;
            string libelleArticle = cbLibelleArticle.Text;

            Article a = ArticleDAO.rechercher(referenceArticle, libelleArticle);
            if (a != null)
            {
                txtRef.Text = a.getReferenceA();
                txtLibelle.Text = a.getLibelleA();

                cbCategorie.SelectedItem = cbCategorie.Items
                    .Cast<Categorie>()
                    .FirstOrDefault(c => c.getCodeCategorie() == a.getCodeCategorie());

                cbFabricant.SelectedItem = cbFabricant.Items
                    .Cast<Fabricant>()
                    .FirstOrDefault(f => f.getIdF() == a.getIdFabricant());

                cbUnite.SelectedItem = cbUnite.Items
                  .Cast<Unite>()
                  .FirstOrDefault(u => u.getCodeUnite() == a.getCodeUnite());
            }
            else
            {
                MessageBox.Show("Article non trouvé.");
            }
        }
    }
}
