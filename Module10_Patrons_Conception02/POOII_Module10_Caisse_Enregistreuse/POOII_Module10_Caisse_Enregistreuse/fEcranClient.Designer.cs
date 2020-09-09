namespace POOII_Module10_Caisse_Enregistreuse
{
    partial class fEcranClient
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
            this.tbAffichage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAffichage
            // 
            this.tbAffichage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAffichage.Location = new System.Drawing.Point(12, 12);
            this.tbAffichage.Name = "tbAffichage";
            this.tbAffichage.Size = new System.Drawing.Size(786, 23);
            this.tbAffichage.TabIndex = 0;
            // 
            // fEcranClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 50);
            this.Controls.Add(this.tbAffichage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fEcranClient";
            this.Text = "Écran client";
            this.Load += new System.EventHandler(this.fEcranClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAffichage;
    }
}