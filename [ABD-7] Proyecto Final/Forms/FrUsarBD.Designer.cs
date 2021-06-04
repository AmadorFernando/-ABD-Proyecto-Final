namespace _ABD_7__Proyecto_Final.Forms
{
    partial class FrUsarBD
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
            this.cboxBD = new System.Windows.Forms.ComboBox();
            this.btnUsar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxBD
            // 
            this.cboxBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBD.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxBD.FormattingEnabled = true;
            this.cboxBD.Location = new System.Drawing.Point(24, 65);
            this.cboxBD.Name = "cboxBD";
            this.cboxBD.Size = new System.Drawing.Size(295, 24);
            this.cboxBD.TabIndex = 0;
            // 
            // btnUsar
            // 
            this.btnUsar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsar.Location = new System.Drawing.Point(24, 99);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(129, 49);
            this.btnUsar.TabIndex = 1;
            this.btnUsar.Text = "USAR";
            this.btnUsar.UseVisualStyleBackColor = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(190, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 53);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la Base de Datos que usaras";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pboxMin);
            this.panel1.Controls.Add(this.pboxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 33);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pboxClose
            // 
            this.pboxClose.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Close_Window__2_48px;
            this.pboxClose.Location = new System.Drawing.Point(310, 2);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 29);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 0;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // pboxMin
            // 
            this.pboxMin.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(267, 3);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 29);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMin.TabIndex = 1;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // FrUsarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.cboxBD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrUsarBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrUsarBD";
            this.Load += new System.EventHandler(this.FrUsarBD_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBD;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxClose;
        private System.Windows.Forms.PictureBox pboxMin;
    }
}