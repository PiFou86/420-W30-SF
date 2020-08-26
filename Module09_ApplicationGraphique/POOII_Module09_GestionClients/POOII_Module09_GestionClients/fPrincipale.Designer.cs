namespace POOII_Module10_GestionClients
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.lbClient = new System.Windows.Forms.ListBox();
            this.bNouveau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recherche clients :";
            // 
            // tbRecherche
            // 
            this.tbRecherche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRecherche.Location = new System.Drawing.Point(123, 6);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(584, 23);
            this.tbRecherche.TabIndex = 1;
            this.tbRecherche.TextChanged += new System.EventHandler(this.tbRecherche_TextChanged);
            // 
            // lbClient
            // 
            this.lbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClient.FormattingEnabled = true;
            this.lbClient.ItemHeight = 15;
            this.lbClient.Location = new System.Drawing.Point(12, 35);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(776, 409);
            this.lbClient.TabIndex = 2;
            this.lbClient.DoubleClick += new System.EventHandler(this.lbClient_DoubleClick);
            // 
            // bNouveau
            // 
            this.bNouveau.Location = new System.Drawing.Point(713, 6);
            this.bNouveau.Name = "bNouveau";
            this.bNouveau.Size = new System.Drawing.Size(75, 23);
            this.bNouveau.TabIndex = 3;
            this.bNouveau.Text = "&Nouveau";
            this.bNouveau.UseVisualStyleBackColor = true;
            this.bNouveau.Click += new System.EventHandler(this.bNouveau_Click);
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNouveau);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.label1);
            this.Name = "fPrincipale";
            this.Text = "Gestion de clients";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.ListBox lbClient;
        private System.Windows.Forms.Button bNouveau;
    }
}

