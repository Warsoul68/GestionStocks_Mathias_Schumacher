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
            this.lblFiVille = new System.Windows.Forms.Label();
            this.cbFiVille = new System.Windows.Forms.ComboBox();
            this.lblFiPays = new System.Windows.Forms.Label();
            this.cbFiPays = new System.Windows.Forms.ComboBox();
            this.lblFiCategorieArticle = new System.Windows.Forms.Label();
            this.cbFiCategorieArticle = new System.Windows.Forms.ComboBox();
            this.lblFiFabricant = new System.Windows.Forms.Label();
            this.cbFiFabricant = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dS_Selection_mouvStock = new page_d_accueil.DS_Selection_mouvStock();
            this.selectionmouvStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selection_mouvStockTableAdapter = new page_d_accueil.DS_Selection_mouvStockTableAdapters.Selection_mouvStockTableAdapter();
            this.dépôtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_mouvStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionmouvStockBindingSource)).BeginInit();
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
            this.txtDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.txtHeure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cbFiDepot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiDepot.Name = "cbFiDepot";
            this.cbFiDepot.Size = new System.Drawing.Size(160, 24);
            this.cbFiDepot.TabIndex = 5;
            // 
            // lblFiVille
            // 
            this.lblFiVille.AutoSize = true;
            this.lblFiVille.Location = new System.Drawing.Point(417, 75);
            this.lblFiVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiVille.Name = "lblFiVille";
            this.lblFiVille.Size = new System.Drawing.Size(96, 16);
            this.lblFiVille.TabIndex = 6;
            this.lblFiVille.Text = "Filtrer par ville :";
            // 
            // cbFiVille
            // 
            this.cbFiVille.FormattingEnabled = true;
            this.cbFiVille.Location = new System.Drawing.Point(544, 75);
            this.cbFiVille.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiVille.Name = "cbFiVille";
            this.cbFiVille.Size = new System.Drawing.Size(160, 24);
            this.cbFiVille.TabIndex = 7;
            // 
            // lblFiPays
            // 
            this.lblFiPays.AutoSize = true;
            this.lblFiPays.Location = new System.Drawing.Point(417, 111);
            this.lblFiPays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiPays.Name = "lblFiPays";
            this.lblFiPays.Size = new System.Drawing.Size(102, 16);
            this.lblFiPays.TabIndex = 8;
            this.lblFiPays.Text = "Filtrer par pays :";
            // 
            // cbFiPays
            // 
            this.cbFiPays.FormattingEnabled = true;
            this.cbFiPays.Location = new System.Drawing.Point(544, 107);
            this.cbFiPays.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiPays.Name = "cbFiPays";
            this.cbFiPays.Size = new System.Drawing.Size(160, 24);
            this.cbFiPays.TabIndex = 9;
            // 
            // lblFiCategorieArticle
            // 
            this.lblFiCategorieArticle.AutoSize = true;
            this.lblFiCategorieArticle.Location = new System.Drawing.Point(29, 107);
            this.lblFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiCategorieArticle.Name = "lblFiCategorieArticle";
            this.lblFiCategorieArticle.Size = new System.Drawing.Size(179, 16);
            this.lblFiCategorieArticle.TabIndex = 10;
            this.lblFiCategorieArticle.Text = "Filtrer par catégorie d\'article :";
            // 
            // cbFiCategorieArticle
            // 
            this.cbFiCategorieArticle.FormattingEnabled = true;
            this.cbFiCategorieArticle.Location = new System.Drawing.Point(227, 103);
            this.cbFiCategorieArticle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiCategorieArticle.Name = "cbFiCategorieArticle";
            this.cbFiCategorieArticle.Size = new System.Drawing.Size(107, 24);
            this.cbFiCategorieArticle.TabIndex = 11;
            // 
            // lblFiFabricant
            // 
            this.lblFiFabricant.AutoSize = true;
            this.lblFiFabricant.Location = new System.Drawing.Point(276, 154);
            this.lblFiFabricant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiFabricant.Name = "lblFiFabricant";
            this.lblFiFabricant.Size = new System.Drawing.Size(123, 16);
            this.lblFiFabricant.TabIndex = 12;
            this.lblFiFabricant.Text = "Filtrer par fabricant :";
            // 
            // cbFiFabricant
            // 
            this.cbFiFabricant.FormattingEnabled = true;
            this.cbFiFabricant.Location = new System.Drawing.Point(417, 150);
            this.cbFiFabricant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFiFabricant.Name = "cbFiFabricant";
            this.cbFiFabricant.Size = new System.Drawing.Size(160, 24);
            this.cbFiFabricant.TabIndex = 13;
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
            this.dataGridView1.DataSource = this.selectionmouvStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 206);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(673, 263);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(605, 476);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrer.TabIndex = 15;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(417, 476);
            this.btnCreer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(100, 28);
            this.btnCreer.TabIndex = 16;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(235, 476);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(32, 476);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 18;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // dS_Selection_mouvStock
            // 
            this.dS_Selection_mouvStock.DataSetName = "DS_Selection_mouvStock";
            this.dS_Selection_mouvStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectionmouvStockBindingSource
            // 
            this.selectionmouvStockBindingSource.DataMember = "Selection_mouvStock";
            this.selectionmouvStockBindingSource.DataSource = this.dS_Selection_mouvStock;
            // 
            // selection_mouvStockTableAdapter
            // 
            this.selection_mouvStockTableAdapter.ClearBeforeFill = true;
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
            // MouvStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 554);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbFiFabricant);
            this.Controls.Add(this.lblFiFabricant);
            this.Controls.Add(this.cbFiCategorieArticle);
            this.Controls.Add(this.lblFiCategorieArticle);
            this.Controls.Add(this.cbFiPays);
            this.Controls.Add(this.lblFiPays);
            this.Controls.Add(this.cbFiVille);
            this.Controls.Add(this.lblFiVille);
            this.Controls.Add(this.cbFiDepot);
            this.Controls.Add(this.lblFiDepot);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MouvStock";
            this.Text = "Mouvement de Stock";
            this.Load += new System.EventHandler(this.MouvStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_mouvStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectionmouvStockBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblFiVille;
        private System.Windows.Forms.ComboBox cbFiVille;
        private System.Windows.Forms.Label lblFiPays;
        private System.Windows.Forms.ComboBox cbFiPays;
        private System.Windows.Forms.Label lblFiCategorieArticle;
        private System.Windows.Forms.ComboBox cbFiCategorieArticle;
        private System.Windows.Forms.Label lblFiFabricant;
        private System.Windows.Forms.ComboBox cbFiFabricant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAnnuler;
        private DS_Selection_mouvStock dS_Selection_mouvStock;
        private System.Windows.Forms.BindingSource selectionmouvStockBindingSource;
        private DS_Selection_mouvStockTableAdapters.Selection_mouvStockTableAdapter selection_mouvStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépôtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitéDataGridViewTextBoxColumn;
    }
}