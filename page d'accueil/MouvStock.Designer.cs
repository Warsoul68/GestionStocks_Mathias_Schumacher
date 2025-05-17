namespace page_d_accueil
{
    partial class MouvStock
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
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.txtHeure = new System.Windows.Forms.TextBox();
            this.lblFiDepot = new System.Windows.Forms.Label();
            this.cbFiDepot = new System.Windows.Forms.ComboBox();
            this.lblFiCategorieArticle = new System.Windows.Forms.Label();
            this.cbFiCategorieArticle = new System.Windows.Forms.ComboBox();
            this.lblFiFabricant = new System.Windows.Forms.Label();
            this.cbFiFabricant = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateetheureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catégorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueSelectionMouvStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Selection_MouvStock = new page_d_accueil.DS_Selection_MouvStock();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.vue_Selection_MouvStockTableAdapter = new page_d_accueil.DS_Selection_MouvStockTableAdapters.Vue_Selection_MouvStockTableAdapter();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionMouvStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_MouvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 42);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(93, 38);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 22);
            this.txtDate.TabIndex = 1;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(29, 75);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(50, 16);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "Heure :";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(93, 71);
            this.txtHeure.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(132, 22);
            this.txtHeure.TabIndex = 3;
            // 
            // lblFiDepot
            // 
            this.lblFiDepot.AutoSize = true;
            this.lblFiDepot.Location = new System.Drawing.Point(417, 42);
            this.lblFiDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiDepot.Name = "lblFiDepot";
            this.lblFiDepot.Size = new System.Drawing.Size(110, 16);
            this.lblFiDepot.TabIndex = 4;
            this.lblFiDepot.Text = "Filtrer par dépôt : ";
            // 
            // cbFiDepot
            // 
            this.cbFiDepot.FormattingEnabled = true;
            this.cbFiDepot.Location = new System.Drawing.Point(544, 38);
            this.cbFiDepot.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiDepot.Name = "cbFiDepot";
            this.cbFiDepot.Size = new System.Drawing.Size(160, 24);
            this.cbFiDepot.TabIndex = 5;
            // 
            // lblFiCategorieArticle
            // 
            this.lblFiCategorieArticle.AutoSize = true;
            this.lblFiCategorieArticle.Location = new System.Drawing.Point(205, 131);
            this.lblFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiCategorieArticle.Name = "lblFiCategorieArticle";
            this.lblFiCategorieArticle.Size = new System.Drawing.Size(179, 16);
            this.lblFiCategorieArticle.TabIndex = 10;
            this.lblFiCategorieArticle.Text = "Filtrer par catégorie d\'article :";
            // 
            // cbFiCategorieArticle
            // 
            this.cbFiCategorieArticle.FormattingEnabled = true;
            this.cbFiCategorieArticle.Location = new System.Drawing.Point(392, 128);
            this.cbFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiCategorieArticle.Name = "cbFiCategorieArticle";
            this.cbFiCategorieArticle.Size = new System.Drawing.Size(107, 24);
            this.cbFiCategorieArticle.TabIndex = 11;
            // 
            // lblFiFabricant
            // 
            this.lblFiFabricant.AutoSize = true;
            this.lblFiFabricant.Location = new System.Drawing.Point(414, 74);
            this.lblFiFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiFabricant.Name = "lblFiFabricant";
            this.lblFiFabricant.Size = new System.Drawing.Size(123, 16);
            this.lblFiFabricant.TabIndex = 12;
            this.lblFiFabricant.Text = "Filtrer par fabricant :";
            // 
            // cbFiFabricant
            // 
            this.cbFiFabricant.FormattingEnabled = true;
            this.cbFiFabricant.Location = new System.Drawing.Point(545, 72);
            this.cbFiFabricant.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiFabricant.Name = "cbFiFabricant";
            this.cbFiFabricant.Size = new System.Drawing.Size(160, 24);
            this.cbFiFabricant.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.dateetheureDataGridViewTextBoxColumn,
            this.dépotDataGridViewTextBoxColumn,
            this.catégorieDataGridViewTextBoxColumn,
            this.fabricantDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueSelectionMouvStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(813, 243);
            this.dataGridView1.TabIndex = 14;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateetheureDataGridViewTextBoxColumn
            // 
            this.dateetheureDataGridViewTextBoxColumn.DataPropertyName = "Date_et_heure";
            this.dateetheureDataGridViewTextBoxColumn.HeaderText = "Date_et_heure";
            this.dateetheureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateetheureDataGridViewTextBoxColumn.Name = "dateetheureDataGridViewTextBoxColumn";
            this.dateetheureDataGridViewTextBoxColumn.Width = 125;
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            this.dépotDataGridViewTextBoxColumn.Width = 125;
            // 
            // catégorieDataGridViewTextBoxColumn
            // 
            this.catégorieDataGridViewTextBoxColumn.DataPropertyName = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catégorieDataGridViewTextBoxColumn.Name = "catégorieDataGridViewTextBoxColumn";
            this.catégorieDataGridViewTextBoxColumn.Width = 125;
            // 
            // fabricantDataGridViewTextBoxColumn
            // 
            this.fabricantDataGridViewTextBoxColumn.DataPropertyName = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.HeaderText = "Fabricant";
            this.fabricantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fabricantDataGridViewTextBoxColumn.Name = "fabricantDataGridViewTextBoxColumn";
            this.fabricantDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // vueSelectionMouvStockBindingSource
            // 
            this.vueSelectionMouvStockBindingSource.DataMember = "Vue_Selection_MouvStock";
            this.vueSelectionMouvStockBindingSource.DataSource = this.dS_Selection_MouvStock;
            // 
            // dS_Selection_MouvStock
            // 
            this.dS_Selection_MouvStock.DataSetName = "DS_Selection_MouvStock";
            this.dS_Selection_MouvStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(399, 427);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrer.TabIndex = 15;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // vue_Selection_MouvStockTableAdapter
            // 
            this.vue_Selection_MouvStockTableAdapter.ClearBeforeFill = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(32, 430);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Nouveau mouvement";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MouvStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFiFabricant);
            this.Controls.Add(this.lblFiFabricant);
            this.Controls.Add(this.cbFiCategorieArticle);
            this.Controls.Add(this.lblFiCategorieArticle);
            this.Controls.Add(this.cbFiDepot);
            this.Controls.Add(this.lblFiDepot);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MouvStock";
            this.Text = "Mouvement de Stock";
            this.Load += new System.EventHandler(this.MouvStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueSelectionMouvStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_MouvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lblFiDepot;
        private System.Windows.Forms.ComboBox cbFiDepot;
        private System.Windows.Forms.Label lblFiCategorieArticle;
        private System.Windows.Forms.ComboBox cbFiCategorieArticle;
        private System.Windows.Forms.Label lblFiFabricant;
        private System.Windows.Forms.ComboBox cbFiFabricant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrer;
        private DS_Selection_MouvStock dS_Selection_MouvStock;
        private System.Windows.Forms.BindingSource vueSelectionMouvStockBindingSource;
        private DS_Selection_MouvStockTableAdapters.Vue_Selection_MouvStockTableAdapter vue_Selection_MouvStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateetheureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catégorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button button1;
    }
}