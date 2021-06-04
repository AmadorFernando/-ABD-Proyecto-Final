namespace _ABD_7__Proyecto_Final.Forms
{
    partial class FrBuscador
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.cboxCondicionales = new System.Windows.Forms.ComboBox();
            this.lblEs = new System.Windows.Forms.Label();
            this.cboxColumnas = new System.Windows.Forms.ComboBox();
            this.lblDonde = new System.Windows.Forms.Label();
            this.lblSelecciona = new System.Windows.Forms.Label();
            this.clbColumnas = new System.Windows.Forms.CheckedListBox();
            this.lblDLTabla = new System.Windows.Forms.Label();
            this.cboxTablas = new System.Windows.Forms.ComboBox();
            this.cboxTodas = new System.Windows.Forms.CheckBox();
            this.btnListo = new System.Windows.Forms.Button();
            this.dgvBuscador = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pboxMin = new System.Windows.Forms.PictureBox();
            this.pboxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscador)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDato.Location = new System.Drawing.Point(314, 94);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 33);
            this.txtDato.TabIndex = 17;
            this.txtDato.Visible = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.SystemColors.Control;
            this.lblA.Location = new System.Drawing.Point(281, 96);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(27, 26);
            this.lblA.TabIndex = 16;
            this.lblA.Text = "A";
            this.lblA.Visible = false;
            // 
            // cboxCondicionales
            // 
            this.cboxCondicionales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCondicionales.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCondicionales.FormattingEnabled = true;
            this.cboxCondicionales.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<="});
            this.cboxCondicionales.Location = new System.Drawing.Point(231, 93);
            this.cboxCondicionales.Name = "cboxCondicionales";
            this.cboxCondicionales.Size = new System.Drawing.Size(44, 34);
            this.cboxCondicionales.TabIndex = 15;
            this.cboxCondicionales.Visible = false;
            // 
            // lblEs
            // 
            this.lblEs.AutoSize = true;
            this.lblEs.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEs.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEs.Location = new System.Drawing.Point(191, 97);
            this.lblEs.Name = "lblEs";
            this.lblEs.Size = new System.Drawing.Size(34, 26);
            this.lblEs.TabIndex = 14;
            this.lblEs.Text = "ES";
            this.lblEs.Visible = false;
            // 
            // cboxColumnas
            // 
            this.cboxColumnas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColumnas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxColumnas.FormattingEnabled = true;
            this.cboxColumnas.Location = new System.Drawing.Point(104, 94);
            this.cboxColumnas.Name = "cboxColumnas";
            this.cboxColumnas.Size = new System.Drawing.Size(81, 34);
            this.cboxColumnas.TabIndex = 13;
            this.cboxColumnas.Visible = false;
            // 
            // lblDonde
            // 
            this.lblDonde.AutoSize = true;
            this.lblDonde.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonde.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDonde.Location = new System.Drawing.Point(14, 97);
            this.lblDonde.Name = "lblDonde";
            this.lblDonde.Size = new System.Drawing.Size(84, 26);
            this.lblDonde.TabIndex = 12;
            this.lblDonde.Text = "DONDE";
            this.lblDonde.Visible = false;
            // 
            // lblSelecciona
            // 
            this.lblSelecciona.AutoSize = true;
            this.lblSelecciona.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecciona.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSelecciona.Location = new System.Drawing.Point(328, 52);
            this.lblSelecciona.Name = "lblSelecciona";
            this.lblSelecciona.Size = new System.Drawing.Size(134, 26);
            this.lblSelecciona.TabIndex = 10;
            this.lblSelecciona.Text = "SELECCIONA";
            // 
            // clbColumnas
            // 
            this.clbColumnas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbColumnas.FormattingEnabled = true;
            this.clbColumnas.Location = new System.Drawing.Point(468, 52);
            this.clbColumnas.Name = "clbColumnas";
            this.clbColumnas.ScrollAlwaysVisible = true;
            this.clbColumnas.Size = new System.Drawing.Size(294, 28);
            this.clbColumnas.TabIndex = 18;
            this.clbColumnas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbColumnas_ItemCheck);
            // 
            // lblDLTabla
            // 
            this.lblDLTabla.AutoSize = true;
            this.lblDLTabla.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDLTabla.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDLTabla.Location = new System.Drawing.Point(14, 52);
            this.lblDLTabla.Name = "lblDLTabla";
            this.lblDLTabla.Size = new System.Drawing.Size(143, 26);
            this.lblDLTabla.TabIndex = 19;
            this.lblDLTabla.Text = "DE LA TABLA";
            // 
            // cboxTablas
            // 
            this.cboxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTablas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTablas.FormattingEnabled = true;
            this.cboxTablas.Location = new System.Drawing.Point(159, 49);
            this.cboxTablas.Name = "cboxTablas";
            this.cboxTablas.Size = new System.Drawing.Size(163, 34);
            this.cboxTablas.TabIndex = 20;
            this.cboxTablas.SelectedIndexChanged += new System.EventHandler(this.cboxTablas_SelectedIndexChanged);
            // 
            // cboxTodas
            // 
            this.cboxTodas.AutoSize = true;
            this.cboxTodas.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTodas.ForeColor = System.Drawing.SystemColors.Control;
            this.cboxTodas.Location = new System.Drawing.Point(768, 49);
            this.cboxTodas.Name = "cboxTodas";
            this.cboxTodas.Size = new System.Drawing.Size(82, 30);
            this.cboxTodas.TabIndex = 21;
            this.cboxTodas.Text = "Todas";
            this.cboxTodas.UseVisualStyleBackColor = true;
            this.cboxTodas.CheckedChanged += new System.EventHandler(this.cboxTodas_CheckedChanged);
            // 
            // btnListo
            // 
            this.btnListo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Location = new System.Drawing.Point(707, 89);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(150, 42);
            this.btnListo.TabIndex = 22;
            this.btnListo.Text = "ESPECIFICAR";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // dgvBuscador
            // 
            this.dgvBuscador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscador.Location = new System.Drawing.Point(146, 150);
            this.dgvBuscador.Name = "dgvBuscador";
            this.dgvBuscador.Size = new System.Drawing.Size(555, 247);
            this.dgvBuscador.TabIndex = 23;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(541, 87);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(151, 44);
            this.btnCrear.TabIndex = 24;
            this.btnCrear.Text = "BUSCAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Black;
            this.panelTop.Controls.Add(this.pboxMin);
            this.panelTop.Controls.Add(this.pboxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(884, 43);
            this.panelTop.TabIndex = 25;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // pboxMin
            // 
            this.pboxMin.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Minimize_Window_2_48px;
            this.pboxMin.Location = new System.Drawing.Point(776, 3);
            this.pboxMin.Name = "pboxMin";
            this.pboxMin.Size = new System.Drawing.Size(45, 37);
            this.pboxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMin.TabIndex = 3;
            this.pboxMin.TabStop = false;
            this.pboxMin.Click += new System.EventHandler(this.pboxMin_Click);
            // 
            // pboxClose
            // 
            this.pboxClose.Image = global::_ABD_7__Proyecto_Final.Properties.Resources.Close_Window__2_48px;
            this.pboxClose.Location = new System.Drawing.Point(827, 3);
            this.pboxClose.Name = "pboxClose";
            this.pboxClose.Size = new System.Drawing.Size(45, 37);
            this.pboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxClose.TabIndex = 2;
            this.pboxClose.TabStop = false;
            this.pboxClose.Click += new System.EventHandler(this.pboxClose_Click);
            // 
            // FrBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(884, 409);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvBuscador);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.cboxTodas);
            this.Controls.Add(this.cboxTablas);
            this.Controls.Add(this.lblDLTabla);
            this.Controls.Add(this.clbColumnas);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.cboxCondicionales);
            this.Controls.Add(this.lblEs);
            this.Controls.Add(this.cboxColumnas);
            this.Controls.Add(this.lblDonde);
            this.Controls.Add(this.lblSelecciona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrBuscador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrBuscador";
            this.Load += new System.EventHandler(this.FrBuscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscador)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cboxCondicionales;
        private System.Windows.Forms.Label lblEs;
        private System.Windows.Forms.ComboBox cboxColumnas;
        private System.Windows.Forms.Label lblDonde;
        private System.Windows.Forms.Label lblSelecciona;
        private System.Windows.Forms.CheckedListBox clbColumnas;
        private System.Windows.Forms.Label lblDLTabla;
        private System.Windows.Forms.ComboBox cboxTablas;
        private System.Windows.Forms.CheckBox cboxTodas;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.DataGridView dgvBuscador;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pboxMin;
        private System.Windows.Forms.PictureBox pboxClose;
    }
}