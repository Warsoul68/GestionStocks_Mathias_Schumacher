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
    public partial class FrUniteVisualise : Form
    {
        public FrUniteVisualise()
        {
            InitializeComponent();
        }

        private void FrUniteVisualise_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bD_STOCK_SCHUMACHERDataSet1.Unite'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.uniteTableAdapter.Fill(this.bD_STOCK_SCHUMACHERDataSet1.Unite);

        }
    }
}
