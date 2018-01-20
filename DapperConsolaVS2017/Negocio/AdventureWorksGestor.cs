using Dapper;
using DapperConsolaVS2017.Modelo.HumanResources;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsolaVS2017.Negocio
{
    internal class AdventureWorksGestor
    {
        internal List<Department> GetRRHHDeparments()
        {
            List<Department> departamentosRRHH = new List<Department>();

            // Obtenemos cadena de conexión
            string cadenaConexionBD = Parametros.CadenaConexionBD;
            using (SqlConnection conexionBD = new SqlConnection(cadenaConexionBD))
            {
                if (conexionBD.State == System.Data.ConnectionState.Closed)
                {
                    conexionBD.Open();
                }

                // Consulta
                var departamentosRRHH_BD = conexionBD.Query(Consultas.HumanResources_Department_Select);
                if (departamentosRRHH_BD.Any())
                {
                    foreach (var departamentoRRHH_BD in departamentosRRHH_BD)
                    {
                        Department departamentoRRHH = new Department()
                        {
                            DepartmentID = departamentoRRHH_BD.DepartmentID,
                            GroupName = departamentoRRHH_BD.GroupName,
                            ModifiedDate = departamentoRRHH_BD.ModifiedDate,
                            Name = departamentoRRHH_BD.Name,
                        };

                        departamentosRRHH.Add(departamentoRRHH);
                    }
                }


                return departamentosRRHH;
            }
        }
    }
}
