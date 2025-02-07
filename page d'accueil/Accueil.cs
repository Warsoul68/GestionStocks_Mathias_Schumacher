using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_DAL;
using LIB_BLL;

namespace page_d_accueil
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Connexion C = new Connexion();
            C.ShowDialog();

            bool ouvert = Bdd.ouvrirConnexion();

            if (ouvert)
            {
                MessageBox.Show("la connexion avec la base de donnée est réussie");
                MessageBox.Show(Bdd.afficherConnexion());

            }

            else
            {
                MessageBox.Show("la connexion avec la base de donnée n'a pas été effectuer");


            }

        }

        private void listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Article A = new Article();
            A.Show();
        }

        private void listeMulticritèresDesNiveauxDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NiveauStock NS = new NiveauStock();
            NS.Show();

        }

        private void listeMulticritèresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeDepot LD = new ListeDepot();
            LD.Show();

        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeFabricant LF = new ListeFabricant();
            LF.Show();

        }

        private void btnNewArticle_Click(object sender, EventArgs e)
        {
            FrNouvelArticle FNA = new FrNouvelArticle();
            FNA.Show();
        }

        private void visualisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCategorieVisualise FCV = new FrCategorieVisualise();
            FCV.Show();
        }

        private void créationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCategorieCreer FCC = new FrCategorieCreer();
            FCC.Show();

        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCategorieUpdate FCU = new FrCategorieUpdate();
            FCU.Show();

        }

        private void suppressionDeCatégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrCategorieSupprimer FCS = new FrCategorieSupprimer();
            FCS.Show();

        }

        private void visualisationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrUniteVisualise FUV = new FrUniteVisualise();
            FUV.Show();

        }

        private void créationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrUniteCreer FUC = new FrUniteCreer();
            FUC.Show();

        }

        private void miseÀJourToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrUniteUpdate FUU = new FrUniteUpdate();
            FUU.Show();

        }

        private void suppressionDunitéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrUniteSupprimer FUS = new FrUniteSupprimer();
            FUS.Show();

        }

        private void listeMultiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventaire I = new Inventaire();
            I.Show();

        }

        private void listeMulticritèresDesMouvementsDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouvStock MS = new MouvStock();
            MS.Show();

        }

        private void selection_ArticleToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.articleTableAdapter.selection_Article(this.dS_Selction_Article.Article);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
