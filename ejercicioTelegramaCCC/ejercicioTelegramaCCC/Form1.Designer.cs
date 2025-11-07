namespace ejercicioTelegramaCCC
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOrdinario = new System.Windows.Forms.RadioButton();
            this.rdbUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(143, 363);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Coste:";
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(504, 363);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(111, 32);
            this.btnCalcularPrecio.TabIndex = 9;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(75, 91);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(654, 203);
            this.txtTelegrama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto";
            // 
            // rdbOrdinario
            // 
            this.rdbOrdinario.AutoSize = true;
            this.rdbOrdinario.Location = new System.Drawing.Point(75, 321);
            this.rdbOrdinario.Name = "rdbOrdinario";
            this.rdbOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rdbOrdinario.TabIndex = 12;
            this.rdbOrdinario.TabStop = true;
            this.rdbOrdinario.Text = "Ordinario";
            this.rdbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rdbUrgente
            // 
            this.rdbUrgente.AutoSize = true;
            this.rdbUrgente.Location = new System.Drawing.Point(167, 321);
            this.rdbUrgente.Name = "rdbUrgente";
            this.rdbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rdbUrgente.TabIndex = 13;
            this.rdbUrgente.TabStop = true;
            this.rdbUrgente.Text = "Urgente";
            this.rdbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdbUrgente);
            this.Controls.Add(this.rdbOrdinario);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbOrdinario;
        private System.Windows.Forms.RadioButton rdbUrgente;
    }
}

