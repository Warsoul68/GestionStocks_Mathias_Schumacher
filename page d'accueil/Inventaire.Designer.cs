namespace page_d_accueil
{
    partial class Inventaire
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
            this.lbllFiDepot = new System.Windows.Forms.Label();
            this.cbFiDepot = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbRefArticle = new System.Windows.Forms.ComboBox();
            this.lblRefArticle = new System.Windows.Forms.Label();
            this.dS_Selection_Inventaire = new page_d_accueil.DS_Selection_Inventaire();
            this.vueInventaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vue_InventaireTableAdapter = new page_d_accueil.DS_Selection_InventaireTableAdapters.Vue_InventaireTableAdapter();
            this.référenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dépotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateetHeureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitéDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Inventaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueInventaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 38);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 16);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(101, 34);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(132, 22);
            this.txtDate.TabIndex = 1;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(29, 71);
            this.lblHeure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(50, 16);
            this.lblHeure.TabIndex = 2;
            this.lblHeure.Text = "Heure :";
            // 
            // txtHeure
            // 
            this.txtHeure.Location = new System.Drawing.Point(101, 68);
            this.txtHeure.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeure.Name = "txtHeure";
            this.txtHeure.Size = new System.Drawing.Size(132, 22);
            this.txtHeure.TabIndex = 3;
            // 
            // lbllFiDepot
            // 
            this.lbllFiDepot.AutoSize = true;
            this.lbllFiDepot.Location = new System.Drawing.Point(440, 34);
            this.lbllFiDepot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllFiDepot.Name = "lbllFiDepot";
            this.lbllFiDepot.Size = new System.Drawing.Size(107, 16);
            this.lbllFiDepot.TabIndex = 4;
            this.lbllFiDepot.Text = "Filtrer par dépôt :";
            // 
            // cbFiDepot
            // 
            this.cbFiDepot.FormattingEnabled = true;
            this.cbFiDepot.Location = new System.Drawing.Point(563, 31);
            this.cbFiDepot.Margin = new System.Windows.Forms.Padding(4);
            this.cbFiDepot.Name = "cbFiDepot";
            this.cbFiDepot.Size = new System.Drawing.Size(160, 24);
            this.cbFiDepot.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.référenceDataGridViewTextBoxColumn,
            this.dépotDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateetHeureDataGridViewTextBoxColumn,
            this.quantitéDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vueInventaireBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(721, 241);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Location = new System.Drawing.Point(652, 405);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrer.TabIndex = 15;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(241, 405);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(191, 28);
            this.btnValider.TabIndex = 16;
            this.btnValider.Text = "Valider les niveaux saisis ";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(31, 405);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.btnAnnuler.TabIndex = 17;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // cbRefArticle
            // 
            this.cbRefArticle.FormattingEnabled = true;
            this.cbRefArticle.Location = new System.Drawing.Point(627, 68);
            this.cbRefArticle.Margin = new System.Windows.Forms.Padding(4);
            this.cbRefArticle.Name = "cbRefArticle";
            this.cbRefArticle.Size = new System.Drawing.Size(115, 24);
            this.cbRefArticle.TabIndex = 11;
            // 
            // lblRefArticle
            // 
            this.lblRefArticle.AutoSize = true;
            this.lblRefArticle.Location = new System.Drawing.Point(440, 71);
            this.lblRefArticle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefArticle.Name = "lblRefArticle";
            this.lblRefArticle.Size = new System.Drawing.Size(179, 16);
            this.lblRefArticle.TabIndex = 10;
            this.lblRefArticle.Text = "Filtrer par reference d\'article :";
            // 
            // dS_Selection_Inventaire
            // 
            this.dS_Selection_Inventaire.DataSetName = "DS_Selection_Inventaire";
            this.dS_Selection_Inventaire.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vueInventaireBindingSource
            // 
            this.vueInventaireBindingSource.DataMember = "Vue_Inventaire";
            this.vueInventaireBindingSource.DataSource = this.dS_Selection_Inventaire;
            // 
            // vue_InventaireTableAdapter
            // 
            this.vue_InventaireTableAdapter.ClearBeforeFill = true;
            // 
            // référenceDataGridViewTextBoxColumn
            // 
            this.référenceDataGridViewTextBoxColumn.DataPropertyName = "Référence";
            this.référenceDataGridViewTextBoxColumn.HeaderText = "Référence";
            this.référenceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.référenceDataGridViewTextBoxColumn.Name = "référenceDataGridViewTextBoxColumn";
            this.référenceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dépotDataGridViewTextBoxColumn
            // 
            this.dépotDataGridViewTextBoxColumn.DataPropertyName = "Dépot";
            this.dépotDataGridViewTextBoxColumn.HeaderText = "Dépot";
            this.dépotDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dépotDataGridViewTextBoxColumn.Name = "dépotDataGridViewTextBoxColumn";
            this.dépotDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateetHeureDataGridViewTextBoxColumn
            // 
            this.dateetHeureDataGridViewTextBoxColumn.DataPropertyName = "Date_et_Heure";
            this.dateetHeureDataGridViewTextBoxColumn.HeaderText = "Date_et_Heure";
            this.dateetHeureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateetHeureDataGridViewTextBoxColumn.Name = "dateetHeureDataGridViewTextBoxColumn";
            this.dateetHeureDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantitéDataGridViewTextBoxColumn
            // 
            this.quantitéDataGridViewTextBoxColumn.DataPropertyName = "Quantité";
            this.quantitéDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.quantitéDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantitéDataGridViewTextBoxColumn.Name = "quantitéDataGridViewTextBoxColumn";
            this.quantitéDataGridViewTextBoxColumn.Width = 125;
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 455);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbRefArticle);
            this.Controls.Add(this.lblRefArticle);
            this.Controls.Add(this.cbFiDepot);
            this.Controls.Add(this.lbllFiDepot);
            this.Controls.Add(this.txtHeure);
            this.Controls.Add(this.lblHeure);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Inventaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vueInventaireBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.TextBox txtHeure;
        private System.Windows.Forms.Label lbllFiDepot;
        private System.Windows.Forms.ComboBox cbFiDepot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ComboBox cbRefArticle;
        private System.Windows.Forms.Label lblRefArticle;
        private DS_Selection_Inventaire dS_Selection_Inventaire;
        private System.Windows.Forms.BindingSource vueInventaireBindingSource;
        private DS_Selection_InventaireTableAdapters.Vue_InventaireTableAdapter vue_InventaireTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn référenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dépotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateetHeureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitéDataGridViewTextBoxColumn;
    }
}