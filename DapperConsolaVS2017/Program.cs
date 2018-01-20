using Dapper;
using DapperConsolaVS2017.Modelo.HumanResources;
using DapperConsolaVS2017.Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsolaVS2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDepartamentos = 0;

            try
            {
                AdventureWorksGestor gestor = new AdventureWorksGestor();
                List<Department> departamentosRRHH = gestor.GetRRHHDeparments();
                if (departamentosRRHH != null)
                {
                    numeroDepartamentos = departamentosRRHH.Count();
                }
            }
            catch (Exception e)
            {
            }
            
            if (numeroDepartamentos != 16)
            {
                Console.WriteLine("Obtenidos " + numeroDepartamentos + " departamentos");
            }
            else if (numeroDepartamentos == 16)
            {
                Console.WriteLine("Obtenidos " + numeroDepartamentos + " departamentos");
            }
            else
            {
                Console.WriteLine("No se han obtenido departamentos");
            }
        }

        
    }
}
