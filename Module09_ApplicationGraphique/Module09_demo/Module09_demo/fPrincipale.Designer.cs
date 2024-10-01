namespace Module09_demo
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
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bAfficher = new System.Windows.Forms.Button();
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuPrincipal.SuspendLayout();
            this.SuspendLayout();
            //
            // tbMessage
            //
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.Location = new System.Drawing.Point(0, 27);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMessage.Size = new System.Drawing.Size(543, 245);
            this.tbMessage.TabIndex = 0;
            this.tbMessage.WordWrap = false;
            //
            // bAfficher
            //
            this.bAfficher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAfficher.Location = new System.Drawing.Point(549, 27);
            this.bAfficher.Name = "bAfficher";
            this.bAfficher.Size = new System.Drawing.Size(75, 23);
            this.bAfficher.TabIndex = 1;
            this.bAfficher.Text = "&Afficher";
            this.bAfficher.UseVisualStyleBackColor = true;
            this.bAfficher.Click += new System.EventHandler(this.bAfficher_Click);
            //
            // msMenuPrincipal
            //
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFichier});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(636, 24);
            this.msMenuPrincipal.TabIndex = 2;
            this.msMenuPrincipal.Text = "menuStrip1";
            //
            // tsmiFichier
            //
            this.tsmiFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrir,
            this.toolStripSeparator1,
            this.tsmiQuitter});
            this.tsmiFichier.Name = "tsmiFichier";
            this.tsmiFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmiFichier.Text = "&Fichier";
            //
            // tsmiOuvrir
            //
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.Size = new System.Drawing.Size(111, 22);
            this.tsmiOuvrir.Text = "&Ouvrir";
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            //
            // toolStripSeparator1
            //
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            //
            // tsmiQuitter
            //
            this.tsmiQuitter.Name = "tsmiQuitter";
            this.tsmiQuitter.Size = new System.Drawing.Size(111, 22);
            this.tsmiQuitter.Text = "Quitter";
            this.tsmiQuitter.Click += new System.EventHandler(this.tsmiQuitter_Click);
            //
            // fPrincipale
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 284);
            this.Controls.Add(this.bAfficher);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.msMenuPrincipal);
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "fPrincipale";
            this.Text = "Ma super application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPrincipale_FormClosing);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bAfficher;
        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiFichier;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuitter;
    }
}
