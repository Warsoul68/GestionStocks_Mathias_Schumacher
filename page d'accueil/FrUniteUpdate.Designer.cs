﻿namespace page_d_accueil
{
    partial class FrUniteUpdate
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
            this.lblCodeUnite = new System.Windows.Forms.Label();
            this.cbCodeUnite = new System.Windows.Forms.ComboBox();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dS_Selection_Parametre_Unite = new page_d_accueil.DS_Selection_Parametre_Unite();
            this.uniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uniteTableAdapter = new page_d_accueil.DS_Selection_Parametre_UniteTableAdapters.UniteTableAdapter();
            this.codeUniteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Parametre_Unite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodeUnite
            // 
            this.lblCodeUnite.AutoSize = true;
            this.lblCodeUnite.Location = new System.Drawing.Point(9, 17);
            this.lblCodeUnite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeUnite.Name = "lblCodeUnite";
            this.lblCodeUnite.Size = new System.Drawing.Size(64, 13);
            this.lblCodeUnite.TabIndex = 0;
            this.lblCodeUnite.Text = "Code unité :";
            // 
            // cbCodeUnite
            // 
            this.cbCodeUnite.FormattingEnabled = true;
            this.cbCodeUnite.Location = new System.Drawing.Point(71, 15);
            this.cbCodeUnite.Margin = new System.Windows.Forms.Padding(2);
            this.cbCodeUnite.Name = "cbCodeUnite";
            this.cbCodeUnite.Size = new System.Drawing.Size(62, 21);
            this.cbCodeUnite.TabIndex = 1;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(9, 46);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 2;
            this.lblLibelle.Text = "Libellé :";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(71, 46);
            this.txtLibelle.Margin = new System.Windows.Forms.Padding(2);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(84, 20);
            this.txtLibelle.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeUniteDataGridViewTextBoxColumn,
            this.libelleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uniteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 156);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(50, 248);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(56, 28);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 248);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 28);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Mettre a jour";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dS_Selection_Parametre_Unite
            // 
            this.dS_Selection_Parametre_Unite.DataSetName = "DS_Selection_Parametre_Unite";
            this.dS_Selection_Parametre_Unite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniteBindingSource
            // 
            this.uniteBindingSource.DataMember = "Unite";
            this.uniteBindingSource.DataSource = this.dS_Selection_Parametre_Unite;
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
            // FrUniteUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 286);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.cbCodeUnite);
            this.Controls.Add(this.lblCodeUnite);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrUniteUpdate";
            this.Text = "Mettre a jour une unité";
            this.Load += new System.EventHandler(this.FrUniteUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Selection_Parametre_Unite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodeUnite;
        private System.Windows.Forms.ComboBox cbCodeUnite;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnUpdate;
        private DS_Selection_Parametre_Unite dS_Selection_Parametre_Unite;
        private System.Windows.Forms.BindingSource uniteBindingSource;
        private DS_Selection_Parametre_UniteTableAdapters.UniteTableAdapter uniteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeUniteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleDataGridViewTextBoxColumn;
    }
}