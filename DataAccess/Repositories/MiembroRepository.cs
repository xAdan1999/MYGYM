using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;

namespace DataAccess.Repositories
{
    public class MiembroRepository : Repository, IMiembroRepository
    {
        //Comandos basicos
        readonly string createCommand = "SP_CREATE_MIEMBRO";
        readonly string updateCommand = "SP_UPDATE_MIEMBRO";
        readonly string deleteCommand = "SP_DELETE_MIEMBRO";
        readonly string getAllCommand = "SP_GET_MIEMBROS";

        public async Task Create(Miembro miembro)
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
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = miembro.Nombre;
                    command.Parameters.Add("@apellido", SqlDbType.VarChar).Value = miembro.Apellido;
                    command.Parameters.Add("@telefono", SqlDbType.VarChar).Value = miembro.Telefono;
                    command.Parameters.Add("@sexo", SqlDbType.VarChar).Value = miembro.Sexo;
                    command.Parameters.Add("@membresiaId", SqlDbType.SmallInt).Value = miembro.MembresiaId;
                    command.Parameters.Add("@status", SqlDbType.VarChar).Value = miembro.Status;
                    command.Parameters.Add("@fechaInicio", SqlDbType.DateTime).Value = miembro.FechaInicio;
                    command.Parameters.Add("@fechaFin", SqlDbType.DateTime).Value = miembro.FechaFin;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Update(Miembro miembro)
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
                    command.Parameters.Add("@miembroId", SqlDbType.Int).Value = miembro.MiembroId;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = miembro.Nombre;
                    command.Parameters.Add("@apellido", SqlDbType.VarChar).Value = miembro.Apellido;
                    command.Parameters.Add("@telefono", SqlDbType.VarChar).Value = miembro.Telefono;
                    command.Parameters.Add("@sexo", SqlDbType.VarChar).Value = miembro.Sexo;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Delete(int miembroId)
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = deleteCommand;
                    command.CommandType = CommandType.Text;

                    //Parametros
                    command.Parameters.Add("@miembroId", SqlDbType.Int).Value = miembroId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            };
        }

        public async Task<IEnumerable<Miembro>> GetAll()
        {
            //Lista a llenar
            List<Miembro> lst = new List<Miembro>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = getAllCommand;
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
                            lst.Add(new Miembro
                            {
                                MiembroId = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                Telefono = reader.GetString(3),
                                Sexo = reader.GetString(4),
                                MembresiaId = reader.GetInt16(5),
                                NombreMembresia = reader.GetString(6),
                                CostoMembresia = reader.GetDecimal(7),
                                Status = reader.GetString(8),
                                FechaInicio = reader.GetDateTime(9),
                                FechaFin = reader.GetDateTime(10),
                                CreatedAt = reader.GetDateTime(11),
                                UpdatedAt = reader.GetDateTime(12)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public async Task<IEnumerable<Miembro>> GetPendientesOnDashboard(string miembroStatus)
        {
            //Lista a llenar
            List<Miembro> lst = new List<Miembro>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "select Nombre, Apellido, FechaFin from Miembro where Status = @status";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    //Parametros
                    command.Parameters.Add("@status", SqlDbType.VarChar).Value = miembroStatus;

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
                            lst.Add(new Miembro
                            {
                                Nombre = reader.GetString(0),
                                Apellido = reader.GetString(1),
                                FechaFin = reader.GetDateTime(2)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public async Task<List<int>> GetCantidadMiembrosByStatus()
        {
            //Lista a llenar
            List<int> lst = new List<int>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_GET_TOTAL_MIEMBROS_STATUS";

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

        public async Task<List<int>> GetCantidadMiembrosBySexo()
        {
            //Lista a llenar
            List<int> lst = new List<int>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_GET_TOTAL_MIEMBROS_SEXO";

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

        public async Task UpdateStatus()
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_UPDATE_STATUS";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.StoredProcedure;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }
    }
}