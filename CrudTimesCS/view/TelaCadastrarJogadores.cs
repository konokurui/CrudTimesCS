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

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarJogadores : Form
    {
        public TelaCadastrarJogadores()
        {
            InitializeComponent();
        }

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

            }
            else
            {
                fecharCadastro();
            }

        }

        public void abrircadastro()
        {
            this.ShowDialog();
        }

        public void fecharCadastro()
        {
            this.Close();
        }


        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {

                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;

                }

            }



        }

        private void TelaCadastrarJogadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
