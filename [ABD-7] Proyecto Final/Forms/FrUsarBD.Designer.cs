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
            this.SuspendLayout();
            // 
            // cboxBD
            // 
            this.cboxBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBD.FormattingEnabled = true;
            this.cboxBD.Location = new System.Drawing.Point(246, 48);
            this.cboxBD.Name = "cboxBD";
            this.cboxBD.Size = new System.Drawing.Size(221, 21);
            this.cboxBD.TabIndex = 0;
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(172, 107);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(129, 49);
            this.btnUsar.TabIndex = 1;
            this.btnUsar.Text = "USAR";
            this.btnUsar.UseVisualStyleBackColor = true;
            this.btnUsar.Click += new System.EventHandler(this.btnUsar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(426, 103);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 53);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrUsarBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 213);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.cboxBD);
            this.Name = "FrUsarBD";
            this.Text = "FrUsarBD";
            this.Load += new System.EventHandler(this.FrUsarBD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxBD;
        private System.Windows.Forms.Button btnUsar;
        private System.Windows.Forms.Button btnCancelar;
    }
}