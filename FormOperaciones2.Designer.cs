namespace Laboratorio1_Windows_Ticona
{
    partial class FormOperaciones2
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(332, 155);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 37;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(332, 109);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 36;
            this.btnCalcula.Text = "Calcular";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado.Location = new System.Drawing.Point(107, 195);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Resultado";
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumero2.Location = new System.Drawing.Point(107, 154);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 33;
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumero1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumero1.Location = new System.Drawing.Point(107, 106);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 31;
            this.label3.Tag = "";
            this.label3.Text = "Numero 2 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Numero 1 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(138, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "SUMA DE NUMEROS";
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(231, 109);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(52, 17);
            this.rbtnSuma.TabIndex = 38;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "Suma";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            this.rbtnSuma.CheckedChanged += new System.EventHandler(this.rbtnSuma_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(231, 132);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(53, 17);
            this.rbtnResta.TabIndex = 39;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta";
            this.rbtnResta.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplicacion
            // 
            this.rbtnMultiplicacion.AutoSize = true;
            this.rbtnMultiplicacion.Location = new System.Drawing.Point(231, 155);
            this.rbtnMultiplicacion.Name = "rbtnMultiplicacion";
            this.rbtnMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rbtnMultiplicacion.TabIndex = 40;
            this.rbtnMultiplicacion.TabStop = true;
            this.rbtnMultiplicacion.Text = "Multiplicacion";
            this.rbtnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(231, 178);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivision.TabIndex = 41;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            // 
            // FormOperaciones2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 266);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplicacion);
            this.Controls.Add(this.rbtnResta);
            this.Controls.Add(this.rbtnSuma);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOperaciones2";
            this.Text = "FormOperaciones2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rbtnDivision;
    }
}