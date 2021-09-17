namespace POOII_Module10_GestionClients
{
    partial class fSaisieClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNom = new System.Windows.Forms.Label();
            this.lPrenom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNom
            // 
            this.lNom.AutoSize = true;
            this.lNom.Location = new System.Drawing.Point(12, 9);
            this.lNom.Name = "lNom";
            this.lNom.Size = new System.Drawing.Size(40, 15);
            this.lNom.TabIndex = 0;
            this.lNom.Text = "Nom :";
            // 
            // lPrenom
            // 
            this.lPrenom.AutoSize = true;
            this.lPrenom.Location = new System.Drawing.Point(12, 38);
            this.lPrenom.Name = "lPrenom";
            this.lPrenom.Size = new System.Drawing.Size(55, 15);
            this.lPrenom.TabIndex = 1;
            this.lPrenom.Text = "Prénom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(73, 6);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(279, 23);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(73, 35);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(279, 23);
            this.tbPrenom.TabIndex = 2;
            // 
            // bAnnuler
            // 
            this.bAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAnnuler.Location = new System.Drawing.Point(196, 64);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 3;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bEnregistrer.Location = new System.Drawing.Point(277, 64);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.bEnregistrer.TabIndex = 4;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // fSaisieClient
            // 
            this.AcceptButton = this.bEnregistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bAnnuler;
            this.ClientSize = new System.Drawing.Size(364, 99);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bAnnuler);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lPrenom);
            this.Controls.Add(this.lNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fSaisieClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSaisieClient";
            this.Load += new System.EventHandler(this.fSaisieClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNom;
        private System.Windows.Forms.Label lPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button bAnnuler;
        private System.Windows.Forms.Button bEnregistrer;
    }
}