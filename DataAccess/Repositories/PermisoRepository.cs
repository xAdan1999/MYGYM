using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;
using System.Data;

namespace DataAccess.Repositories
{
    public class PermisoRepository : Repository, IPermisoRepository
    {
        //Comandos basicos
        readonly string createCommand = "SP_CREATE_PERMISO";
        readonly string updateCommand = "SP_UPDATE_PERMISO";

        public async Task Create(Permiso permiso)
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
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = permiso.RolId;
                    command.Parameters.Add("@operacionId", SqlDbType.TinyInt).Value = permiso.OperacionId;
                    command.Parameters.Add("@status", SqlDbType.TinyInt).Value = permiso.Status;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task Update(Permiso permiso)
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
                    command.Parameters.Add("@permisoId", SqlDbType.SmallInt).Value = permiso.PermisoId;
                    command.Parameters.Add("@rolId", SqlDbType.TinyInt).Value = permiso.RolId;
                    command.Parameters.Add("@operacionId", SqlDbType.TinyInt).Value = permiso.OperacionId;
                    command.Parameters.Add("@status", SqlDbType.Bit).Value = permiso.Status;

                    //Ejecutar comando
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }

        public async Task<IEnumerable<Permiso>> GetPermisosByRolId(byte rolId)
        {
            //Lista a llenar
            List<Permiso> lst = new List<Permiso>();

            //Obtener conexion
            using (var connection = GetConnection())
            {
                using (var command = new SqlCommand())
                {
                    const string commandText = "select PermisoId, OperacionId, Status from Permiso where RolId = @RolId order by PermisoId asc";

                    //Configurar comando
                    command.Connection = connection;
                    command.CommandText = commandText;
                    command.CommandType = CommandType.Text;

                    //Parametros
                    command.Parameters.Add("@RolId", SqlDbType.TinyInt).Value = rolId;

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
                            lst.Add(new Permiso
                            {
                                PermisoId = reader.GetInt16(0),
                                OperacionId = reader.GetByte(1),
                                Status = reader.GetByte(2)
                            });
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