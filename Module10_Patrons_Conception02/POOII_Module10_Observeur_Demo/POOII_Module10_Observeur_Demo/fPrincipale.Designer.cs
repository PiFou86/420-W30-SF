namespace POOII_Module10_Observeur_Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipale));
            this.tbTexte = new System.Windows.Forms.TextBox();
            this.lEcho = new System.Windows.Forms.Label();
            this.lExplication = new System.Windows.Forms.Label();
            this.lCouleur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTexte
            // 
            this.tbTexte.Location = new System.Drawing.Point(12, 27);
            this.tbTexte.Name = "tbTexte";
            this.tbTexte.Size = new System.Drawing.Size(100, 23);
            this.tbTexte.TabIndex = 0;
            this.tbTexte.TextChanged += new System.EventHandler(this.tbTexte_TextChanged);
            // 
            // lEcho
            // 
            this.lEcho.AutoSize = true;
            this.lEcho.Location = new System.Drawing.Point(142, 30);
            this.lEcho.Name = "lEcho";
            this.lEcho.Size = new System.Drawing.Size(0, 15);
            this.lEcho.TabIndex = 1;
            // 
            // lExplication
            // 
            this.lExplication.AutoSize = true;
            this.lExplication.Location = new System.Drawing.Point(12, 9);
            this.lExplication.Name = "lExplication";
            this.lExplication.Size = new System.Drawing.Size(61, 15);
            this.lExplication.TabIndex = 2;
            this.lExplication.Text = "Écrivez Ok";
            // 
            // lCouleur
            // 
            this.lCouleur.AutoSize = true;
            this.lCouleur.BackColor = System.Drawing.Color.Red;
            this.lCouleur.Location = new System.Drawing.Point(51, 53);
            this.lCouleur.Name = "lCouleur";
            this.lCouleur.Size = new System.Drawing.Size(22, 15);
            this.lCouleur.TabIndex = 3;
            this.lCouleur.Text = "     ";
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 77);
            this.Controls.Add(this.lCouleur);
            this.Controls.Add(this.lExplication);
            this.Controls.Add(this.lEcho);
            this.Controls.Add(this.tbTexte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPrincipale";
            this.Text = "Patron observateur";
            this.Load += new System.EventHandler(this.fPrincipale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexte;
        private System.Windows.Forms.Label lEcho;
        private System.Windows.Forms.Label lExplication;
        private System.Windows.Forms.Label lCouleur;
    }
}

