namespace POO_Module11_Dessin_Lignes
{
    partial class fDessinLignes
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
            this.pControles = new System.Windows.Forms.Panel();
            this.bDessiner = new System.Windows.Forms.Button();
            this.lPas = new System.Windows.Forms.Label();
            this.lNombreLignes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lAngle = new System.Windows.Forms.Label();
            this.nudPas = new System.Windows.Forms.NumericUpDown();
            this.nudNombreLignes = new System.Windows.Forms.NumericUpDown();
            this.nudLongueurDepart = new System.Windows.Forms.NumericUpDown();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.bDessiner);
            this.pControles.Controls.Add(this.lPas);
            this.pControles.Controls.Add(this.lNombreLignes);
            this.pControles.Controls.Add(this.label1);
            this.pControles.Controls.Add(this.lAngle);
            this.pControles.Controls.Add(this.nudPas);
            this.pControles.Controls.Add(this.nudNombreLignes);
            this.pControles.Controls.Add(this.nudLongueurDepart);
            this.pControles.Controls.Add(this.nudAngle);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(811, 47);
            this.pControles.TabIndex = 0;
            // 
            // bDessiner
            // 
            this.bDessiner.Location = new System.Drawing.Point(516, 12);
            this.bDessiner.Name = "bDessiner";
            this.bDessiner.Size = new System.Drawing.Size(75, 23);
            this.bDessiner.TabIndex = 6;
            this.bDessiner.Text = "Dessiner";
            this.bDessiner.UseVisualStyleBackColor = true;
            this.bDessiner.Click += new System.EventHandler(this.bDessiner_Click);
            // 
            // lPas
            // 
            this.lPas.AutoSize = true;
            this.lPas.Location = new System.Drawing.Point(436, 14);
            this.lPas.Name = "lPas";
            this.lPas.Size = new System.Drawing.Size(25, 15);
            this.lPas.TabIndex = 5;
            this.lPas.Text = "Pas";
            // 
            // lNombreLignes
            // 
            this.lNombreLignes.AutoSize = true;
            this.lNombreLignes.Location = new System.Drawing.Point(264, 14);
            this.lNombreLignes.Name = "lNombreLignes";
            this.lNombreLignes.Size = new System.Drawing.Size(101, 15);
            this.lNombreLignes.TabIndex = 5;
            this.lNombreLignes.Text = "Nombre de lignes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Longueur départ";
            // 
            // lAngle
            // 
            this.lAngle.AutoSize = true;
            this.lAngle.Location = new System.Drawing.Point(12, 14);
            this.lAngle.Name = "lAngle";
            this.lAngle.Size = new System.Drawing.Size(38, 15);
            this.lAngle.TabIndex = 4;
            this.lAngle.Text = "Angle";
            // 
            // nudPas
            // 
            this.nudPas.Location = new System.Drawing.Point(467, 12);
            this.nudPas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPas.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudPas.Name = "nudPas";
            this.nudPas.Size = new System.Drawing.Size(43, 23);
            this.nudPas.TabIndex = 3;
            // 
            // nudNombreLignes
            // 
            this.nudNombreLignes.Location = new System.Drawing.Point(371, 12);
            this.nudNombreLignes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNombreLignes.Name = "nudNombreLignes";
            this.nudNombreLignes.Size = new System.Drawing.Size(59, 23);
            this.nudNombreLignes.TabIndex = 2;
            this.nudNombreLignes.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudLongueurDepart
            // 
            this.nudLongueurDepart.Location = new System.Drawing.Point(217, 12);
            this.nudLongueurDepart.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLongueurDepart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongueurDepart.Name = "nudLongueurDepart";
            this.nudLongueurDepart.Size = new System.Drawing.Size(41, 23);
            this.nudLongueurDepart.TabIndex = 1;
            this.nudLongueurDepart.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudAngle
            // 
            this.nudAngle.Location = new System.Drawing.Point(56, 12);
            this.nudAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(54, 23);
            this.nudAngle.TabIndex = 0;
            this.nudAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // pCanvas
            // 
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCanvas.Location = new System.Drawing.Point(0, 47);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(811, 426);
            this.pCanvas.TabIndex = 1;
            // 
            // fDessinLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 473);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.pControles);
            this.MinimumSize = new System.Drawing.Size(600, 512);
            this.Name = "fDessinLignes";
            this.Text = "La révolution des lignes";
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Label lAngle;
        private System.Windows.Forms.NumericUpDown nudPas;
        private System.Windows.Forms.NumericUpDown nudNombreLignes;
        private System.Windows.Forms.NumericUpDown nudLongueurDepart;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNombreLignes;
        private System.Windows.Forms.Label lPas;
        private System.Windows.Forms.Button bDessiner;
    }
}

