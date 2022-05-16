using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CrudTimesCS.model;
using System.Windows.Forms;
using CrudTimesCS.view;


namespace CrudTimesCS.controller
{
    class ManipulaJogadores
    {

        public void cadastrojogadores()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirJogadores", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@NomeJogadores", jogadores.NomeJogadores);
                cmd.Parameters.AddWithValue("@EmailJogadores", jogadores.EmailJogadores);
                cmd.Parameters.AddWithValue("@FoneJogadores", jogadores.FoneJogadores);

                SqlParameter nv = cmd.Parameters.Add("@CodJogadores", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("MAEEEEAAAA CADASTRO FEITO quer fazer dnv é?", "atençao ze ruela", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {

                    jogadores.Retorno = "sim";
                    return;

                }
                else
                {
                    jogadores.Retorno = "nao";
                    return;
                }




            }
            catch(Exception)
            {
                throw;
            }



        }
    }
}
