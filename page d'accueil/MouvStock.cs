﻿using System;
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
    public partial class MouvStock : Form
    {
        public MouvStock()
        {
            InitializeComponent();
        }

        private void MouvStock_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dS_Selection_MouvStock.Vue_Selection_MouvStock'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.vue_Selection_MouvStockTableAdapter.Fill(this.dS_Selection_MouvStock.Vue_Selection_MouvStock);

        }

        private void btnFrMouvStock_Click(object sender, EventArgs e)
        {
            MouvStockFr MSF = new MouvStockFr();
            MSF.Show();

        }
    }
}
