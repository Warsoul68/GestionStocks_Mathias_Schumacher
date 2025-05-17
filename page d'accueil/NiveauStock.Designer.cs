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
            this.lblArticle = new System.Windows.Forms.Label();
            this.cboArticle = new System.Windows.Forms.ComboBox();
            this.lblStockSuperieurOuEgale = new System.Windows.Forms.Label();
            this.cbStockInferieurOuEgale = new System.Windows.Forms.Label();
            this.txtStockInferieurOuEgale = new System.Windows.Forms.TextBox();
            this.txtStockSuperieurOuEgale = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vueNiveauStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Selection_Niveau_Stock = new page_d_accueil.DS_Selection_Niveau_Stock();
            this.vue_Niveau_StockTableAdapter = new page_d_accueil.DS_Selection_Niveau_StockTableAdapters.Vue_Niveau_StockTableAdapter();
            this.btnFiltrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueNiveauStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Niveau_Stock)).BeginInit();
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
            this.cbDepot.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepot.Name = "cbDepot";
            this.cbDepot.Size = new System.Drawing.Size(341, 24);
            this.cbDepot.TabIndex = 1;
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.Location = new System.Drawing.Point(13, 44);
            this.lblArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(50, 16);
            this.lblArticle.TabIndex = 4;
            this.lblArticle.Text = "Article :";
            // 
            // cboArticle
            // 
            this.cboArticle.FormattingEnabled = true;
            this.cboArticle.Location = new System.Drawing.Point(100, 41);
            this.cboArticle.Margin = new System.Windows.Forms.Padding(4);
            this.cboArticle.Name = "cboArticle";
            this.cboArticle.Size = new System.Drawing.Size(252, 24);
            this.cboArticle.TabIndex = 5;
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
            this.txtStockInferieurOuEgale.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockInferieurOuEgale.Name = "txtStockInferieurOuEgale";
            this.txtStockInferieurOuEgale.Size = new System.Drawing.Size(83, 22);
            this.txtStockInferieurOuEgale.TabIndex = 8;
            // 
            // txtStockSuperieurOuEgale
            // 
            this.txtStockSuperieurOuEgale.Location = new System.Drawing.Point(616, 41);
            this.txtStockSuperieurOuEgale.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockSuperieurOuEgale.Name = "txtStockSuperieurOuEgale";
            this.txtStockSuperieurOuEgale.Size = new System.Drawing.Size(83, 22);
            this.txtStockSuperieurOuEgale.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dépotDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.unitéDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueNiveauStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(19, 125);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(732, 233);
            this.dataGridView1.TabIndex = 12;
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            this.dépotDataGridViewTextBoxColumn.Width = 125;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 125;
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "Qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Qte";
            this.qteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            this.qteDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitéDataGridViewTextBoxColumn
            // 
            this.unitéDataGridViewTextBoxColumn.DataPropertyName = "Unité";
            this.unitéDataGridViewTextBoxColumn.HeaderText = "Unité";
            this.unitéDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitéDataGridViewTextBoxColumn.Name = "unitéDataGridViewTextBoxColumn";
            this.unitéDataGridViewTextBoxColumn.Width = 125;
            // 
            // vueNiveauStockBindingSource
            // 
            this.vueNiveauStockBindingSource.DataMember = "Vue_Niveau_Stock";
            this.vueNiveauStockBindingSource.DataSource = this.dS_Selection_Niveau_Stock;
            // 
            // dS_Selection_Niveau_Stock
            // 
            this.dS_Selection_Niveau_Stock.DataSetName = "DS_Selection_Niveau_Stock";
            this.dS_Selection_Niveau_Stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vue_Niveau_StockTableAdapter
            // 
            this.vue_Niveau_StockTableAdapter.ClearBeforeFill = true;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(366, 85);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrer.TabIndex = 13;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // NiveauStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 371);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStockSuperieurOuEgale);
            this.Controls.Add(this.txtStockInferieurOuEgale);
            this.Controls.Add(this.cbStockInferieurOuEgale);
            this.Controls.Add(this.lblStockSuperieurOuEgale);
            this.Controls.Add(this.cboArticle);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.cbDepot);
            this.Controls.Add(this.lblDepot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NiveauStock";
            this.Text = "Niveaux de stock";
            this.Load += new System.EventHandler(this.NiveauStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueNiveauStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Niveau_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDepot;
        private System.Windows.Forms.ComboBox cbDepot;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.ComboBox cboArticle;
        private System.Windows.Forms.Label lblStockSuperieurOuEgale;
        private System.Windows.Forms.Label cbStockInferieurOuEgale;
        private System.Windows.Forms.TextBox txtStockInferieurOuEgale;
        private System.Windows.Forms.TextBox txtStockSuperieurOuEgale;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DS_Selection_Niveau_Stock dS_Selection_Niveau_Stock;
        private System.Windows.Forms.BindingSource vueNiveauStockBindingSource;
        private DS_Selection_Niveau_StockTableAdapters.Vue_Niveau_StockTableAdapter vue_Niveau_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitéDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFiltrer;
    }
}