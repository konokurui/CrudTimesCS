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
    public partial class TelaCadastrarTimes : Form
    {
        public TelaCadastrarTimes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbxNomeTimes.Text == "" || tbxFraseTimes.Text == "")
            {
                MessageBox.Show("fala algo ai", "atençapo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            time.NomeTimes = tbxNomeTimes.Text;
            time.FraseTimes = tbxFraseTimes.Text;
            time.LogoTimes = "C:/";


            ManipulaTimes manipulaTimes = new ManipulaTimes();
            manipulaTimes.cadastrotimes();

            if (time.Retorno == "sim")
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar ==27)
            {
                limparTela();
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
