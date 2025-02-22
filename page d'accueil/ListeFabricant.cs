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
    public partial class ListeFabricant : Form
    {
        public ListeFabricant()
        {
            InitializeComponent();
        }

        private void ListeFabricant_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Liste_fabricant.Fabricant'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.fabricantTableAdapter.Fill(this.dS_Liste_fabricant.Fabricant);

        }
    }
}
