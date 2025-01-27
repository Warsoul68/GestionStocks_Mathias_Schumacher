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
    }
}
