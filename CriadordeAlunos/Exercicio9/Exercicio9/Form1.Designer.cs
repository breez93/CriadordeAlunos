namespace Exercicio9
{
    partial class Form1
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
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BCriarAluno = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbCurso = new System.Windows.Forms.TextBox();
            this.TbIdade = new System.Windows.Forms.TextBox();
            this.TbAno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RBCaracteristicas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(191, 71);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(126, 20);
            this.TbNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // BCriarAluno
            // 
            this.BCriarAluno.Location = new System.Drawing.Point(191, 178);
            this.BCriarAluno.Name = "BCriarAluno";
            this.BCriarAluno.Size = new System.Drawing.Size(126, 23);
            this.BCriarAluno.TabIndex = 2;
            this.BCriarAluno.Text = "Criar Aluno";
            this.BCriarAluno.UseVisualStyleBackColor = true;
            this.BCriarAluno.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ano";
            // 
            // TbCurso
            // 
            this.TbCurso.Location = new System.Drawing.Point(191, 126);
            this.TbCurso.Name = "TbCurso";
            this.TbCurso.Size = new System.Drawing.Size(126, 20);
            this.TbCurso.TabIndex = 6;
            // 
            // TbIdade
            // 
            this.TbIdade.Location = new System.Drawing.Point(191, 100);
            this.TbIdade.Name = "TbIdade";
            this.TbIdade.Size = new System.Drawing.Size(126, 20);
            this.TbIdade.TabIndex = 7;
            // 
            // TbAno
            // 
            this.TbAno.Location = new System.Drawing.Point(191, 152);
            this.TbAno.Name = "TbAno";
            this.TbAno.Size = new System.Drawing.Size(126, 20);
            this.TbAno.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Características";
            // 
            // RBCaracteristicas
            // 
            this.RBCaracteristicas.Location = new System.Drawing.Point(337, 25);
            this.RBCaracteristicas.Name = "RBCaracteristicas";
            this.RBCaracteristicas.Size = new System.Drawing.Size(283, 176);
            this.RBCaracteristicas.TabIndex = 10;
            this.RBCaracteristicas.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 258);
            this.Controls.Add(this.RBCaracteristicas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbAno);
            this.Controls.Add(this.TbIdade);
            this.Controls.Add(this.TbCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BCriarAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNome);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCriarAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbCurso;
        private System.Windows.Forms.TextBox TbIdade;
        private System.Windows.Forms.TextBox TbAno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox RBCaracteristicas;
    }
}

