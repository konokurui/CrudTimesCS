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

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarTimes telaCadastrar = new TelaCadastrarTimes();
            telaCadastrar.ShowDialog();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarJogadores telaCadastrarJogadores = new TelaCadastrarJogadores();
            telaCadastrarJogadores.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
