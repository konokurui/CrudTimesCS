using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudTimesCS.model;
using CrudTimesCS.controller;
<<<<<<< HEAD
using System.IO;
=======
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarJogadores : Form
    {
        public TelaCadastrarJogadores()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void btnJogadores_Click(object sender, EventArgs e)
        {
            if (tbxNomeJogadores.Text == "" || tbxFoneJogadores.Text == "" || tbxEmailJogadores.Text == "") 
            {
                MessageBox.Show("Digite Todas as informações", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Jogadores.NomeJogadores = tbxNomeJogadores.Text;
            Jogadores.FoneJogadores = tbxFoneJogadores.Text;
            Jogadores.EmailJogadores = tbxEmailJogadores.Text;



            ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
            manipulaJogadores.cadastroJogadores();

            if (Jogadores.Retorno == "Sim")
            {
                limparTela();
                return;
=======
        private void TelaCadastrarJogadores_Load(object sender, EventArgs e)
        {

        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {

            if (tbxNomeJogadores.Text == "" || tbxEmailJogadores.Text == "")
            {
                MessageBox.Show("fala algo ai", "atençapo", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }


            jogadores.NomeJogadores = tbxNomeJogadores.Text;
            jogadores.EmailJogadores = tbxEmailJogadores.Text;
            jogadores.FoneJogadores = tbxFoneJogadores.Text;


            ManipulaJogadores manipulaJogadores = new ManipulaJogadores();
            manipulaJogadores.cadastrojogadores();


            if (jogadores.Retorno == "sim")
            {
                tbxNomeJogadores.Text = string.Empty;
                tbxEmailJogadores.Text = string.Empty;
                tbxFoneJogadores.Text = string.Empty;

>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
            }
            else
            {
                fecharCadastro();
<<<<<<< HEAD
                return;
            }
       
        
        }


        public void abrirCadastro()
        {
            this.ShowDialog();
        }
=======
            }

        }

        public void abrircadastro()
        {
            this.ShowDialog();
        }

>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
        public void fecharCadastro()
        {
            this.Close();
        }

<<<<<<< HEAD
        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
=======
        private void TelaCadastrarJogadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();
>>>>>>> 52afeed9674513930bbcee5945d6c21a38b123c2
            }
        }
    }
}
