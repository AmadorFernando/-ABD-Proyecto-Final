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
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxTablas
            // 
            this.cboxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTablas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTablas.FormattingEnabled = true;
            this.cboxTablas.Location = new System.Drawing.Point(419, 32);
            this.cboxTablas.Name = "cboxTablas";
            this.cboxTablas.Size = new System.Drawing.Size(156, 30);
            this.cboxTablas.TabIndex = 2;
            this.cboxTablas.Visible = false;
            this.cboxTablas.SelectionChangeCommitted += new System.EventHandler(this.cboxTablas_SelectionChangeCommitted);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblEliminar.Location = new System.Drawing.Point(6, 35);
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
            this.cboxObjeto.Location = new System.Drawing.Point(121, 32);
            this.cboxObjeto.Name = "cboxObjeto";
            this.cboxObjeto.Size = new System.Drawing.Size(163, 34);
            this.cboxObjeto.TabIndex = 7;
            this.cboxObjeto.SelectedIndexChanged += new System.EventHandler(this.cboxObjeto_SelectedIndexChanged);
            // 
            // lblLlamada
            // 
            this.lblLlamada.AutoSize = true;
            this.lblLlamada.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlamada.Location = new System.Drawing.Point(294, 35);
            this.lblLlamada.Name = "lblLlamada";
            this.lblLlamada.Size = new System.Drawing.Size(119, 26);
            this.lblLlamada.TabIndex = 8;
            this.lblLlamada.Text = "LLAMADA:";
            this.lblLlamada.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // FrEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.dgvEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblLlamada);
            this.Controls.Add(this.cboxObjeto);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cboxTablas);
            this.Name = "FrEliminar";
            this.Text = "FrEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminar)).EndInit();
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
    }
}