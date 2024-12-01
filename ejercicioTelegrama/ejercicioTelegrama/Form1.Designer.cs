namespace ejercicioTelegrama
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtnOrdinario = new System.Windows.Forms.RadioButton();
            this.rbtnUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(143, 351);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(66, 129);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(383, 106);
            this.txtTelegrama.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(396, 315);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 68);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtnOrdinario
            // 
            this.rbtnOrdinario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbtnOrdinario.Location = new System.Drawing.Point(40, 300);
            this.rbtnOrdinario.Name = "rbtnOrdinario";
            this.rbtnOrdinario.Size = new System.Drawing.Size(85, 17);
            this.rbtnOrdinario.TabIndex = 0;
            this.rbtnOrdinario.TabStop = true;
            this.rbtnOrdinario.Text = "Ordinario";
            this.rbtnOrdinario.UseVisualStyleBackColor = true;
            this.rbtnOrdinario.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnUrgente
            // 
            this.rbtnUrgente.AutoSize = true;
            this.rbtnUrgente.Location = new System.Drawing.Point(158, 300);
            this.rbtnUrgente.Name = "rbtnUrgente";
            this.rbtnUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbtnUrgente.TabIndex = 7;
            this.rbtnUrgente.TabStop = true;
            this.rbtnUrgente.Text = "Urgente";
            this.rbtnUrgente.UseVisualStyleBackColor = true;
            this.rbtnUrgente.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.rbtnUrgente);
            this.Controls.Add(this.rbtnOrdinario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtnOrdinario;
        private System.Windows.Forms.RadioButton rbtnUrgente;
    }
}

