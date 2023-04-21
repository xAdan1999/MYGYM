using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using System.Data;

namespace DataAccess.Repositories
{
    public class DashboardRepository : Repository, IDashboard
    {
        public async Task<List<int>> GetTotales()
        {
            //Lista a llenar
            List<int> lst = new List<int>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_GET_TOTALES";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.StoredProcedure;

                    //Ejecutar lector
                    connection.Open();

                    //Ejecutar lector
                    var reader = await command.ExecuteReaderAsync();

                    //Si hay filas
                    if (reader.HasRows)
                    {
                        //Llenar la lista
                        while (reader.Read())
                        {
                            lst.Add(reader.GetInt32(0));
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }
    }
}
