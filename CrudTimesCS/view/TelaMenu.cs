using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudTimesCS.view
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastrarTimes telaCadastrar = new TelaCadastrarTimes();
            telaCadastrar.ShowDialog();
=======
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarTimes telaCadastrar = new TelaCadastrarTimes();
            telaCadastrar.ShowDialog();

>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            TelaCadastrarJogadores telaCadastrar = new TelaCadastrarJogadores();
            telaCadastrar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarTime telaPesquisarTime = new TelaPesquisarTime();
            telaPesquisarTime.ShowDialog();
        }

        private void pesquisasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TelaPesquisarTime telaPesquisarTime = new TelaPesquisarTime();
            telaPesquisarTime.ShowDialog();


        }
=======
            TelaCadastrarJogadores telaCadastrarJogadores = new TelaCadastrarJogadores();
            telaCadastrarJogadores.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
    }
}
