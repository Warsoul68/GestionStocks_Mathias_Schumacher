using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIB_BLL;
using LIB_DAL;

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
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_Article.Vue_Selection_Article'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vue_Selection_ArticleTableAdapter.Fill(this.dS_Selection_Article.Vue_Selection_Article);

            Connexion C = new Connexion();
            C.ShowDialog();

            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                MessageBox.Show("la connexion avec la base de donnée est réussie");
                MessageBox.Show(Bdd.afficherConnexion());
                foreach (Categorie c in CategorieDAO.getTouteLesCategorie())
                {
                    cboCategorie.Items.Add(c.getLibelleCC());
                }
                foreach (Fabricant f in FabricantDAO.getTousLesFabricant())
                {
                    cboFabricant.Items.Add(f.getNomEntreprise());
                }
                foreach (Depot d in DepotDAO.getTousLesDepot())
                {
                    cboDepot.Items.Add(d.getNomD());
                }
                foreach (Article a in ArticleDAO.getTouteLesArticle())
                {
                    cboLibelle.Items.Add(a.getLibelleA());
                }

            }

            else
            {
                MessageBox.Show("la connexion avec la base de donnée n'a pas été effectuer");


            }

        }

        private void listeMulticritèreDeRechercheDunEnsembleDarticlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrArticle A = new FrArticle();
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

        private void btnFiltrer_Click(object sender, EventArgs e)
        {

        }
    }
}
