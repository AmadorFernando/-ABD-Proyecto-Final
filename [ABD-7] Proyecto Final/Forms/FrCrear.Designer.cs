namespace _ABD_7__Proyecto_Final.Forms
{
    partial class FrCrear
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
            this.lblCrear = new System.Windows.Forms.Label();
            this.cboxObjeto = new System.Windows.Forms.ComboBox();
            this.lblLlamada = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCrear = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrear)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(6, 51);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(77, 26);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "CREAR";
            // 
            // cboxObjeto
            // 
            this.cboxObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxObjeto.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxObjeto.FormattingEnabled = true;
            this.cboxObjeto.Location = new System.Drawing.Point(89, 48);
            this.cboxObjeto.Name = "cboxObjeto";
            this.cboxObjeto.Size = new System.Drawing.Size(163, 34);
            this.cboxObjeto.TabIndex = 1;
            this.cboxObjeto.SelectedIndexChanged += new System.EventHandler(this.cboxObjeto_SelectedIndexChanged);
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.Location = new System.Drawing.Point(271, 51);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(119, 26);
            this.lblLlamada.TabIndex = 2;
            this.lblLlamada.Text = "LLAMADA:";
            this.lblLlamada.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(396, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 33);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.Visible = false;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.Black;
            this.btnCrear.Location = new System.Drawing.Point(47, 96);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 44);
            this.btnCrear.TabIndex = 4;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(399, 96);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(151, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvCrear
            // 
            this.dgvCrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCrear.Location = new System.Drawing.Point(48, 96);
            this.dgvCrear.Name = "dgvCrear";
            this.dgvCrear.Size = new System.Drawing.Size(501, 147);
            this.dgvCrear.TabIndex = 6;
            this.dgvCrear.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tipo de Dato";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.HeaderText = "Not Null";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 51;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Primary Key";
            this.Column4.Name = "Column4";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(600, 34);
            this.panelTop.TabIndex = 7;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pboxMin
            // 
            this.pboxMin.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(522, 2);
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
            this.pboxClose.Location = new System.Drawing.Point(559, 2);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(27, 29);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 2;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // FrCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvCrear);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblLlamada);
            this.Controls.Add(this.cboxObjeto);
            this.Controls.Add(this.lblCrear);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrCrear";
            this.Load += new System.EventHandler(this.FrCrear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrear)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.ComboBox cboxObjeto;
        private System.Windows.Forms.Label lblLlamada;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCrear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
    }
}