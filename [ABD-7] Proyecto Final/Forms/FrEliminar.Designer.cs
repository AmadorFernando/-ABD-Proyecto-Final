namespace _ABD_7__Proyecto_Final.Forms
{
    partial class FrEliminar
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
            this.cboxTablas = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.cboxObjeto = new System.Windows.Forms.ComboBox();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvEliminar = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxTablas
            // 
            this.cboxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTablas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTablas.FormattingEnabled = true;
            this.cboxTablas.Location = new System.Drawing.Point(419, 50);
            this.cboxTablas.Name = "cboxTablas";
            this.cboxTablas.Size = new System.Drawing.Size(156, 30);
            this.cboxTablas.TabIndex = 2;
            this.cboxTablas.Visible = false;
            this.cboxTablas.SelectionChangeCommitted += new System.EventHandler(this.cboxTablas_SelectionChangeCommitted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(48, 96);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 44);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEliminar.Location = new System.Drawing.Point(6, 53);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(112, 26);
            this.lblEliminar.TabIndex = 6;
            this.lblEliminar.Text = "ELIMINAR";
            // 
            // cboxObjeto
            // 
            this.cboxObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxObjeto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxObjeto.FormattingEnabled = true;
            this.cboxObjeto.Items.AddRange(new object[] {
            "Base de Datos",
            "Registros",
            "Tabla"});
            this.cboxObjeto.Location = new System.Drawing.Point(121, 50);
            this.cboxObjeto.Name = "cboxObjeto";
            this.cboxObjeto.Size = new System.Drawing.Size(163, 34);
            this.cboxObjeto.TabIndex = 7;
            this.cboxObjeto.SelectedIndexChanged += new System.EventHandler(this.cboxObjeto_SelectedIndexChanged);
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLlamada.Location = new System.Drawing.Point(294, 53);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(119, 26);
            this.lblLlamada.TabIndex = 8;
            this.lblLlamada.Text = "LLAMADA:";
            this.lblLlamada.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(398, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 44);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvEliminar
            // 
            this.dgvEliminar.AllowUserToAddRows = false;
            this.dgvEliminar.AllowUserToDeleteRows = false;
            this.dgvEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminar.Location = new System.Drawing.Point(48, 96);
            this.dgvEliminar.Name = "dgvEliminar";
            this.dgvEliminar.ReadOnly = true;
            this.dgvEliminar.Size = new System.Drawing.Size(501, 147);
            this.dgvEliminar.TabIndex = 10;
            this.dgvEliminar.Visible = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 33);
            this.panelTop.TabIndex = 11;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pboxMin
            // 
            this.pboxMin.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(514, 2);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(27, 29);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMin.TabIndex = 3;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Close_Window__2_48px;
            this.pboxClose.Location = new System.Drawing.Point(557, 1);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 29);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 2;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // FrEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblLlamada);
            this.Controls.Add(this.cboxObjeto);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboxTablas);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrEliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxTablas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.ComboBox cboxObjeto;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvEliminar;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
    }
}