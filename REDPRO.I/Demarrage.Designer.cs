namespace REDPRO.I
{
    partial class Demarrage
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation1 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demarrage));
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation2 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            this.Transition1 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.connexion1 = new REDPRO.I.Connexion();
            this.inscription1 = new REDPRO.I.Inscription();
            this.Transition2 = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.SuspendLayout();
            // 
            // Transition1
            // 
            this.Transition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Transition1.DefaultAnimation = animation1;
            // 
            // connexion1
            // 
            this.connexion1.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.connexion1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition2.SetDecoration(this.connexion1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.connexion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connexion1.Location = new System.Drawing.Point(0, 0);
            this.connexion1.Name = "connexion1";
            this.connexion1.Size = new System.Drawing.Size(585, 580);
            this.connexion1.TabIndex = 1;
            // 
            // inscription1
            // 
            this.inscription1.BackColor = System.Drawing.Color.White;
            this.Transition1.SetDecoration(this.inscription1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition2.SetDecoration(this.inscription1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.inscription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inscription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inscription1.Location = new System.Drawing.Point(0, 0);
            this.inscription1.Name = "inscription1";
            this.inscription1.Size = new System.Drawing.Size(585, 580);
            this.inscription1.TabIndex = 0;
            // 
            // Transition2
            // 
            this.Transition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Custom;
            this.Transition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Transition2.DefaultAnimation = animation2;
            // 
            // Demarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 580);
            this.Controls.Add(this.connexion1);
            this.Controls.Add(this.inscription1);
            this.Transition2.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Transition1.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Demarrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Inscription inscription1;
        private Bunifu.UI.WinForms.BunifuTransition Transition1;
        private Connexion connexion1;
        private Bunifu.UI.WinForms.BunifuTransition Transition2;
    }
}

