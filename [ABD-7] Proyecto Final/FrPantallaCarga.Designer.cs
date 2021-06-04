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
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblCreado.Location = new System.Drawing.Point(55, 246);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "ABD Software";
            // 
            // FrPantallaCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 281);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}