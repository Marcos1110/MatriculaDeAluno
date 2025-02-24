using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaDeAlunoV2
{
    public partial class frmMatriculaDeAlunoV2 : Form
    {
        public frmMatriculaDeAlunoV2()
        {
            InitializeComponent();

            lblDataDeHoje.Text = "Hoje é " + DateTime.Now.ToShortDateString();
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (nome == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados",
                    "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan tsQuantidadeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;
                int idade = (tsQuantidadeDias.Days / 365);
                if (idade > 17)
                {
                    lblCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblCategoria.Text = "Infatil B";
                }
                else if (idade >= 5)
                {
                    lblCategoria.Text = "Infantil A";
                }
                else
                {
                    lblCategoria.Text = "Não existe categoria";
                }
            }
        }

        private void dtpDataDeNascimento_Validating(object sender, CancelEventArgs e)
        {
            if(dtpDataDeNascimento.Value >= DateTime.Today)
            {
                MessageBox.Show("A DATA DE NASCIMENTO deve" +
                   " ser ANTERIOR a DATA ATUAL", "Atenção!!",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
