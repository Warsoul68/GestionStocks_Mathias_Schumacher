namespace Article
{
    partial class Article
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRRef = new System.Windows.Forms.Label();
            this.cbRef = new System.Windows.Forms.ComboBox();
            this.lblRLibelle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblRRef
            // 
            this.lblRRef.AutoSize = true;
            this.lblRRef.BackColor = System.Drawing.Color.Red;
            this.lblRRef.Location = new System.Drawing.Point(22, 31);
            this.lblRRef.Name = "lblRRef";
            this.lblRRef.Size = new System.Drawing.Size(132, 13);
            this.lblRRef.TabIndex = 0;
            this.lblRRef.Text = "Recherche par référence :";
            // 
            // cbRef
            // 
            this.cbRef.FormattingEnabled = true;
            this.cbRef.Location = new System.Drawing.Point(160, 28);
            this.cbRef.Name = "cbRef";
            this.cbRef.Size = new System.Drawing.Size(95, 21);
            this.cbRef.TabIndex = 1;
            // 
            // lblRLibelle
            // 
            this.lblRLibelle.AutoSize = true;
            this.lblRLibelle.BackColor = System.Drawing.Color.Red;
            this.lblRLibelle.Location = new System.Drawing.Point(22, 60);
            this.lblRLibelle.Name = "lblRLibelle";
            this.lblRLibelle.Size = new System.Drawing.Size(113, 13);
            this.lblRLibelle.TabIndex = 2;
            this.lblRLibelle.Text = "Recherche par libellé :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(356, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 97);
            this.panel1.TabIndex = 5;
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRLibelle);
            this.Controls.Add(this.cbRef);
            this.Controls.Add(this.lblRRef);
            this.Controls.Add(this.panel1);
            this.Name = "Article";
            this.Text = "Article";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRRef;
        private System.Windows.Forms.ComboBox cbRef;
        private System.Windows.Forms.Label lblRLibelle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

