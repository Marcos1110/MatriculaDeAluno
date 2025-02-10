using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAluno
{
    public partial class frmMatriculaDeAluno : Form
    {
        public frmMatriculaDeAluno()
        {
            InitializeComponent();
        }

        private void txtAnoDoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            string anoDeNasciento = txtAnoDeNascimento.Text;

            if (anoDeNasciento.Trim().Length < 4) {
                MessageBox.Show("É preciso informar o ANO DE NASCIMENTO" +
                    " com 4 dígitos", "Atenção!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtAnoDeNascimento.Focus();
            }
        }

        private void txtAnoDoUltimoAniversario_Validating(object sender, CancelEventArgs e)
        {
            int anoDoUltimoAniversario = 
                Convert.ToInt32(txtAnoDoUltimoAniversario.Text);
            int anoDeNascimento = Convert.ToInt32(txtAnoDeNascimento.Text);

            if (txtAnoDoUltimoAniversario.Text != String.Empty &&
                anoDoUltimoAniversario <= anoDeNascimento) {
                MessageBox.Show("O ANO DO ÚLTIMO ANIVERSÁRIO deve" +
                    " ser superior ao ANO DE NASCIMENTO", "Atenção!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string anoDeNascimento = txtAnoDeNascimento.Text;
            string anoDoUltimoAniversario = txtAnoDoUltimoAniversario.Text;

            if (nome == String.Empty || anoDeNascimento == String.Empty
                || anoDoUltimoAniversario == String.Empty) {
                MessageBox.Show("Todos os dados solicitados devem ser informados",
                    "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else { 
                int idade = Convert.ToInt32(anoDoUltimoAniversario) -
                    Convert.ToInt32(anoDeNascimento);
                if (idade > 17) {
                    lblCategoria.Text = "Adulto";
                } else if (idade > 13) {
                    lblCategoria.Text = "Juvenil B";
                } else if (idade > 10) {
                    lblCategoria.Text = "Juvenil A";
                } else if (idade > 7) {
                    lblCategoria.Text = "Infatil B";
                } else if (idade >= 5) {
                    lblCategoria.Text = "Infantil A";
                } else {
                    lblCategoria.Text = "Não existe categoria";
                }
            }
        }
    }
}
