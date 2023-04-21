using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;
using System;

namespace DataAccess.Repositories
{
    public class RolRepository : Repository, IRolRepository
    {
        //Comandos basicos
        readonly string createCommand = "SP_CREATE_ROL";
        readonly string updateCommand = "SP_UPDATE_ROL";
        readonly string deleteCommand = "SP_DELETE_ROL";
        readonly string getAllCommand = "SP_GET_ROLES";

        public async Task Create(Rol rol)
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
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = rol.Nombre;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Update(Rol rol)
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
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = rol.RolId;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = rol.Nombre;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Delete(int rolId)
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
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = rolId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task<IEnumerable<Rol>> GetAll()
        {
            //Lista a llenar
            List<Rol> lst = new List<Rol>();

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
                            lst.Add(new Rol
                            {
                                RolId = reader.GetByte(0),
                                Nombre = reader.GetString(1),
                                CreatedAt = reader.GetDateTime(2),
                                UpdatedAt = reader.GetDateTime(3)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public IEnumerable<Rol> GetRolesOnComboBox()
        {
            //Lista a llenar
            List<Rol> lst = new List<Rol>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    const string commandText = "select RolId, Nombre from Rol order by RolId asc";

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
                            lst.Add(new Rol
                            {
                                RolId = reader.GetByte(0),
                                Nombre = reader.GetString(1)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public byte GetLastRolId()
        {
            //Rol id
            byte lastRolId = 0;

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "select top 1 RolId from Rol order by RolId desc";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    //Ejecutar comando 
                    connection.Open();

                    //Como solo es necesario traer un dato, usar ExecuteScalar es lo mas optimo
                    lastRolId = Convert.ToByte(command.ExecuteScalar());

                    connection.Close();
                }
            }
            return lastRolId;
        }
    }
}