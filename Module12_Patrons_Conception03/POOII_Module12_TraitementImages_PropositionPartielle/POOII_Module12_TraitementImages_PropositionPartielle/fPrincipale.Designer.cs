namespace POOII_Module11_Paint
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipale));
            this.ssStatut = new System.Windows.Forms.StatusStrip();
            this.sslPositionSouris = new System.Windows.Forms.ToolStripStatusLabel();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.scSuiteTraitements = new System.Windows.Forms.SplitContainer();
            this.lbSuiteTraitementsAAppliquer = new System.Windows.Forms.ListBox();
            this.pControlSuiteTraitements = new System.Windows.Forms.Panel();
            this.bSuiteTraitementsDeplacerHaut = new System.Windows.Forms.Button();
            this.bSuiteTraitementsDeplacerBas = new System.Windows.Forms.Button();
            this.bSupprimerTraitement = new System.Windows.Forms.Button();
            this.bAjouterTraitement = new System.Windows.Forms.Button();
            this.cbTraitementAAjouter = new System.Windows.Forms.ComboBox();
            this.pAppliquerSuiteTraitements = new System.Windows.Forms.Panel();
            this.bAppliquerSuiteTraitements = new System.Windows.Forms.Button();
            this.pgProprieteTraitementSelectionne = new System.Windows.Forms.PropertyGrid();
            this.ssStatut.SuspendLayout();
            this.pCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.msPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraitements)).BeginInit();
            this.scSuiteTraitements.Panel1.SuspendLayout();
            this.scSuiteTraitements.Panel2.SuspendLayout();
            this.scSuiteTraitements.SuspendLayout();
            this.pControlSuiteTraitements.SuspendLayout();
            this.pAppliquerSuiteTraitements.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssStatut
            // 
            this.ssStatut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslPositionSouris});
            resources.ApplyResources(this.ssStatut, "ssStatut");
            this.ssStatut.Name = "ssStatut";
            // 
            // sslPositionSouris
            // 
            this.sslPositionSouris.Name = "sslPositionSouris";
            resources.ApplyResources(this.sslPositionSouris, "sslPositionSouris");
            // 
            // pCanvas
            // 
            resources.ApplyResources(this.pCanvas, "pCanvas");
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Controls.Add(this.pbImage);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pCanvas_MouseMove);
            // 
            // pbImage
            // 
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier});
            resources.ApplyResources(this.msPrincipal, "msPrincipal");
            this.msPrincipal.Name = "msPrincipal";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrir});
            this.tsmiFichier.Name = "tsmiFichier";
            resources.ApplyResources(this.tsmiFichier, "tsmiFichier");
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            resources.ApplyResources(this.tsmiOuvrir, "tsmiOuvrir");
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            // 
            // scPrincipal
            // 
            this.scPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.scPrincipal, "scPrincipal");
            this.scPrincipal.Name = "scPrincipal";
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.Controls.Add(this.scSuiteTraitements);
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.pCanvas);
            // 
            // scSuiteTraitements
            // 
            this.scSuiteTraitements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.scSuiteTraitements, "scSuiteTraitements");
            this.scSuiteTraitements.Name = "scSuiteTraitements";
            // 
            // scSuiteTraitements.Panel1
            // 
            this.scSuiteTraitements.Panel1.Controls.Add(this.lbSuiteTraitementsAAppliquer);
            this.scSuiteTraitements.Panel1.Controls.Add(this.pControlSuiteTraitements);
            this.scSuiteTraitements.Panel1.Controls.Add(this.pAppliquerSuiteTraitements);
            // 
            // scSuiteTraitements.Panel2
            // 
            this.scSuiteTraitements.Panel2.Controls.Add(this.pgProprieteTraitementSelectionne);
            // 
            // lbSuiteTraitementsAAppliquer
            // 
            resources.ApplyResources(this.lbSuiteTraitementsAAppliquer, "lbSuiteTraitementsAAppliquer");
            this.lbSuiteTraitementsAAppliquer.FormattingEnabled = true;
            this.lbSuiteTraitementsAAppliquer.Name = "lbSuiteTraitementsAAppliquer";
            this.lbSuiteTraitementsAAppliquer.SelectedIndexChanged += new System.EventHandler(this.lbSuiteTraitementsAAppliquer_SelectedIndexChanged);
            // 
            // pControlSuiteTraitements
            // 
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerHaut);
            this.pControlSuiteTraitements.Controls.Add(this.bSuiteTraitementsDeplacerBas);
            this.pControlSuiteTraitements.Controls.Add(this.bSupprimerTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.bAjouterTraitement);
            this.pControlSuiteTraitements.Controls.Add(this.cbTraitementAAjouter);
            resources.ApplyResources(this.pControlSuiteTraitements, "pControlSuiteTraitements");
            this.pControlSuiteTraitements.Name = "pControlSuiteTraitements";
            // 
            // bSuiteTraitementsDeplacerHaut
            // 
            resources.ApplyResources(this.bSuiteTraitementsDeplacerHaut, "bSuiteTraitementsDeplacerHaut");
            this.bSuiteTraitementsDeplacerHaut.Name = "bSuiteTraitementsDeplacerHaut";
            this.bSuiteTraitementsDeplacerHaut.UseVisualStyleBackColor = true;
            this.bSuiteTraitementsDeplacerHaut.Click += new System.EventHandler(this.bSuiteTraitementsDeplacerHaut_Click);
            // 
            // bSuiteTraitementsDeplacerBas
            // 
            resources.ApplyResources(this.bSuiteTraitementsDeplacerBas, "bSuiteTraitementsDeplacerBas");
            this.bSuiteTraitementsDeplacerBas.Name = "bSuiteTraitementsDeplacerBas";
            this.bSuiteTraitementsDeplacerBas.UseVisualStyleBackColor = true;
            this.bSuiteTraitementsDeplacerBas.Click += new System.EventHandler(this.bSuiteTraitementsDeplacerBas_Click);
            // 
            // bSupprimerTraitement
            // 
            resources.ApplyResources(this.bSupprimerTraitement, "bSupprimerTraitement");
            this.bSupprimerTraitement.Name = "bSupprimerTraitement";
            this.bSupprimerTraitement.UseVisualStyleBackColor = true;
            this.bSupprimerTraitement.Click += new System.EventHandler(this.bSupprimerTraitement_Click);
            // 
            // bAjouterTraitement
            // 
            resources.ApplyResources(this.bAjouterTraitement, "bAjouterTraitement");
            this.bAjouterTraitement.Name = "bAjouterTraitement";
            this.bAjouterTraitement.UseVisualStyleBackColor = true;
            this.bAjouterTraitement.Click += new System.EventHandler(this.bAjouterTraitement_Click);
            // 
            // cbTraitementAAjouter
            // 
            resources.ApplyResources(this.cbTraitementAAjouter, "cbTraitementAAjouter");
            this.cbTraitementAAjouter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTraitementAAjouter.FormattingEnabled = true;
            this.cbTraitementAAjouter.Name = "cbTraitementAAjouter";
            // 
            // pAppliquerSuiteTraitements
            // 
            this.pAppliquerSuiteTraitements.Controls.Add(this.bAppliquerSuiteTraitements);
            resources.ApplyResources(this.pAppliquerSuiteTraitements, "pAppliquerSuiteTraitements");
            this.pAppliquerSuiteTraitements.Name = "pAppliquerSuiteTraitements";
            // 
            // bAppliquerSuiteTraitements
            // 
            resources.ApplyResources(this.bAppliquerSuiteTraitements, "bAppliquerSuiteTraitements");
            this.bAppliquerSuiteTraitements.Name = "bAppliquerSuiteTraitements";
            this.bAppliquerSuiteTraitements.UseVisualStyleBackColor = true;
            this.bAppliquerSuiteTraitements.Click += new System.EventHandler(this.bAppliquerSuiteTraitements_Click);
            // 
            // pgProprieteTraitementSelectionne
            // 
            resources.ApplyResources(this.pgProprieteTraitementSelectionne, "pgProprieteTraitementSelectionne");
            this.pgProprieteTraitementSelectionne.Name = "pgProprieteTraitementSelectionne";
            // 
            // fPrincipale
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scPrincipal);
            this.Controls.Add(this.ssStatut);
            this.Controls.Add(this.msPrincipal);
            this.Name = "fPrincipale";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            this.ssStatut.ResumeLayout(false);
            this.ssStatut.PerformLayout();
            this.pCanvas.ResumeLayout(false);
            this.pCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.scSuiteTraitements.Panel1.ResumeLayout(false);
            this.scSuiteTraitements.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSuiteTraitements)).EndInit();
            this.scSuiteTraitements.ResumeLayout(false);
            this.pControlSuiteTraitements.ResumeLayout(false);
            this.pAppliquerSuiteTraitements.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssStatut;
        private System.Windows.Forms.ToolStripStatusLabel sslPositionSouris;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.SplitContainer scSuiteTraitements;
        private System.Windows.Forms.PropertyGrid pgProprieteTraitementSelectionne;
        private System.Windows.Forms.Panel pControlSuiteTraitements;
        private System.Windows.Forms.Panel pAppliquerSuiteTraitements;
        private System.Windows.Forms.Button bAjouterTraitement;
        private System.Windows.Forms.Button bSupprimerTraitement;
        private System.Windows.Forms.ComboBox cbTraitementAAjouter;
        private System.Windows.Forms.ListBox lbSuiteTraitementsAAppliquer;
        private System.Windows.Forms.Button bAppliquerSuiteTraitements;
        private System.Windows.Forms.Button bSuiteTraitementsDeplacerBas;
        private System.Windows.Forms.Button bSuiteTraitementsDeplacerHaut;
    }
}

