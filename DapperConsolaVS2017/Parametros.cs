using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsolaVS2017
{
    internal static class Parametros
    {
        internal static string CadenaConexionBD = ConfigurationManager.ConnectionStrings["AdventureWorks2012"].ConnectionString;
    }
}
