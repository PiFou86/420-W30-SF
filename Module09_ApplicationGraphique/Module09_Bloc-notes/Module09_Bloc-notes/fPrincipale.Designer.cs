namespace TestWinform
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
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColler = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier,
            this.tsmiEdition});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(519, 24);
            this.msMenuPrincipal.TabIndex = 3;
            this.msMenuPrincipal.Text = "&Fichier";
            // 
            // tsmiFichier
            // 
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNouveau,
            this.tsmiOuvrir,
            this.tsmiEnregistrerSous,
            this.tsmiEnregistrer,
            this.toolStripSeparator1,
            this.tsmiQuitter});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmiFichier.Text = "&Fichier";
            // 
            // tsmiNouveau
            // 
            this.tsmiNouveau.Name = "tsmiNouveau";
            this.tsmiNouveau.ShortcutKeyDisplayString = "Ctrl-N";
            this.tsmiNouveau.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNouveau.Size = new System.Drawing.Size(234, 22);
            this.tsmiNouveau.Text = "Nouveau";
            this.tsmiNouveau.Click += new System.EventHandler(this.tsmiNouveau_Click);
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.ShortcutKeyDisplayString = "Ctrl+O";
            this.tsmiOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOuvrir.Size = new System.Drawing.Size(234, 22);
            this.tsmiOuvrir.Text = "&Ouvrir";
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            // 
            // tsmiEnregistrerSous
            // 
            this.tsmiEnregistrerSous.Name = "tsmiEnregistrerSous";
            this.tsmiEnregistrerSous.ShortcutKeyDisplayString = "Ctrl+Maj+S";
            this.tsmiEnregistrerSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrerSous.Size = new System.Drawing.Size(234, 22);
            this.tsmiEnregistrerSous.Text = "Enregistrer sous...";
            this.tsmiEnregistrerSous.Click += new System.EventHandler(this.tsmiEnregistrerSous_Click);
            // 
            // tsmiEnregistrer
            // 
            this.tsmiEnregistrer.Name = "tsmiEnregistrer";
            this.tsmiEnregistrer.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsmiEnregistrer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiEnregistrer.Size = new System.Drawing.Size(234, 22);
            this.tsmiEnregistrer.Text = "&Enregistrer";
            this.tsmiEnregistrer.Click += new System.EventHandler(this.tsmiEnregistrer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // tsmiQuitter
            // 
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.ShortcutKeyDisplayString = "Alt+F4";
            this.tsmiQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiQuitter.Size = new System.Drawing.Size(234, 22);
            this.tsmiQuitter.Text = "&Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            // 
            // tsmiEdition
            // 
            this.tsmiEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopier,
            this.tsmiCouper,
            this.tsmiColler});
            this.tsmiEdition.Name = "tsmiEdition";
            this.tsmiEdition.Size = new System.Drawing.Size(56, 20);
            this.tsmiEdition.Text = "&Édition";
            // 
            // tsmiCopier
            // 
            this.tsmiCopier.Name = "tsmiCopier";
            this.tsmiCopier.ShortcutKeyDisplayString = "Ctrl+C";
            this.tsmiCopier.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopier.Size = new System.Drawing.Size(151, 22);
            this.tsmiCopier.Text = "Copier";
            this.tsmiCopier.Click += new System.EventHandler(this.tsmiCopier_Click);
            // 
            // tsmiCouper
            // 
            this.tsmiCouper.Name = "tsmiCouper";
            this.tsmiCouper.ShortcutKeyDisplayString = "Ctrl-X";
            this.tsmiCouper.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCouper.Size = new System.Drawing.Size(151, 22);
            this.tsmiCouper.Text = "Couper";
            this.tsmiCouper.Click += new System.EventHandler(this.tsmiCouper_Click);
            // 
            // tsmiColler
            // 
            this.tsmiColler.Name = "tsmiColler";
            this.tsmiColler.ShortcutKeyDisplayString = "Ctrl+V";
            this.tsmiColler.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiColler.Size = new System.Drawing.Size(151, 22);
            this.tsmiColler.Text = "Coller";
            this.tsmiColler.Click += new System.EventHandler(this.tsmiColler_Click);
            // 
            // tbTexte
            // 
            this.tbTexte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTexte.Location = new System.Drawing.Point(0, 27);
            this.tbTexte.Multiline = true;
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbTexte.Size = new System.Drawing.Size(519, 252);
            this.tbTexte.TabIndex = 4;
            this.tbTexte.TextChanged += new System.EventHandler(this.tbTexte_TextChanged);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 279);
            this.Controls.Add(this.tbTexte);
            this.Controls.Add(this.msMenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPrincipale";
            this.Text = "Super Bloc-notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPrincipale_FormClosing);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnregistrer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitter;
        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.ToolStripMenuItem tsmiNouveau;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdition;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopier;
        private System.Windows.Forms.ToolStripMenuItem tsmiCouper;
        private System.Windows.Forms.ToolStripMenuItem tsmiColler;
    }
}

