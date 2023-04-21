using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using Common.Cache;
using System.Data;
using System;

namespace DataAccess.Repositories
{
    public class UsuarioRepository : Repository, IUsuarioRepository
    {
        //Comandos basicos
        readonly string createCommand = "SP_CREATE_USUARIO";
        readonly string updateCommand = "SP_UPDATE_USUARIO";
        readonly string deleteCommand = "SP_DELETE_USUARIO";
        readonly string getAllCommand = "SP_GET_USUARIOS";

        public async Task Create(Usuario usuario)
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
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                    command.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = usuario.Contrasena;
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = usuario.RolId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Update(Usuario usuario)
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
                    command.Parameters.Add("@usuarioId", SqlDbType.TinyInt).Value = usuario.UsuarioId;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuario.NombreUsuario;
                    command.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = usuario.Contrasena;
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = usuario.RolId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Delete(int usuarioId)
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
                    command.Parameters.Add("@usuarioId", SqlDbType.TinyInt).Value = usuarioId;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            //Lista a llenar
            List<Usuario> lst = new List<Usuario>();

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
                            lst.Add(new Usuario
                            {
                                UsuarioId = reader.GetByte(0),
                                NombreUsuario = reader.GetString(1),
                                Contrasena = reader.GetString(2),
                                RolNombre = reader.GetString(3),
                                CreatedAt = reader.GetDateTime(4),
                                UpdatedAt = reader.GetDateTime(5)
                            });
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            return lst;
        }

        public async Task<byte> Login(string nombreUsuario, string contrasenaUsuario)
        {
            //Para obtener el id del usuario y consultar su informacion despues
            byte usuarioId = 0;

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_LOGIN_USUARIO";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros
                    command.Parameters.Add("@nombreUsuario", SqlDbType.VarChar).Value = nombreUsuario;
                    command.Parameters.Add("@contrasenaUsuario", SqlDbType.VarChar).Value = contrasenaUsuario;

                    //Abrir conexion
                    connection.Open();

                    //Como solo es necesario traer un dato, usar ExecuteScalar es lo mas optimo
                    usuarioId = Convert.ToByte(await command.ExecuteScalarAsync());

                    connection.Close();
                }
            }
            return usuarioId;
        }

        public async Task GetUsuarioById(byte usuarioId)
        {
            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    //Comando a ejecutar
                    const string commandText = "SP_GET_USUARIO";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.StoredProcedure;

                    //Parametros
                    command.Parameters.Add("@usuarioId", SqlDbType.TinyInt).Value = usuarioId;

                    //Ejecutar lector
                    connection.Open();

                    //Ejecutar lector
                    var reader = await command.ExecuteReaderAsync();

                    //Si hay filas
                    if (reader.HasRows)
                    {
                        //Llenar la cache
                        while (reader.Read())
                        {
                            UserCache.nombreUsuario = reader.GetString(0);
                            UserCache.rolId = reader.GetByte(1);
                            UserCache.rolNombre = reader.GetString(2);
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}