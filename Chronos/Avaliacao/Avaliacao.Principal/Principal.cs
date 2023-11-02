using Chronos.Avaliacao.Avaliacao.Agendamento;
using Chronos.Avaliacao.Avaliacao.Cadastros;
using Chronos.Avaliacao.Avaliacao.Processos;

namespace Chronos.Avaliacao.Avaliacao.Principal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            login frm = new login();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmClientes>();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmUsuario>();
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmExercicio>();
        }

        private void agendamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmAgendamento>();
        }

        private void avaliaçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmAgendaentoDoDia>();
        }

        private void treinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmPlanoDeTreino>();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Deseja Realmente sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm == DialogResult.Yes)
            {
                Dispose();
                Application.Exit();

            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Deseja realmente fechar o sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void agendamentosDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmAgendaentoDoDia>();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmRelatorioCliente>();
        }
    }
}
