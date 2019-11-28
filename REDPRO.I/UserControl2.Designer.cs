namespace REDPRO.I
{
    partial class UserControl2
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
            this.UserControl2_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.UserControl2_Fill_Panel.ClientArea.SuspendLayout();
            this.UserControl2_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserControl2_Fill_Panel
            // 
            // 
            // UserControl2_Fill_Panel.ClientArea
            // 
            this.UserControl2_Fill_Panel.ClientArea.Controls.Add(this.imageSlider1);
            this.UserControl2_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserControl2_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl2_Fill_Panel.Location = new System.Drawing.Point(0, 0);
            this.UserControl2_Fill_Panel.Name = "UserControl2_Fill_Panel";
            this.UserControl2_Fill_Panel.Size = new System.Drawing.Size(1053, 505);
            this.UserControl2_Fill_Panel.TabIndex = 0;
            // 
            // imageSlider1
            // 
            this.imageSlider1.Location = new System.Drawing.Point(357, 126);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(209, 188);
            this.imageSlider1.TabIndex = 0;
            this.imageSlider1.Text = "imageSlider1";
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserControl2_Fill_Panel);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1053, 505);
            this.UserControl2_Fill_Panel.ClientArea.ResumeLayout(false);
            this.UserControl2_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.Misc.UltraPanel UserControl2_Fill_Panel;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    }
}
