namespace Atividade3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.rbtHomem = new System.Windows.Forms.RadioButton();
            this.rbtnMulher = new System.Windows.Forms.RadioButton();
            this.grp = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(30, 38);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 0;
            this.lblAltura.Text = "Altura";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(120, 31);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 1;
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(30, 112);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 13);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso Atual";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(120, 105);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 3;
            // 
            // rbtHomem
            // 
            this.rbtHomem.AutoSize = true;
            this.rbtHomem.Checked = true;
            this.rbtHomem.Location = new System.Drawing.Point(36, 19);
            this.rbtHomem.Name = "rbtHomem";
            this.rbtHomem.Size = new System.Drawing.Size(61, 17);
            this.rbtHomem.TabIndex = 4;
            this.rbtHomem.TabStop = true;
            this.rbtHomem.Text = "Homem";
            this.rbtHomem.UseVisualStyleBackColor = true;
            // 
            // rbtnMulher
            // 
            this.rbtnMulher.AutoSize = true;
            this.rbtnMulher.Location = new System.Drawing.Point(36, 51);
            this.rbtnMulher.Name = "rbtnMulher";
            this.rbtnMulher.Size = new System.Drawing.Size(57, 17);
            this.rbtnMulher.TabIndex = 5;
            this.rbtnMulher.TabStop = true;
            this.rbtnMulher.Text = "Mulher";
            this.rbtnMulher.UseVisualStyleBackColor = true;
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rbtHomem);
            this.grp.Controls.Add(this.rbtnMulher);
            this.grp.Location = new System.Drawing.Point(293, 31);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(123, 94);
            this.grp.TabIndex = 6;
            this.grp.TabStop = false;
            this.grp.Text = "Sexo";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(120, 167);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 228);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.RadioButton rbtHomem;
        private System.Windows.Forms.RadioButton rbtnMulher;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.Button btnCalcular;
    }
}

