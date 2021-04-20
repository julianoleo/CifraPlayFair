namespace CifraPlayFair
{
    partial class Form_CifraPlayFair
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
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTextoOriginal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextoCriptografado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTextoDecriptografado = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.btnDecriptografar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(12, 22);
            this.txtChave.Multiline = true;
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(282, 20);
            this.txtChave.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto Original";
            // 
            // txtTextoOriginal
            // 
            this.txtTextoOriginal.Location = new System.Drawing.Point(12, 65);
            this.txtTextoOriginal.Multiline = true;
            this.txtTextoOriginal.Name = "txtTextoOriginal";
            this.txtTextoOriginal.Size = new System.Drawing.Size(282, 81);
            this.txtTextoOriginal.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Texto Criptografado";
            // 
            // txtTextoCriptografado
            // 
            this.txtTextoCriptografado.Location = new System.Drawing.Point(12, 165);
            this.txtTextoCriptografado.Multiline = true;
            this.txtTextoCriptografado.Name = "txtTextoCriptografado";
            this.txtTextoCriptografado.Size = new System.Drawing.Size(282, 81);
            this.txtTextoCriptografado.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Texto Decriptografado";
            // 
            // txtTextoDecriptografado
            // 
            this.txtTextoDecriptografado.Location = new System.Drawing.Point(12, 266);
            this.txtTextoDecriptografado.Multiline = true;
            this.txtTextoDecriptografado.Name = "txtTextoDecriptografado";
            this.txtTextoDecriptografado.Size = new System.Drawing.Size(282, 81);
            this.txtTextoDecriptografado.TabIndex = 6;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(109, 353);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(89, 23);
            this.btnCriptografar.TabIndex = 8;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // btnDecriptografar
            // 
            this.btnDecriptografar.Location = new System.Drawing.Point(204, 353);
            this.btnDecriptografar.Name = "btnDecriptografar";
            this.btnDecriptografar.Size = new System.Drawing.Size(89, 23);
            this.btnDecriptografar.TabIndex = 9;
            this.btnDecriptografar.Text = "Decriptografar";
            this.btnDecriptografar.UseVisualStyleBackColor = true;
            this.btnDecriptografar.Click += new System.EventHandler(this.btnDecriptografar_Click);
            // 
            // Form_CifraPlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 383);
            this.Controls.Add(this.btnDecriptografar);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTextoDecriptografado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextoCriptografado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTextoOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_CifraPlayFair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cifra Play Fair - IFTM 2021";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTextoOriginal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextoCriptografado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTextoDecriptografado;
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.Button btnDecriptografar;
    }
}

