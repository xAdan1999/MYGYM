using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;
using System.ComponentModel;
using Domain.ValueObjects;
using DataAccess.Entities;
using System;

namespace Domain.Models
{
    public class UsuarioModel
    {
        private byte _usuarioId;
        private string _nombreUsuario;
        private string _contrasena;
        private byte _rolId;
        private string _rolNombre;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        private EntityState _entityState;
        private UsuarioRepository _usuarioRepository;
        private List<UsuarioModel> _lstDomain;

        [DisplayName("ID")]
        public byte UsuarioId { get => _usuarioId; set => _usuarioId = value; }

        [DisplayName("Usuario")]
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }

        [DisplayName("Contraseña")]
        public string Contrasena { get => _contrasena; set => _contrasena = value; }

        public byte RolId { get => _rolId; set => _rolId = value; }

        [DisplayName("Rol")]
        public string RolNombre { get => _rolNombre; set => _rolNombre = value; }

        [DisplayName("Fecha de creación")]
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }

        [DisplayName("Última modificación")]
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public EntityState EntityState { private get => _entityState; set => _entityState = value; }

        public UsuarioModel()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public async Task<string> SaveChanges()
        {
            string message = string.Empty;

            try
            {
                //Crear el objeto
                Usuario usuario = new Usuario();
                usuario.UsuarioId = _usuarioId;
                usuario.NombreUsuario = _nombreUsuario;
                usuario.Contrasena = _contrasena;
                usuario.RolId = _rolId;

                //Indicar el comportamiento de la entidad
                switch (_entityState)
                {
                    case EntityState.Created:
                        await _usuarioRepository.Create(usuario: usuario);
                        message = "created";
                        break;
                    case EntityState.Updated:
                        await _usuarioRepository.Update(usuario: usuario);
                        message = "updated";
                        break;
                    case EntityState.Deleted:
                        await _usuarioRepository.Delete(usuarioId: _usuarioId);
                        message = "deleted";
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message.ToString();
            }
            return message;
        }

        public async Task<List<UsuarioModel>> GetAllUsuarios()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _usuarioRepository.GetAll();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<UsuarioModel>();

            //Mapear y retornar la lista
            foreach (Usuario usuario in lstDataAccess)
            {
                _lstDomain.Add(new UsuarioModel
                {
                    _usuarioId = usuario.UsuarioId,
                    _nombreUsuario = usuario.NombreUsuario,
                    _contrasena = usuario.Contrasena,
                    _rolNombre = usuario.RolNombre,
                    _createdAt = usuario.CreatedAt,
                    _updatedAt = usuario.UpdatedAt
                });
            }
            return _lstDomain;
        }

        public List<UsuarioModel> SearchUsuario(string usuario)
        {
            //Realizar la busqueda de esta manera evita que se consulte
            //en la base de datos con cada pulsasion de teclas */
            return _lstDomain.FindAll(e =>
            e._usuarioId.ToString().Equals(usuario) ||
            e._nombreUsuario.ToLower().Contains(usuario.ToLower()));
        }

        public async Task<byte> Login(string nombreUsuario, string contrasenaUsuario)
        {
            return await _usuarioRepository.Login(nombreUsuario, contrasenaUsuario);
        }

        //Para obtener los datos de usuario en cache
        public async Task GetUsuarioById(byte usuarioId)
        {
            await _usuarioRepository.GetUsuarioById(usuarioId: usuarioId);
        }
    }
}
