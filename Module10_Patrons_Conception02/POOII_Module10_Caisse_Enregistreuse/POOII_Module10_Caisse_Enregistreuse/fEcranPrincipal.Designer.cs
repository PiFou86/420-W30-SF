namespace POOII_Module10_Caisse_Enregistreuse
{
    partial class fEcranPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSimulateurScanner = new System.Windows.Forms.GroupBox();
            this.nudSimulateurScanPrix = new System.Windows.Forms.NumericUpDown();
            this.nudSimulateurScanQuantite = new System.Windows.Forms.NumericUpDown();
            this.lSimulateurScanPrix = new System.Windows.Forms.Label();
            this.lSimulateurScanQuantite = new System.Windows.Forms.Label();
            this.tbSimulationScanDescription = new System.Windows.Forms.TextBox();
            this.lSimulationScanDescription = new System.Windows.Forms.Label();
            this.bSimulerScan = new System.Windows.Forms.Button();
            this.lTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.bPayer = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.gbSimulateurScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulateurScanPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulateurScanQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Articles :";
            // 
            // gbSimulateurScanner
            // 
            this.gbSimulateurScanner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSimulateurScanner.Controls.Add(this.nudSimulateurScanPrix);
            this.gbSimulateurScanner.Controls.Add(this.nudSimulateurScanQuantite);
            this.gbSimulateurScanner.Controls.Add(this.lSimulateurScanPrix);
            this.gbSimulateurScanner.Controls.Add(this.lSimulateurScanQuantite);
            this.gbSimulateurScanner.Controls.Add(this.tbSimulationScanDescription);
            this.gbSimulateurScanner.Controls.Add(this.lSimulationScanDescription);
            this.gbSimulateurScanner.Controls.Add(this.bSimulerScan);
            this.gbSimulateurScanner.Location = new System.Drawing.Point(15, 340);
            this.gbSimulateurScanner.Name = "gbSimulateurScanner";
            this.gbSimulateurScanner.Size = new System.Drawing.Size(773, 75);
            this.gbSimulateurScanner.TabIndex = 2;
            this.gbSimulateurScanner.TabStop = false;
            this.gbSimulateurScanner.Text = "Simulateur scanner";
            // 
            // nudSimulateurScanPrix
            // 
            this.nudSimulateurScanPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSimulateurScanPrix.DecimalPlaces = 2;
            this.nudSimulateurScanPrix.Location = new System.Drawing.Point(692, 17);
            this.nudSimulateurScanPrix.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSimulateurScanPrix.Name = "nudSimulateurScanPrix";
            this.nudSimulateurScanPrix.Size = new System.Drawing.Size(75, 23);
            this.nudSimulateurScanPrix.TabIndex = 3;
            this.nudSimulateurScanPrix.ThousandsSeparator = true;
            // 
            // nudSimulateurScanQuantite
            // 
            this.nudSimulateurScanQuantite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSimulateurScanQuantite.Location = new System.Drawing.Point(578, 16);
            this.nudSimulateurScanQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSimulateurScanQuantite.Name = "nudSimulateurScanQuantite";
            this.nudSimulateurScanQuantite.Size = new System.Drawing.Size(75, 23);
            this.nudSimulateurScanQuantite.TabIndex = 2;
            this.nudSimulateurScanQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lSimulateurScanPrix
            // 
            this.lSimulateurScanPrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSimulateurScanPrix.AutoSize = true;
            this.lSimulateurScanPrix.Location = new System.Drawing.Point(659, 19);
            this.lSimulateurScanPrix.Name = "lSimulateurScanPrix";
            this.lSimulateurScanPrix.Size = new System.Drawing.Size(27, 15);
            this.lSimulateurScanPrix.TabIndex = 1;
            this.lSimulateurScanPrix.Text = "Prix";
            // 
            // lSimulateurScanQuantite
            // 
            this.lSimulateurScanQuantite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSimulateurScanQuantite.AutoSize = true;
            this.lSimulateurScanQuantite.Location = new System.Drawing.Point(519, 19);
            this.lSimulateurScanQuantite.Name = "lSimulateurScanQuantite";
            this.lSimulateurScanQuantite.Size = new System.Drawing.Size(53, 15);
            this.lSimulateurScanQuantite.TabIndex = 1;
            this.lSimulateurScanQuantite.Text = "Quantité";
            // 
            // tbSimulationScanDescription
            // 
            this.tbSimulationScanDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSimulationScanDescription.Location = new System.Drawing.Point(79, 16);
            this.tbSimulationScanDescription.Name = "tbSimulationScanDescription";
            this.tbSimulationScanDescription.Size = new System.Drawing.Size(420, 23);
            this.tbSimulationScanDescription.TabIndex = 1;
            // 
            // lSimulationScanDescription
            // 
            this.lSimulationScanDescription.AutoSize = true;
            this.lSimulationScanDescription.Location = new System.Drawing.Point(6, 19);
            this.lSimulationScanDescription.Name = "lSimulationScanDescription";
            this.lSimulationScanDescription.Size = new System.Drawing.Size(67, 15);
            this.lSimulationScanDescription.TabIndex = 1;
            this.lSimulationScanDescription.Text = "Description";
            // 
            // bSimulerScan
            // 
            this.bSimulerScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSimulerScan.Location = new System.Drawing.Point(692, 45);
            this.bSimulerScan.Name = "bSimulerScan";
            this.bSimulerScan.Size = new System.Drawing.Size(75, 23);
            this.bSimulerScan.TabIndex = 4;
            this.bSimulerScan.Text = "Simuler scan";
            this.bSimulerScan.UseVisualStyleBackColor = true;
            this.bSimulerScan.Click += new System.EventHandler(this.bSimulerScan_Click);
            // 
            // lTotal
            // 
            this.lTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(623, 288);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(32, 15);
            this.lTotal.TabIndex = 3;
            this.lTotal.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(661, 285);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(127, 23);
            this.tbTotal.TabIndex = 4;
            // 
            // bPayer
            // 
            this.bPayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPayer.Location = new System.Drawing.Point(713, 314);
            this.bPayer.Name = "bPayer";
            this.bPayer.Size = new System.Drawing.Size(75, 23);
            this.bPayer.TabIndex = 5;
            this.bPayer.Text = "Payer";
            this.bPayer.UseVisualStyleBackColor = true;
            this.bPayer.Click += new System.EventHandler(this.bPayer_Click);
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // PrixUnitaire
            // 
            this.PrixUnitaire.HeaderText = "PrixUnitaire";
            this.PrixUnitaire.Name = "PrixUnitaire";
            this.PrixUnitaire.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // dgvFacture
            // 
            this.dgvFacture.AllowUserToAddRows = false;
            this.dgvFacture.AllowUserToDeleteRows = false;
            this.dgvFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Quantite,
            this.PrixUnitaire,
            this.Total});
            this.dgvFacture.Location = new System.Drawing.Point(12, 20);
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ReadOnly = true;
            this.dgvFacture.Size = new System.Drawing.Size(776, 259);
            this.dgvFacture.TabIndex = 0;
            this.dgvFacture.Text = "dataGridView1";
            // 
            // fEcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.bPayer);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.gbSimulateurScanner);
            this.Controls.Add(this.label1);
            this.Name = "fEcranPrincipal";
            this.Text = "Écran principal";
            this.Load += new System.EventHandler(this.fEcranPrincipal_Load);
            this.gbSimulateurScanner.ResumeLayout(false);
            this.gbSimulateurScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulateurScanPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSimulateurScanQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSimulateurScanner;
        private System.Windows.Forms.Label lSimulateurScanQuantite;
        private System.Windows.Forms.TextBox tbSimulationScanDescription;
        private System.Windows.Forms.Label lSimulationScanDescription;
        private System.Windows.Forms.Button bSimulerScan;
        private System.Windows.Forms.Label lSimulateurScanPrix;
        private System.Windows.Forms.NumericUpDown nudSimulateurScanQuantite;
        private System.Windows.Forms.NumericUpDown nudSimulateurScanPrix;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button bPayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView dgvFacture;
    }
}

