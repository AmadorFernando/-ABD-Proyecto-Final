namespace _ABD_7__Proyecto_Final
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelIzq = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelAbajo = new System.Windows.Forms.Panel();
            this.btnUsar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtComandos = new System.Windows.Forms.TextBox();
            this.panelIzq.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIzq
            // 
            this.panelIzq.Controls.Add(this.txtComandos);
            this.panelIzq.Controls.Add(this.treeView1);
            this.panelIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzq.Location = new System.Drawing.Point(0, 0);
            this.panelIzq.Name = "panelIzq";
            this.panelIzq.Size = new System.Drawing.Size(200, 450);
            this.panelIzq.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 320);
            this.treeView1.TabIndex = 0;
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.btnCrear);
            this.panelCentral.Controls.Add(this.btnModificar);
            this.panelCentral.Controls.Add(this.btnInsertar);
            this.panelCentral.Controls.Add(this.btnEliminar);
            this.panelCentral.Controls.Add(this.btnUsar);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(200, 0);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(600, 450);
            this.panelCentral.TabIndex = 1;
            // 
            // panelAbajo
            // 
            this.panelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAbajo.Location = new System.Drawing.Point(200, 296);
            this.panelAbajo.Name = "panelAbajo";
            this.panelAbajo.Size = new System.Drawing.Size(600, 154);
            this.panelAbajo.TabIndex = 2;
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(38, 12);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(103, 38);
            this.btnUsar.TabIndex = 0;
            this.btnUsar.Text = "USAR";
            this.btnUsar.UseVisualStyleBackColor = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(38, 56);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 38);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(187, 56);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(103, 38);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "INSERTAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(187, 13);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(334, 14);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 37);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // txtComandos
            // 
            this.txtComandos.Location = new System.Drawing.Point(13, 340);
            this.txtComandos.Multiline = true;
            this.txtComandos.Name = "txtComandos";
            this.txtComandos.ReadOnly = true;
            this.txtComandos.Size = new System.Drawing.Size(181, 98);
            this.txtComandos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAbajo);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelIzq.ResumeLayout(false);
            this.panelIzq.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIzq;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelAbajo;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtComandos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnUsar;
    }
}

