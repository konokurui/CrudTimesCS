using System;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;

namespace CrudTimesCS.controller
{
    class ManipulaJogadores
    {

        public void cadastroJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeJogadores", Jogadores.NomeJogadores);
                cmd.Parameters.AddWithValue("@FoneJogadores", Jogadores.FoneJogadores);
                cmd.Parameters.AddWithValue("@EmailJogadores", Jogadores.EmailJogadores);


                SqlParameter nv = cmd.Parameters.Add("@CodJogadores", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro efetuado com sucesso, deseja executar um novo cadastro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Jogadores.Retorno = "Sim";
                    return;
                }
                else
                {
                    Jogadores.Retorno = "Não";
                    return;
                }

            }
            catch (Exception)
            {
                
            }
        }

        public void pesquisarCodigoJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscaCodigoJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Jogadores.CodJogadores = Convert.ToInt32(arrayDados["CodJogadores"]);
                    Jogadores.NomeJogadores = arrayDados["NomeJogadores"].ToString();
                    Jogadores.FoneJogadores = arrayDados["FoneJogadores"].ToString();
                    Jogadores.EmailJogadores = arrayDados["EmailJogadores"].ToString();

                    Jogadores.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Jogadores.Retorno = "Não";
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Jogadores excluído com sucesso",
                    "Exclução", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("O Jogadores não pode ser excluído",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void alterarJogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodJogadores", Jogadores.CodJogadores);
                cmd.Parameters.AddWithValue("@NomeJogadores", Jogadores.NomeJogadores);
                cmd.Parameters.AddWithValue("@FoneJogadores", Jogadores.FoneJogadores);
                cmd.Parameters.AddWithValue("@EmailJogadores", Jogadores.EmailJogadores);


                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Jogadores alterado com sucesso", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception)
            {
                MessageBox.Show("O Jogadores não foi Alterado",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }







    }
}
