using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudTimesCS.controller
{
    class ConexaoBD
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diogo.rgomes1\source\repos\CrudTimesCS\CrudTimesCS\BDTimeCS.mdf;Integrated Security=True";
        }
    }
}
