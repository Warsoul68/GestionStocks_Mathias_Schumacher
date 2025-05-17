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
            this.dS_Selection_NiveauxStock = new page_d_accueil.DS_Selection_NiveauxStock();
            this.vueSelectionNiveauStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vue_Selection_NiveauStockTableAdapter = new page_d_accueil.DS_Selection_NiveauxStockTableAdapters.Vue_Selection_NiveauStockTableAdapter();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_NiveauxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionNiveauStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.Location = new System.Drawing.Point(12, 9);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(42, 13);
            this.lblDepot.TabIndex = 0;
            this.lblDepot.Text = "Dépôt :";
            // 
            // cbDepot
            // 
            this.cbDepot.FormattingEnabled = true;
            this.cbDepot.Location = new System.Drawing.Point(75, 6);
            this.cbDepot.Name = "cbDepot";
            this.cbDepot.Size = new System.Drawing.Size(257, 21);
            this.cbDepot.TabIndex = 1;
            // 
            // lblFabricant
            // 
            this.lblFabricant.AutoSize = true;
            this.lblFabricant.Location = new System.Drawing.Point(12, 40);
            this.lblFabricant.Name = "lblFabricant";
            this.lblFabricant.Size = new System.Drawing.Size(57, 13);
            this.lblFabricant.TabIndex = 2;
            this.lblFabricant.Text = "Fabricant :";
            // 
            // cbFabricant
            // 
            this.cbFabricant.FormattingEnabled = true;
            this.cbFabricant.Location = new System.Drawing.Point(75, 37);
            this.cbFabricant.Name = "cbFabricant";
            this.cbFabricant.Size = new System.Drawing.Size(285, 21);
            this.cbFabricant.TabIndex = 3;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 66);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Catégorie :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(190, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblStockSuperieurOuEgale
            // 
            this.lblStockSuperieurOuEgale.AutoSize = true;
            this.lblStockSuperieurOuEgale.Location = new System.Drawing.Point(375, 40);
            this.lblStockSuperieurOuEgale.Name = "lblStockSuperieurOuEgale";
            this.lblStockSuperieurOuEgale.Size = new System.Drawing.Size(65, 13);
            this.lblStockSuperieurOuEgale.TabIndex = 6;
            this.lblStockSuperieurOuEgale.Text = "Stock >= à :";
            // 
            // cbStockInferieurOuEgale
            // 
            this.cbStockInferieurOuEgale.AutoSize = true;
            this.cbStockInferieurOuEgale.Location = new System.Drawing.Point(375, 14);
            this.cbStockInferieurOuEgale.Name = "cbStockInferieurOuEgale";
            this.cbStockInferieurOuEgale.Size = new System.Drawing.Size(65, 13);
            this.cbStockInferieurOuEgale.TabIndex = 7;
            this.cbStockInferieurOuEgale.Text = "Stock <= à :";
            // 
            // txtStockInferieurOuEgale
            // 
            this.txtStockInferieurOuEgale.Location = new System.Drawing.Point(462, 7);
            this.txtStockInferieurOuEgale.Name = "txtStockInferieurOuEgale";
            this.txtStockInferieurOuEgale.Size = new System.Drawing.Size(63, 20);
            this.txtStockInferieurOuEgale.TabIndex = 8;
            // 
            // txtStockSuperieurOuEgale
            // 
            this.txtStockSuperieurOuEgale.Location = new System.Drawing.Point(462, 33);
            this.txtStockSuperieurOuEgale.Name = "txtStockSuperieurOuEgale";
            this.txtStockSuperieurOuEgale.Size = new System.Drawing.Size(63, 20);
            this.txtStockSuperieurOuEgale.TabIndex = 9;
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(375, 66);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(81, 13);
            this.lblDateHeure.TabIndex = 10;
            this.lblDateHeure.Text = "Date et heure : ";
            // 
            // txtDateHeure
            // 
            this.txtDateHeure.Location = new System.Drawing.Point(462, 63);
            this.txtDateHeure.Name = "txtDateHeure";
            this.txtDateHeure.Size = new System.Drawing.Size(100, 20);
            this.txtDateHeure.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dépotDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.unitéDataGridViewTextBoxColumn,
            this.fabricantDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueSelectionNiveauStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(549, 189);
            this.dataGridView1.TabIndex = 12;
            // 
            // dS_Selection_NiveauxStock
            // 
            this.dS_Selection_NiveauxStock.DataSetName = "DS_Selection_NiveauxStock";
            this.dS_Selection_NiveauxStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueSelectionNiveauStockBindingSource
            // 
            this.vueSelectionNiveauStockBindingSource.DataMember = "Vue_Selection_NiveauStock";
            this.vueSelectionNiveauStockBindingSource.DataSource = this.dS_Selection_NiveauxStock;
            // 
            // vue_Selection_NiveauStockTableAdapter
            // 
            this.vue_Selection_NiveauStockTableAdapter.ClearBeforeFill = true;
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // unitéDataGridViewTextBoxColumn
            // 
            this.unitéDataGridViewTextBoxColumn.DataPropertyName = "Unité";
            this.unitéDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.unitéDataGridViewTextBoxColumn.Name = "unitéDataGridViewTextBoxColumn";
            // 
            // fabricantDataGridViewTextBoxColumn
            // 
            this.fabricantDataGridViewTextBoxColumn.DataPropertyName = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.HeaderText = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.Name = "fabricantDataGridViewTextBoxColumn";
            // 
            // NiveauStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 334);
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
            this.Name = "NiveauStock";
            this.Text = "Niveaux de stock";
            this.Load += new System.EventHandler(this.NiveauStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_NiveauxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionNiveauStockBindingSource)).EndInit();
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
        private DS_Selection_NiveauxStock dS_Selection_NiveauxStock;
        private System.Windows.Forms.BindingSource vueSelectionNiveauStockBindingSource;
        private DS_Selection_NiveauxStockTableAdapters.Vue_Selection_NiveauStockTableAdapter vue_Selection_NiveauStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitéDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricantDataGridViewTextBoxColumn;
    }
}