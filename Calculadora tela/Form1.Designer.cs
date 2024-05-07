namespace Calculadora_tela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroUm = new System.Windows.Forms.TextBox();
            this.numeroDois = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 44F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora \r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número : \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numeroUm
            // 
            this.numeroUm.Location = new System.Drawing.Point(394, 211);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(188, 20);
            this.numeroUm.TabIndex = 3;
            this.numeroUm.TextChanged += new System.EventHandler(this.numeroUm_TextChanged);
            // 
            // numeroDois
            // 
            this.numeroDois.Location = new System.Drawing.Point(396, 259);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(186, 20);
            this.numeroDois.TabIndex = 4;
            this.numeroDois.TextChanged += new System.EventHandler(this.numeroDois_TextChanged);
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(299, 314);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(75, 23);
            this.somar.TabIndex = 5;
            this.somar.Text = "Somar\r\n";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.somar_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(452, 361);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(75, 23);
            this.multiplicar.TabIndex = 6;
            this.multiplicar.Text = "Multiplicar";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(299, 361);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(75, 23);
            this.dividir.TabIndex = 7;
            this.dividir.Text = "Dividir ";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // subtrair
            // 
            this.subtrair.Location = new System.Drawing.Point(452, 314);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(75, 23);
            this.subtrair.TabIndex = 8;
            this.subtrair.Text = "Subtrair";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // limpar
            // 
            this.limpar.Location = new System.Drawing.Point(374, 402);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(75, 23);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(630, 236);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(100, 20);
            this.resultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AccessibleDescription = "Software destinado a calculos basicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroUm;
        private System.Windows.Forms.TextBox numeroDois;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox resultado;
    }
}

