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
using System.IO;

namespace CrudTimesCS.view
{
    public partial class TelaCadastrarJogadores : Form
    {
        public TelaCadastrarJogadores()
        {
            InitializeComponent();
        }

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
            }
            else
            {
                fecharCadastro();
                return;
            }
       
        
        }


        public void abrirCadastro()
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
    }
}
