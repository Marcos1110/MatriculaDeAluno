namespace MatriculaDeAluno
{
    partial class frmMatriculaDeAluno
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnoDeNascimento = new System.Windows.Forms.TextBox();
            this.txtAnoDoUltimoAniversario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(314, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Ano de Nascimento:";
            // 
            // txtAnoDeNascimento
            // 
            this.txtAnoDeNascimento.Location = new System.Drawing.Point(120, 40);
            this.txtAnoDeNascimento.Name = "txtAnoDeNascimento";
            this.txtAnoDeNascimento.Size = new System.Drawing.Size(52, 20);
            this.txtAnoDeNascimento.TabIndex = 3;
            this.txtAnoDeNascimento.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoDoUltimoAniversario_Validating);
            // 
            // txtAnoDoUltimoAniversario
            // 
            this.txtAnoDoUltimoAniversario.Location = new System.Drawing.Point(312, 40);
            this.txtAnoDoUltimoAniversario.Name = "txtAnoDoUltimoAniversario";
            this.txtAnoDoUltimoAniversario.Size = new System.Drawing.Size(59, 20);
            this.txtAnoDoUltimoAniversario.TabIndex = 5;
            this.txtAnoDoUltimoAniversario.Enter += new System.EventHandler(this.txtAnoDoUltimoAniversario_Enter);
            this.txtAnoDoUltimoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoDoUltimoAniversario_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "An&o do último aniversário:";
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(12, 69);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(128, 23);
            this.btnIdentificarCategoria.TabIndex = 6;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoria.Location = new System.Drawing.Point(211, 76);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(146, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMatriculaDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 104);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtAnoDoUltimoAniversario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnoDeNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMatriculaDeAluno";
            this.Text = "Matrícula de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnoDeNascimento;
        private System.Windows.Forms.TextBox txtAnoDoUltimoAniversario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoria;
    }
}