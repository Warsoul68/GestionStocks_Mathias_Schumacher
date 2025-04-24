namespace page_d_accueil
{
    partial class FrUniteSupprimer
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
            this.lblUnite = new System.Windows.Forms.Label();
            this.cbUnite = new System.Windows.Forms.ComboBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.dS_Selection_ParametreUnite = new page_d_accueil.DS_Selection_ParametreUnite();
            this.dSSelectionParametreUniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniteTableAdapter = new page_d_accueil.DS_Selection_ParametreUniteTableAdapters.UniteTableAdapter();
            this.codeUniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_ParametreUnite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSelectionParametreUniteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnite
            // 
            this.lblUnite.AutoSize = true;
            this.lblUnite.Location = new System.Drawing.Point(9, 20);
            this.lblUnite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnite.Name = "lblUnite";
            this.lblUnite.Size = new System.Drawing.Size(64, 13);
            this.lblUnite.TabIndex = 0;
            this.lblUnite.Text = "Code unité :";
            // 
            // cbUnite
            // 
            this.cbUnite.FormattingEnabled = true;
            this.cbUnite.Location = new System.Drawing.Point(71, 18);
            this.cbUnite.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnite.Name = "cbUnite";
            this.cbUnite.Size = new System.Drawing.Size(65, 21);
            this.cbUnite.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(9, 49);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(71, 49);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(85, 20);
            this.txtLibelle.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeUniteDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uniteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 189);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(62, 288);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 24);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(134, 288);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(64, 24);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // dS_Selection_ParametreUnite
            // 
            this.dS_Selection_ParametreUnite.DataSetName = "DS_Selection_ParametreUnite";
            this.dS_Selection_ParametreUnite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSSelectionParametreUniteBindingSource
            // 
            this.dSSelectionParametreUniteBindingSource.DataSource = this.dS_Selection_ParametreUnite;
            this.dSSelectionParametreUniteBindingSource.Position = 0;
            // 
            // uniteBindingSource
            // 
            this.uniteBindingSource.DataMember = "Unite";
            this.uniteBindingSource.DataSource = this.dSSelectionParametreUniteBindingSource;
            // 
            // uniteTableAdapter
            // 
            this.uniteTableAdapter.ClearBeforeFill = true;
            // 
            // codeUniteDataGridViewTextBoxColumn
            // 
            this.codeUniteDataGridViewTextBoxColumn.DataPropertyName = "codeUnite";
            this.codeUniteDataGridViewTextBoxColumn.HeaderText = "codeUnite";
            this.codeUniteDataGridViewTextBoxColumn.Name = "codeUniteDataGridViewTextBoxColumn";
            // 
            // libelleDataGridViewTextBoxColumn
            // 
            this.libelleDataGridViewTextBoxColumn.DataPropertyName = "libelle";
            this.libelleDataGridViewTextBoxColumn.HeaderText = "libelle";
            this.libelleDataGridViewTextBoxColumn.Name = "libelleDataGridViewTextBoxColumn";
            // 
            // FrUniteSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 321);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.cbUnite);
            this.Controls.Add(this.lblUnite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrUniteSupprimer";
            this.Text = "Supprimer une unité";
            this.Load += new System.EventHandler(this.FrUniteSupprimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_ParametreUnite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSSelectionParametreUniteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.ComboBox cbUnite;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.BindingSource dSSelectionParametreUniteBindingSource;
        private DS_Selection_ParametreUnite dS_Selection_ParametreUnite;
        private System.Windows.Forms.BindingSource uniteBindingSource;
        private DS_Selection_ParametreUniteTableAdapters.UniteTableAdapter uniteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeUniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
    }
}