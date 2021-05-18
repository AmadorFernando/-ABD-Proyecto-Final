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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.cboxTablas = new System.Windows.Forms.ComboBox();
            this.btnTabla = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            this.panelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.Controls.Add(this.btnMostrar);
            this.panelIzquierdo.Controls.Add(this.cboxTablas);
            this.panelIzquierdo.Controls.Add(this.btnTabla);
            this.panelIzquierdo.Controls.Add(this.btnRegistros);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(383, 302);
            this.panelIzquierdo.TabIndex = 0;
            // 
            // cboxTablas
            // 
            this.cboxTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTablas.FormattingEnabled = true;
            this.cboxTablas.Location = new System.Drawing.Point(212, 46);
            this.cboxTablas.Name = "cboxTablas";
            this.cboxTablas.Size = new System.Drawing.Size(139, 21);
            this.cboxTablas.TabIndex = 2;
            this.cboxTablas.SelectionChangeCommitted += new System.EventHandler(this.cboxTablas_SelectionChangeCommitted);
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(41, 87);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(131, 46);
            this.btnTabla.TabIndex = 1;
            this.btnTabla.Text = "TABLA";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.Location = new System.Drawing.Point(41, 30);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(131, 51);
            this.btnRegistros.TabIndex = 0;
            this.btnRegistros.Text = "REGISTROS";
            this.btnRegistros.UseVisualStyleBackColor = true;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // panelDerecho
            // 
            this.panelDerecho.Controls.Add(this.dataGridView1);
            this.panelDerecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDerecho.Location = new System.Drawing.Point(400, 0);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(400, 302);
            this.panelDerecho.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(376, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(41, 30);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(131, 51);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Visible = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.Name = "FrEliminar";
            this.Text = "FrEliminar";
            this.Load += new System.EventHandler(this.FrEliminar_Load);
            this.panelIzquierdo.ResumeLayout(false);
            this.panelDerecho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboxTablas;
        private System.Windows.Forms.Button btnMostrar;
    }
}