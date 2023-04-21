using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System;

namespace DataAccess.Repositories
{
    public class MembresiaRepository : Repository, IMembresiaRepository
    {
        //Comandos basicos
        readonly string createCommand = "SP_CREATE_MEMBRESIA";
        readonly string updateCommand = "SP_UPDATE_MEMBRESIA";
        readonly string deleteCommand = "SP_DELETE_MEMBRESIA";
        readonly string getAllCommand = "SP_GET_MEMBRESIAS";

        public async Task Create(Membresia membresia)
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = createCommand;
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = membresia.Nombre;
                    command.Parameters.Add("@costo", SqlDbType.Decimal).Value = membresia.Costo;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Update(Membresia membresia)
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = updateCommand;
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros
                    command.Parameters.Add("@membresiaId", SqlDbType.SmallInt).Value = membresia.MembresiaId;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = membresia.Nombre;
                    command.Parameters.Add("@costo", SqlDbType.Decimal).Value = membresia.Costo;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Delete(int membresiaId)
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = deleteCommand;
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros
                    command.Parameters.Add("@membresiaId", SqlDbType.SmallInt).Value = membresiaId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task<IEnumerable<Membresia>> GetAll()
        {
            //Lista a llenar
            List<Membresia> lst = new List<Membresia>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = getAllCommand;
                    command.CommandType = CommandType.StoredProcedure;

                    //Abrir conexion
                    connection.Open();

                    //Ejecutar lector
                    var reader = await command.ExecuteReaderAsync();

                    //Si hay filas
                    if (reader.HasRows)
                    {
                        //Llenar la lista
                        while (reader.Read())
                        {
                            lst.Add(new Membresia
                            {
                                MembresiaId = reader.GetInt16(0),
                                Nombre = reader.GetString(1),
                                Costo = reader.GetDecimal(2),
                                CreatedAt = reader.GetDateTime(3),
                                UpdatedAt = reader.GetDateTime(4)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public IEnumerable<Membresia> GetMembresiasOnComboBox()
        {
            //Lista a llenar
            List<Membresia> lst = new List<Membresia>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    const string commandText = "select MembresiaId, Nombre from Membresia order by MembresiaId asc";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    //Abrir conexion
                    connection.Open();

                    //Ejecutar lector
                    var reader = command.ExecuteReader();

                    //Si hay filas
                    if (reader.HasRows)
                    {
                        //Llenar la lista
                        while (reader.Read())
                        {
                            lst.Add(new Membresia
                            {
                                MembresiaId = reader.GetInt16(0),
                                Nombre = reader.GetString(1),
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public async Task<decimal> GetCostoMembresiaById(short membresiaId)
        {
            //Costo membresia
            decimal costoMembresia = 0;

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "select Costo from Membresia where MembresiaId = @MembresiaId";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    //Parametros
                    command.Parameters.Add("@membresiaId", SqlDbType.SmallInt).Value = membresiaId;

                    //Ejecutar comando 
                    connection.Open();

                    //Como solo es necesario traer un dato, usar ExecuteScalar es lo mas optimo
                    costoMembresia = Convert.ToDecimal(await command.ExecuteScalarAsync());

                    connection.Close();
                }
            }
            return costoMembresia;
        }
    }
}