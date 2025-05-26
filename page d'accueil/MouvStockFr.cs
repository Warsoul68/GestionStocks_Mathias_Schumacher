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
    public partial class MouvStockFr : Form
    {
        public MouvStockFr()
        {
            InitializeComponent();
        }

        private void MouvStockFr_Load(object sender, EventArgs e)
        {
            foreach (Article a in ArticleDAO.getTousLesArticle())
            {
                cboArticle.Items.Add(a.getLibelleA());
            }

            foreach (Depot d in DepotDAO.getTousLesDepot())
            {
                cboDepot.Items.Add(d.getNomD());
            }

            foreach (TypeMouv tm in TypeMouvDAO.getTousLesType())
            {
                cboType.Items.Add(tm.getLibelleCT());
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

        }
    }
}
