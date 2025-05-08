namespace TAPU1_A4_INT
{
    partial class frmInformacionBeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInformacionBeca));
            this.lbInformacionBeca = new System.Windows.Forms.Label();
            this.pbBecaTEc = new System.Windows.Forms.PictureBox();
            this.pbNombre = new System.Windows.Forms.PictureBox();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBecaTEc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInformacionBeca
            // 
            this.lbInformacionBeca.AutoSize = true;
            this.lbInformacionBeca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInformacionBeca.ForeColor = System.Drawing.Color.DarkRed;
            this.lbInformacionBeca.Location = new System.Drawing.Point(139, 74);
            this.lbInformacionBeca.Name = "lbInformacionBeca";
            this.lbInformacionBeca.Size = new System.Drawing.Size(0, 15);
            this.lbInformacionBeca.TabIndex = 5;
            // 
            // pbBecaTEc
            // 
            this.pbBecaTEc.Image = ((System.Drawing.Image)(resources.GetObject("pbBecaTEc.Image")));
            this.pbBecaTEc.Location = new System.Drawing.Point(346, 251);
            this.pbBecaTEc.Name = "pbBecaTEc";
            this.pbBecaTEc.Size = new System.Drawing.Size(74, 29);
            this.pbBecaTEc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBecaTEc.TabIndex = 4;
            this.pbBecaTEc.TabStop = false;
            // 
            // pbNombre
            // 
            this.pbNombre.Location = new System.Drawing.Point(139, 12);
            this.pbNombre.Name = "pbNombre";
            this.pbNombre.Size = new System.Drawing.Size(218, 75);
            this.pbNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNombre.TabIndex = 3;
            this.pbNombre.TabStop = false;
            this.pbNombre.Click += new System.EventHandler(this.pbNombre_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(12, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(121, 258);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 2;
            this.pbImagen.TabStop = false;
            // 
            // frmInformacionBeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(423, 282);
            this.ControlBox = false;
            this.Controls.Add(this.lbInformacionBeca);
            this.Controls.Add(this.pbBecaTEc);
            this.Controls.Add(this.pbNombre);
            this.Controls.Add(this.pbImagen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(500, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInformacionBeca";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmInformacionBeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBecaTEc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox pbImagen;
        public System.Windows.Forms.PictureBox pbNombre;
        public System.Windows.Forms.PictureBox pbBecaTEc;
        public System.Windows.Forms.Label lbInformacionBeca;
    }
}