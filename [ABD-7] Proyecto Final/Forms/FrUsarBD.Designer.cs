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
            this.SuspendLayout();
            // 
            // cboxBD
            // 
            this.cboxBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBD.FormattingEnabled = true;
            this.cboxBD.Location = new System.Drawing.Point(24, 38);
            this.cboxBD.Name = "cboxBD";
            this.cboxBD.Size = new System.Drawing.Size(295, 21);
            this.cboxBD.TabIndex = 0;
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(24, 97);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(129, 49);
            this.btnUsar.TabIndex = 1;
            this.btnUsar.Text = "USAR";
            this.btnUsar.UseVisualStyleBackColor = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 53);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciona la Base de Datos que usaras";
            // 
            // FrUsarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.cboxBD);
            this.Name = "FrUsarBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrUsarBD";
            this.Load += new System.EventHandler(this.FrUsarBD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBD;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}