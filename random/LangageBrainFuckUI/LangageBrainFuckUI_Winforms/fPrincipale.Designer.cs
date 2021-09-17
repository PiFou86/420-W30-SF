
namespace LangageBrainFuckUI_Winforms
{
    partial class fPrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.pControles = new System.Windows.Forms.Panel();
            this.bArreter = new System.Windows.Forms.Button();
            this.bAvancer = new System.Windows.Forms.Button();
            this.bDeboguer = new System.Windows.Forms.Button();
            this.bExecuter = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scPrincipal = new System.Windows.Forms.SplitContainer();
            this.rtbCode = new System.Windows.Forms.RichTextBox();
            this.rtbMemoire = new System.Windows.Forms.RichTextBox();
            this.tbOut = new System.Windows.Forms.TextBox();
            this.msPrincipal.SuspendLayout();
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).BeginInit();
            this.scPrincipal.Panel1.SuspendLayout();
            this.scPrincipal.Panel2.SuspendLayout();
            this.scPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFichier});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msPrincipal.TabIndex = 0;
            // 
            // tsmFichier
            // 
            this.tsmFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOuvrir});
            this.tsmFichier.Name = "tsmFichier";
            this.tsmFichier.Size = new System.Drawing.Size(54, 20);
            this.tsmFichier.Text = "Fichier";
            // 
            // tsmiOuvrir
            // 
            this.tsmiOuvrir.Name = "tsmiOuvrir";
            this.tsmiOuvrir.Size = new System.Drawing.Size(107, 22);
            this.tsmiOuvrir.Text = "Ouvrir";
            this.tsmiOuvrir.Click += new System.EventHandler(this.tsmiOuvrir_Click);
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.bArreter);
            this.pControles.Controls.Add(this.bAvancer);
            this.pControles.Controls.Add(this.bDeboguer);
            this.pControles.Controls.Add(this.bExecuter);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControles.Location = new System.Drawing.Point(0, 24);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(800, 48);
            this.pControles.TabIndex = 2;
            // 
            // bArreter
            // 
            this.bArreter.Enabled = false;
            this.bArreter.Location = new System.Drawing.Point(255, 12);
            this.bArreter.Name = "bArreter";
            this.bArreter.Size = new System.Drawing.Size(75, 23);
            this.bArreter.TabIndex = 3;
            this.bArreter.Text = "Arrêter";
            this.bArreter.UseVisualStyleBackColor = true;
            this.bArreter.Click += new System.EventHandler(this.bArreter_Click);
            // 
            // bAvancer
            // 
            this.bAvancer.Enabled = false;
            this.bAvancer.Location = new System.Drawing.Point(174, 12);
            this.bAvancer.Name = "bAvancer";
            this.bAvancer.Size = new System.Drawing.Size(75, 23);
            this.bAvancer.TabIndex = 2;
            this.bAvancer.Text = "Avancer";
            this.bAvancer.UseVisualStyleBackColor = true;
            this.bAvancer.Click += new System.EventHandler(this.bAvancer_Click);
            // 
            // bDeboguer
            // 
            this.bDeboguer.Location = new System.Drawing.Point(93, 12);
            this.bDeboguer.Name = "bDeboguer";
            this.bDeboguer.Size = new System.Drawing.Size(75, 23);
            this.bDeboguer.TabIndex = 1;
            this.bDeboguer.Text = "Déboguer";
            this.bDeboguer.UseVisualStyleBackColor = true;
            this.bDeboguer.Click += new System.EventHandler(this.bDeboguer_Click);
            // 
            // bExecuter
            // 
            this.bExecuter.Location = new System.Drawing.Point(12, 12);
            this.bExecuter.Name = "bExecuter";
            this.bExecuter.Size = new System.Drawing.Size(75, 23);
            this.bExecuter.TabIndex = 0;
            this.bExecuter.Text = "Exécuter";
            this.bExecuter.UseVisualStyleBackColor = true;
            this.bExecuter.Click += new System.EventHandler(this.bExecuter_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 72);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.scPrincipal);
            this.splitContainer1.Panel1MinSize = 500;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbOut);
            this.splitContainer1.Size = new System.Drawing.Size(800, 378);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 3;
            // 
            // scPrincipal
            // 
            this.scPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPrincipal.Location = new System.Drawing.Point(0, 0);
            this.scPrincipal.Name = "scPrincipal";
            this.scPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scPrincipal.Panel1
            // 
            this.scPrincipal.Panel1.Controls.Add(this.rtbCode);
            // 
            // scPrincipal.Panel2
            // 
            this.scPrincipal.Panel2.Controls.Add(this.rtbMemoire);
            this.scPrincipal.Size = new System.Drawing.Size(500, 378);
            this.scPrincipal.SplitterDistance = 252;
            this.scPrincipal.TabIndex = 4;
            // 
            // rtbCode
            // 
            this.rtbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbCode.Location = new System.Drawing.Point(0, 0);
            this.rtbCode.Name = "rtbCode";
            this.rtbCode.Size = new System.Drawing.Size(500, 252);
            this.rtbCode.TabIndex = 0;
            this.rtbCode.Text = "";
            // 
            // rtbMemoire
            // 
            this.rtbMemoire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMemoire.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbMemoire.Location = new System.Drawing.Point(0, 0);
            this.rtbMemoire.Name = "rtbMemoire";
            this.rtbMemoire.Size = new System.Drawing.Size(500, 122);
            this.rtbMemoire.TabIndex = 0;
            this.rtbMemoire.Text = "";
            // 
            // tbOut
            // 
            this.tbOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOut.Location = new System.Drawing.Point(0, 0);
            this.tbOut.Multiline = true;
            this.tbOut.Name = "tbOut";
            this.tbOut.Size = new System.Drawing.Size(296, 378);
            this.tbOut.TabIndex = 0;
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pControles);
            this.Controls.Add(this.msPrincipal);
            this.Name = "fPrincipale";
            this.Text = "BrainFuck IDE";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.pControles.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scPrincipal.Panel1.ResumeLayout(false);
            this.scPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scPrincipal)).EndInit();
            this.scPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmFichier;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Button bDeboguer;
        private System.Windows.Forms.Button bExecuter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer scPrincipal;
        private System.Windows.Forms.RichTextBox rtbCode;
        private System.Windows.Forms.RichTextBox rtbMemoire;
        private System.Windows.Forms.TextBox tbOut;
        private System.Windows.Forms.Button bAvancer;
        private System.Windows.Forms.ToolStripMenuItem tsmiOuvrir;
        private System.Windows.Forms.Button bArreter;
    }
}

