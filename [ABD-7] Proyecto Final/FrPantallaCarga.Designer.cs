namespace _ABD_7__Proyecto_Final
{
    partial class FrPantallaCarga
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.probarInicio = new System.Windows.Forms.ProgressBar();
            this.lblCreado = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblIzq = new System.Windows.Forms.Label();
            this.lblDerecho = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.DBNormal_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(119, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // probarInicio
            // 
            this.probarInicio.Location = new System.Drawing.Point(60, 199);
            this.probarInicio.Name = "probarInicio";
            this.probarInicio.Size = new System.Drawing.Size(236, 23);
            this.probarInicio.TabIndex = 1;
            // 
            // lblCreado
            // 
            this.lblCreado.AutoSize = true;
            this.lblCreado.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreado.Location = new System.Drawing.Point(55, 227);
            this.lblCreado.Name = "lblCreado";
            this.lblCreado.Size = new System.Drawing.Size(243, 26);
            this.lblCreado.TabIndex = 2;
            this.lblCreado.Text = "Creado por Yosip y Amador";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.Location = new System.Drawing.Point(302, 199);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(38, 26);
            this.lblPorcentaje.TabIndex = 3;
            this.lblPorcentaje.Text = "0%";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.Location = new System.Drawing.Point(122, 147);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(131, 26);
            this.lblSubTitulo.TabIndex = 4;
            this.lblSubTitulo.Text = "ABD Software";
            // 
            // lblTop
            // 
            this.lblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblTop.Location = new System.Drawing.Point(0, -1);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(377, 23);
            this.lblTop.TabIndex = 5;
            // 
            // lblBottom
            // 
            this.lblBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblBottom.Location = new System.Drawing.Point(0, 258);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(377, 23);
            this.lblBottom.TabIndex = 6;
            // 
            // lblIzq
            // 
            this.lblIzq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblIzq.Location = new System.Drawing.Point(0, 2);
            this.lblIzq.Name = "lblIzq";
            this.lblIzq.Size = new System.Drawing.Size(23, 279);
            this.lblIzq.TabIndex = 7;
            // 
            // lblDerecho
            // 
            this.lblDerecho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.lblDerecho.Location = new System.Drawing.Point(354, 1);
            this.lblDerecho.Name = "lblDerecho";
            this.lblDerecho.Size = new System.Drawing.Size(23, 279);
            this.lblDerecho.TabIndex = 8;
            // 
            // FrPantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 281);
            this.Controls.Add(this.lblDerecho);
            this.Controls.Add(this.lblIzq);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblCreado);
            this.Controls.Add(this.probarInicio);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrPantallaCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrPantallaCarga";
            this.Load += new System.EventHandler(this.FrPantallaCarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar probarInicio;
        private System.Windows.Forms.Label lblCreado;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblIzq;
        private System.Windows.Forms.Label lblDerecho;
    }
}