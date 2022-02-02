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
            this.pControles = new System.Windows.Forms.Panel();
            this.nudNombreIterationsFloconsKoch = new System.Windows.Forms.NumericUpDown();
            this.lNombreIterationsFloconsKoch = new System.Windows.Forms.Label();
            this.bDessiner = new System.Windows.Forms.Button();
            this.lPasLongueur = new System.Windows.Forms.Label();
            this.lNombreLignes = new System.Windows.Forms.Label();
            this.lLongueurDepart = new System.Windows.Forms.Label();
            this.lPasAngle = new System.Windows.Forms.Label();
            this.nudPasLongueur = new System.Windows.Forms.NumericUpDown();
            this.nudNombreLignes = new System.Windows.Forms.NumericUpDown();
            this.nudLongueurDepart = new System.Windows.Forms.NumericUpDown();
            this.nudPasAngle = new System.Windows.Forms.NumericUpDown();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.bSubdiviserFloconsKoch = new System.Windows.Forms.Button();
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreIterationsFloconsKoch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasLongueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.bSubdiviserFloconsKoch);
            this.pControles.Controls.Add(this.nudNombreIterationsFloconsKoch);
            this.pControles.Controls.Add(this.lNombreIterationsFloconsKoch);
            this.pControles.Controls.Add(this.bDessiner);
            this.pControles.Controls.Add(this.lPasLongueur);
            this.pControles.Controls.Add(this.lNombreLignes);
            this.pControles.Controls.Add(this.lLongueurDepart);
            this.pControles.Controls.Add(this.lPasAngle);
            this.pControles.Controls.Add(this.nudPasLongueur);
            this.pControles.Controls.Add(this.nudNombreLignes);
            this.pControles.Controls.Add(this.nudLongueurDepart);
            this.pControles.Controls.Add(this.nudPasAngle);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1012, 47);
            this.pControles.TabIndex = 0;
            // 
            // nudNombreIterationsFloconsKoch
            // 
            this.nudNombreIterationsFloconsKoch.Location = new System.Drawing.Point(860, 12);
            this.nudNombreIterationsFloconsKoch.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNombreIterationsFloconsKoch.Name = "nudNombreIterationsFloconsKoch";
            this.nudNombreIterationsFloconsKoch.Size = new System.Drawing.Size(59, 23);
            this.nudNombreIterationsFloconsKoch.TabIndex = 8;
            this.nudNombreIterationsFloconsKoch.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lNombreIterationsFloconsKoch
            // 
            this.lNombreIterationsFloconsKoch.AutoSize = true;
            this.lNombreIterationsFloconsKoch.Location = new System.Drawing.Point(658, 14);
            this.lNombreIterationsFloconsKoch.Name = "lNombreIterationsFloconsKoch";
            this.lNombreIterationsFloconsKoch.Size = new System.Drawing.Size(196, 15);
            this.lNombreIterationsFloconsKoch.TabIndex = 7;
            this.lNombreIterationsFloconsKoch.Text = "Nombre d\'itération flocons de Koch";
            // 
            // bDessiner
            // 
            this.bDessiner.Location = new System.Drawing.Point(577, 12);
            this.bDessiner.Name = "bDessiner";
            this.bDessiner.Size = new System.Drawing.Size(75, 23);
            this.bDessiner.TabIndex = 6;
            this.bDessiner.Text = "Dessiner";
            this.bDessiner.UseVisualStyleBackColor = true;
            this.bDessiner.Click += new System.EventHandler(this.bDessiner_Click);
            // 
            // lPasLongueur
            // 
            this.lPasLongueur.AutoSize = true;
            this.lPasLongueur.Location = new System.Drawing.Point(449, 14);
            this.lPasLongueur.Name = "lPasLongueur";
            this.lPasLongueur.Size = new System.Drawing.Size(76, 15);
            this.lPasLongueur.TabIndex = 5;
            this.lPasLongueur.Text = "Pas longueur";
            // 
            // lNombreLignes
            // 
            this.lNombreLignes.AutoSize = true;
            this.lNombreLignes.Location = new System.Drawing.Point(277, 14);
            this.lNombreLignes.Name = "lNombreLignes";
            this.lNombreLignes.Size = new System.Drawing.Size(101, 15);
            this.lNombreLignes.TabIndex = 5;
            this.lNombreLignes.Text = "Nombre de lignes";
            // 
            // lLongueurDepart
            // 
            this.lLongueurDepart.AutoSize = true;
            this.lLongueurDepart.Location = new System.Drawing.Point(129, 14);
            this.lLongueurDepart.Name = "lLongueurDepart";
            this.lLongueurDepart.Size = new System.Drawing.Size(95, 15);
            this.lLongueurDepart.TabIndex = 4;
            this.lLongueurDepart.Text = "Longueur départ";
            // 
            // lPasAngle
            // 
            this.lPasAngle.AutoSize = true;
            this.lPasAngle.Location = new System.Drawing.Point(12, 14);
            this.lPasAngle.Name = "lPasAngle";
            this.lPasAngle.Size = new System.Drawing.Size(57, 15);
            this.lPasAngle.TabIndex = 4;
            this.lPasAngle.Text = "Pas angle";
            // 
            // nudPasLongueur
            // 
            this.nudPasLongueur.Location = new System.Drawing.Point(528, 12);
            this.nudPasLongueur.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPasLongueur.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudPasLongueur.Name = "nudPasLongueur";
            this.nudPasLongueur.Size = new System.Drawing.Size(43, 23);
            this.nudPasLongueur.TabIndex = 3;
            // 
            // nudNombreLignes
            // 
            this.nudNombreLignes.Location = new System.Drawing.Point(384, 12);
            this.nudNombreLignes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudNombreLignes.Name = "nudNombreLignes";
            this.nudNombreLignes.Size = new System.Drawing.Size(59, 23);
            this.nudNombreLignes.TabIndex = 2;
            this.nudNombreLignes.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudLongueurDepart
            // 
            this.nudLongueurDepart.Location = new System.Drawing.Point(230, 12);
            this.nudLongueurDepart.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudLongueurDepart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLongueurDepart.Name = "nudLongueurDepart";
            this.nudLongueurDepart.Size = new System.Drawing.Size(41, 23);
            this.nudLongueurDepart.TabIndex = 1;
            this.nudLongueurDepart.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudPasAngle
            // 
            this.nudPasAngle.Location = new System.Drawing.Point(73, 12);
            this.nudPasAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudPasAngle.Name = "nudPasAngle";
            this.nudPasAngle.Size = new System.Drawing.Size(54, 23);
            this.nudPasAngle.TabIndex = 0;
            this.nudPasAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // pCanvas
            // 
            this.pCanvas.BackColor = System.Drawing.Color.White;
            this.pCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCanvas.Location = new System.Drawing.Point(0, 47);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(1012, 426);
            this.pCanvas.TabIndex = 1;
            // 
            // bSubdiviserFloconsKoch
            // 
            this.bSubdiviserFloconsKoch.Location = new System.Drawing.Point(925, 12);
            this.bSubdiviserFloconsKoch.Name = "bSubdiviserFloconsKoch";
            this.bSubdiviserFloconsKoch.Size = new System.Drawing.Size(75, 23);
            this.bSubdiviserFloconsKoch.TabIndex = 9;
            this.bSubdiviserFloconsKoch.Text = "Dessiner";
            this.bSubdiviserFloconsKoch.UseVisualStyleBackColor = true;
            this.bSubdiviserFloconsKoch.Click += new System.EventHandler(this.bSubdiviserFloconsKoch_Click);
            // 
            // fDessinLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 473);
            this.Controls.Add(this.pCanvas);
            this.Controls.Add(this.pControles);
            this.MinimumSize = new System.Drawing.Size(1028, 512);
            this.Name = "fDessinLignes";
            this.Text = "La révolution des lignes";
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreIterationsFloconsKoch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasLongueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreLignes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongueurDepart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasAngle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Label lPasAngle;
        private System.Windows.Forms.NumericUpDown nudPasLongueur;
        private System.Windows.Forms.NumericUpDown nudNombreLignes;
        private System.Windows.Forms.NumericUpDown nudLongueurDepart;
        private System.Windows.Forms.NumericUpDown nudPasAngle;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.Label lLongueurDepart;
        private System.Windows.Forms.Label lNombreLignes;
        private System.Windows.Forms.Label lPasLongueur;
        private System.Windows.Forms.Button bDessiner;
        private System.Windows.Forms.NumericUpDown nudNombreIterationsFloconsKoch;
        private System.Windows.Forms.Label lNombreIterationsFloconsKoch;
        private System.Windows.Forms.Button bSubdiviserFloconsKoch;
    }
}

