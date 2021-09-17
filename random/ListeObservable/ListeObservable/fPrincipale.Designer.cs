
namespace WindowsFormsApp1
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
            this.lbElements = new System.Windows.Forms.ListBox();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bVider = new System.Windows.Forms.Button();
            this.tbAAjouter = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbElements
            // 
            this.lbElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbElements.FormattingEnabled = true;
            this.lbElements.ItemHeight = 15;
            this.lbElements.Location = new System.Drawing.Point(12, 41);
            this.lbElements.Name = "lbElements";
            this.lbElements.Size = new System.Drawing.Size(451, 184);
            this.lbElements.TabIndex = 0;
            // 
            // bAjouter
            // 
            this.bAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAjouter.Location = new System.Drawing.Point(307, 12);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 23);
            this.bAjouter.TabIndex = 1;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bVider
            // 
            this.bVider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bVider.Location = new System.Drawing.Point(388, 12);
            this.bVider.Name = "bVider";
            this.bVider.Size = new System.Drawing.Size(75, 23);
            this.bVider.TabIndex = 2;
            this.bVider.Text = "Vider";
            this.bVider.UseVisualStyleBackColor = true;
            this.bVider.Click += new System.EventHandler(this.bVider_Click);
            // 
            // tbAAjouter
            // 
            this.tbAAjouter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAAjouter.Location = new System.Drawing.Point(12, 12);
            this.tbAAjouter.Name = "tbAAjouter";
            this.tbAAjouter.Size = new System.Drawing.Size(289, 23);
            this.tbAAjouter.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 237);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(475, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "tsslNombreElements";
            // 
            // fPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 259);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbAAjouter);
            this.Controls.Add(this.bVider);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.lbElements);
            this.Name = "fPrincipale";
            this.Text = "Liste observable";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbElements;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bVider;
        private System.Windows.Forms.TextBox tbAAjouter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

