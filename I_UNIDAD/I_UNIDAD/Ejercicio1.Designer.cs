namespace I_UNIDAD
{
    partial class Ejercicio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Numero1 = new System.Windows.Forms.TextBox();
            this.Txt_Numero2 = new System.Windows.Forms.TextBox();
            this.Btn_Sumar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NUMERO 2";
            // 
            // Txt_Numero1
            // 
            this.Txt_Numero1.Location = new System.Drawing.Point(133, 22);
            this.Txt_Numero1.Name = "Txt_Numero1";
            this.Txt_Numero1.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero1.TabIndex = 2;
            // 
            // Txt_Numero2
            // 
            this.Txt_Numero2.Location = new System.Drawing.Point(133, 60);
            this.Txt_Numero2.Name = "Txt_Numero2";
            this.Txt_Numero2.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero2.TabIndex = 3;
            // 
            // Btn_Sumar
            // 
            this.Btn_Sumar.Location = new System.Drawing.Point(133, 106);
            this.Btn_Sumar.Name = "Btn_Sumar";
            this.Btn_Sumar.Size = new System.Drawing.Size(100, 23);
            this.Btn_Sumar.TabIndex = 4;
            this.Btn_Sumar.Text = "SUMAR";
            this.Btn_Sumar.UseVisualStyleBackColor = true;
            this.Btn_Sumar.Click += new System.EventHandler(this.Btn_Sumar_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Sumar);
            this.Controls.Add(this.Txt_Numero2);
            this.Controls.Add(this.Txt_Numero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Numero1;
        private System.Windows.Forms.TextBox Txt_Numero2;
        private System.Windows.Forms.Button Btn_Sumar;
    }
}

