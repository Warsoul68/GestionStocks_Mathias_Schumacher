namespace page_d_accueil
{
    partial class NiveauStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDepot = new System.Windows.Forms.Label();
            this.cbDepot = new System.Windows.Forms.ComboBox();
            this.lblFabricant = new System.Windows.Forms.Label();
            this.cbFabricant = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblStockSuperieurOuEgale = new System.Windows.Forms.Label();
            this.cbStockInferieurOuEgale = new System.Windows.Forms.Label();
            this.txtStockInferieurOuEgale = new System.Windows.Forms.TextBox();
            this.txtStockSuperieurOuEgale = new System.Windows.Forms.TextBox();
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.txtDateHeure = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dS_Vue_Selection_NiveauxStock = new page_d_accueil.DS_Vue_Selection_NiveauxStock();
            this.selectionniveauStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selection_niveauStockTableAdapter = new page_d_accueil.DS_Vue_Selection_NiveauxStockTableAdapters.Selection_niveauStockTableAdapter();
            this.dépôtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Vue_Selection_NiveauxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionniveauStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(16, 11);
            this.lblDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(50, 16);
            this.lblDepot.TabIndex = 0;
            this.lblDepot.Text = "Dépôt :";
            // 
            // cbDepot
            // 
            this.cbDepot.FormattingEnabled = true;
            this.cbDepot.Location = new System.Drawing.Point(100, 7);
            this.cbDepot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDepot.Name = "cbDepot";
            this.cbDepot.Size = new System.Drawing.Size(341, 24);
            this.cbDepot.TabIndex = 1;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(16, 49);
            this.lblFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(69, 16);
            this.lblFabricant.TabIndex = 2;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(100, 46);
            this.cbFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(379, 24);
            this.cbFabricant.TabIndex = 3;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(16, 81);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(72, 16);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 78);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // lblStockSuperieurOuEgale
            // 
            this.lblStockSuperieurOuEgale.AutoSize = true;
            this.lblStockSuperieurOuEgale.Location = new System.Drawing.Point(500, 49);
            this.lblStockSuperieurOuEgale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockSuperieurOuEgale.Name = "lblStockSuperieurOuEgale";
            this.lblStockSuperieurOuEgale.Size = new System.Drawing.Size(75, 16);
            this.lblStockSuperieurOuEgale.TabIndex = 6;
            this.lblStockSuperieurOuEgale.Text = "Stock >= à :";
            // 
            // cbStockInferieurOuEgale
            // 
            this.cbStockInferieurOuEgale.AutoSize = true;
            this.cbStockInferieurOuEgale.Location = new System.Drawing.Point(500, 17);
            this.cbStockInferieurOuEgale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cbStockInferieurOuEgale.Name = "cbStockInferieurOuEgale";
            this.cbStockInferieurOuEgale.Size = new System.Drawing.Size(75, 16);
            this.cbStockInferieurOuEgale.TabIndex = 7;
            this.cbStockInferieurOuEgale.Text = "Stock <= à :";
            // 
            // txtStockInferieurOuEgale
            // 
            this.txtStockInferieurOuEgale.Location = new System.Drawing.Point(616, 9);
            this.txtStockInferieurOuEgale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockInferieurOuEgale.Name = "txtStockInferieurOuEgale";
            this.txtStockInferieurOuEgale.Size = new System.Drawing.Size(83, 22);
            this.txtStockInferieurOuEgale.TabIndex = 8;
            // 
            // txtStockSuperieurOuEgale
            // 
            this.txtStockSuperieurOuEgale.Location = new System.Drawing.Point(616, 41);
            this.txtStockSuperieurOuEgale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStockSuperieurOuEgale.Name = "txtStockSuperieurOuEgale";
            this.txtStockSuperieurOuEgale.Size = new System.Drawing.Size(83, 22);
            this.txtStockSuperieurOuEgale.TabIndex = 9;
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(500, 81);
            this.lblDateHeure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(96, 16);
            this.lblDateHeure.TabIndex = 10;
            this.lblDateHeure.Text = "Date et heure : ";
            // 
            // txtDateHeure
            // 
            this.txtDateHeure.Location = new System.Drawing.Point(616, 78);
            this.txtDateHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDateHeure.Name = "txtDateHeure";
            this.txtDateHeure.Size = new System.Drawing.Size(132, 22);
            this.txtDateHeure.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dépôtDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.quantitéDataGridViewTextBoxColumn,
            this.unitéDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.selectionniveauStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 135);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(763, 233);
            this.dataGridView1.TabIndex = 12;
            // 
            // dS_Vue_Selection_NiveauxStock
            // 
            this.dS_Vue_Selection_NiveauxStock.DataSetName = "DS_Vue_Selection_NiveauxStock";
            this.dS_Vue_Selection_NiveauxStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectionniveauStockBindingSource
            // 
            this.selectionniveauStockBindingSource.DataMember = "Selection_niveauStock";
            this.selectionniveauStockBindingSource.DataSource = this.dS_Vue_Selection_NiveauxStock;
            // 
            // selection_niveauStockTableAdapter
            // 
            this.selection_niveauStockTableAdapter.ClearBeforeFill = true;
            // 
            // dépôtDataGridViewTextBoxColumn
            // 
            this.dépôtDataGridViewTextBoxColumn.DataPropertyName = "Dépôt";
            this.dépôtDataGridViewTextBoxColumn.HeaderText = "Dépôt";
            this.dépôtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dépôtDataGridViewTextBoxColumn.Name = "dépôtDataGridViewTextBoxColumn";
            this.dépôtDataGridViewTextBoxColumn.Width = 125;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitéDataGridViewTextBoxColumn
            // 
            this.quantitéDataGridViewTextBoxColumn.DataPropertyName = "Quantité";
            this.quantitéDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.quantitéDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitéDataGridViewTextBoxColumn.Name = "quantitéDataGridViewTextBoxColumn";
            this.quantitéDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitéDataGridViewTextBoxColumn
            // 
            this.unitéDataGridViewTextBoxColumn.DataPropertyName = "Unité";
            this.unitéDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.unitéDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitéDataGridViewTextBoxColumn.Name = "unitéDataGridViewTextBoxColumn";
            this.unitéDataGridViewTextBoxColumn.Width = 125;
            // 
            // NiveauStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDateHeure);
            this.Controls.Add(this.lblDateHeure);
            this.Controls.Add(this.txtStockSuperieurOuEgale);
            this.Controls.Add(this.txtStockInferieurOuEgale);
            this.Controls.Add(this.cbStockInferieurOuEgale);
            this.Controls.Add(this.lblStockSuperieurOuEgale);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cbFabricant);
            this.Controls.Add(this.lblFabricant);
            this.Controls.Add(this.cbDepot);
            this.Controls.Add(this.lblDepot);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NiveauStock";
            this.Text = "Niveaux de stock";
            this.Load += new System.EventHandler(this.NiveauStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Vue_Selection_NiveauxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionniveauStockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepot;
        private System.Windows.Forms.ComboBox cbDepot;
        private System.Windows.Forms.Label lblFabricant;
        private System.Windows.Forms.ComboBox cbFabricant;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblStockSuperieurOuEgale;
        private System.Windows.Forms.Label cbStockInferieurOuEgale;
        private System.Windows.Forms.TextBox txtStockInferieurOuEgale;
        private System.Windows.Forms.TextBox txtStockSuperieurOuEgale;
        private System.Windows.Forms.Label lblDateHeure;
        private System.Windows.Forms.TextBox txtDateHeure;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Vue_Selection_NiveauxStock dS_Vue_Selection_NiveauxStock;
        private System.Windows.Forms.BindingSource selectionniveauStockBindingSource;
        private DS_Vue_Selection_NiveauxStockTableAdapters.Selection_niveauStockTableAdapter selection_niveauStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépôtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitéDataGridViewTextBoxColumn;
    }
}