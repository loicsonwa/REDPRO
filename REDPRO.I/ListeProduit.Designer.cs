namespace REDPRO.I
{
    partial class ListeProduit
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gunaPanel1.Location = new System.Drawing.Point(607, 137);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(316, 215);
            this.gunaPanel1.TabIndex = 0;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(703, 260);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(133, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "gunaLabel2";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(685, 169);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(133, 25);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "gunaLabel1";
            // 
            // ultraPanel1
            // 
            appearance1.AlphaLevel = ((short)(65));
            appearance1.BackColor = System.Drawing.Color.Black;
            appearance1.BackColorAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            this.ultraPanel1.Appearance = appearance1;
            this.ultraPanel1.Location = new System.Drawing.Point(3, 3);
            this.ultraPanel1.Name = "ultraPanel1";
            this.ultraPanel1.Size = new System.Drawing.Size(1072, 479);
            this.ultraPanel1.TabIndex = 4;
            // 
            // ListeProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.ultraPanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "ListeProduit";
            this.Size = new System.Drawing.Size(1075, 485);
            this.ultraPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
    }
}
