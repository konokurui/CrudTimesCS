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
    class ManipulaTimes
    {
        public void cadastrotimes()
        {
            SqlConnection cn = new SqlConnection(ConexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pInserirTimes",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {

                cmd.Parameters.AddWithValue("@NomeTimes", time.NomeTimes);
                cmd.Parameters.AddWithValue("@LogoTimes", time.LogoTimes);
                cmd.Parameters.AddWithValue("@FraseTimes", time.FraseTimes);

                SqlParameter nv = cmd.Parameters.Add("@CodTimes", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

              cn.Open();
              cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("MAEEEEEEEEEEEEAAAA CADASTRO FEITO quer fazer dnv é?","atençao ze ruela",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {

                    time.Retorno = "sim";
                    return;

                }
                else
                {
                    time.Retorno = "nao";
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
