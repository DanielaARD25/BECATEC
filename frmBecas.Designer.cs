namespace TAPU1_A4_INT
{
    partial class frmBecas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBecas));
            this.ssInformacion = new System.Windows.Forms.StatusStrip();
            this.tsslnombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTipoUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDeportiva = new System.Windows.Forms.Button();
            this.btnAcademica = new System.Windows.Forms.Button();
            this.btnExcelencia = new System.Windows.Forms.Button();
            this.btnManuntencion = new System.Windows.Forms.Button();
            this.ttInformacion = new System.Windows.Forms.ToolTip(this.components);
            this.pbBecaTEc = new System.Windows.Forms.PictureBox();
            this.tssbFuncionSalir = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ssInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBecaTEc)).BeginInit();
            this.SuspendLayout();
            // 
            // ssInformacion
            // 
            this.ssInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbFuncionSalir,
            this.tsslnombreUsuario,
            this.tsslTipoUsuario});
            this.ssInformacion.Location = new System.Drawing.Point(0, 290);
            this.ssInformacion.Name = "ssInformacion";
            this.ssInformacion.Size = new System.Drawing.Size(571, 22);
            this.ssInformacion.TabIndex = 0;
            this.ssInformacion.Text = "statusStrip1";
            // 
            // tsslnombreUsuario
            // 
            this.tsslnombreUsuario.Name = "tsslnombreUsuario";
            this.tsslnombreUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslTipoUsuario
            // 
            this.tsslTipoUsuario.Name = "tsslTipoUsuario";
            this.tsslTipoUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDeportiva
            // 
            this.btnDeportiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeportiva.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeportiva.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeportiva.Location = new System.Drawing.Point(51, 185);
            this.btnDeportiva.Name = "btnDeportiva";
            this.btnDeportiva.Size = new System.Drawing.Size(100, 53);
            this.btnDeportiva.TabIndex = 1;
            this.btnDeportiva.Text = "Beca Deportiva";
            this.btnDeportiva.UseVisualStyleBackColor = true;
            this.btnDeportiva.MouseEnter += new System.EventHandler(this.btnDeportiva_MouseEnter);
            this.btnDeportiva.MouseLeave += new System.EventHandler(this.btnDeportiva_MouseLeave);
            this.btnDeportiva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDeportiva_MouseMove);
            // 
            // btnAcademica
            // 
            this.btnAcademica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcademica.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcademica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcademica.Location = new System.Drawing.Point(178, 185);
            this.btnAcademica.Name = "btnAcademica";
            this.btnAcademica.Size = new System.Drawing.Size(103, 53);
            this.btnAcademica.TabIndex = 2;
            this.btnAcademica.Text = "Beca Académica";
            this.btnAcademica.UseVisualStyleBackColor = true;
            this.btnAcademica.MouseEnter += new System.EventHandler(this.btnAcademica_MouseEnter);
            this.btnAcademica.MouseLeave += new System.EventHandler(this.btnAcademica_MouseLeave);
            // 
            // btnExcelencia
            // 
            this.btnExcelencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelencia.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcelencia.Location = new System.Drawing.Point(306, 185);
            this.btnExcelencia.Name = "btnExcelencia";
            this.btnExcelencia.Size = new System.Drawing.Size(101, 53);
            this.btnExcelencia.TabIndex = 3;
            this.btnExcelencia.Text = "Beca de Excelencia";
            this.btnExcelencia.UseVisualStyleBackColor = true;
            this.btnExcelencia.MouseEnter += new System.EventHandler(this.btnExcelencia_MouseEnter);
            this.btnExcelencia.MouseLeave += new System.EventHandler(this.btnExcelencia_MouseLeave);
            // 
            // btnManuntencion
            // 
            this.btnManuntencion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManuntencion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManuntencion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnManuntencion.Location = new System.Drawing.Point(429, 185);
            this.btnManuntencion.Name = "btnManuntencion";
            this.btnManuntencion.Size = new System.Drawing.Size(105, 53);
            this.btnManuntencion.TabIndex = 4;
            this.btnManuntencion.Text = "Beca de Manutención";
            this.btnManuntencion.UseVisualStyleBackColor = true;
            this.btnManuntencion.MouseEnter += new System.EventHandler(this.btnManuntencion_MouseEnter);
            this.btnManuntencion.MouseLeave += new System.EventHandler(this.btnManuntencion_MouseLeave);
            // 
            // ttInformacion
            // 
            this.ttInformacion.IsBalloon = true;
            // 
            // pbBecaTEc
            // 
            this.pbBecaTEc.Image = ((System.Drawing.Image)(resources.GetObject("pbBecaTEc.Image")));
            this.pbBecaTEc.Location = new System.Drawing.Point(66, 54);
            this.pbBecaTEc.Name = "pbBecaTEc";
            this.pbBecaTEc.Size = new System.Drawing.Size(427, 125);
            this.pbBecaTEc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBecaTEc.TabIndex = 5;
            this.pbBecaTEc.TabStop = false;
            // 
            // tssbFuncionSalir
            // 
            this.tssbFuncionSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbFuncionSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalir,
            this.toolStripSeparator1});
            this.tssbFuncionSalir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssbFuncionSalir.Image = global::TAPU1_A4_INT.Properties.Resources.tecsanpedro_solo;
            this.tssbFuncionSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbFuncionSalir.Name = "tssbFuncionSalir";
            this.tssbFuncionSalir.Size = new System.Drawing.Size(32, 20);
            this.tssbFuncionSalir.Text = "toolStripSplitButton1";
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = global::TAPU1_A4_INT.Properties.Resources.logout_FILL0_wght400_GRAD0_opsz48;
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(111, 22);
            this.tsmiSalir.Text = "SALIR";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // frmBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(571, 312);
            this.Controls.Add(this.pbBecaTEc);
            this.Controls.Add(this.btnManuntencion);
            this.Controls.Add(this.btnExcelencia);
            this.Controls.Add(this.btnAcademica);
            this.Controls.Add(this.btnDeportiva);
            this.Controls.Add(this.ssInformacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BecaTEc";
            this.Load += new System.EventHandler(this.frmBecas_Load);
            this.ssInformacion.ResumeLayout(false);
            this.ssInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBecaTEc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssInformacion;
        private System.Windows.Forms.ToolStripSplitButton tssbFuncionSalir;
        private System.Windows.Forms.ToolStripStatusLabel tsslnombreUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tsslTipoUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnDeportiva;
        private System.Windows.Forms.Button btnAcademica;
        private System.Windows.Forms.Button btnExcelencia;
        private System.Windows.Forms.Button btnManuntencion;
        private System.Windows.Forms.ToolTip ttInformacion;
        private System.Windows.Forms.PictureBox pbBecaTEc;
    }
}