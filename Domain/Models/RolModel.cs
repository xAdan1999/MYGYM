using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using Domain.ValueObjects;
using DataAccess.Entities;
using System;

namespace Domain.Models
{
    public class RolModel
    {
        private byte _rolId;
        private string _nombre;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        private EntityState _entityState;
        private RolRepository _rolRepository;
        private List<RolModel> _lstDomain;

        [DisplayName("ID")]
        public byte RolId { get => _rolId; set => _rolId = value; }

        [DisplayName("Nombre rol")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DisplayName("Fecha de creación")]
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }

        [DisplayName("Última modificación")]
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public EntityState EntityState { private get => _entityState; set => _entityState = value; }

        public RolModel()
        {
            _rolRepository = new RolRepository();
        }

        public async Task<string> SaveChanges()
        {
            string message = string.Empty;

            try
            {
                //Crear el objeto
                Rol rol = new Rol();
                rol.RolId = _rolId;
                rol.Nombre = _nombre;

                //Indicar el comportamiento de la entidad
                switch (_entityState)
                {
                    case EntityState.Created:
                        await _rolRepository.Create(rol: rol);
                        message = "created";
                        break;
                    case EntityState.Updated:
                        await _rolRepository.Update(rol: rol);
                        message = "updated";
                        break;
                    case EntityState.Deleted:
                        await _rolRepository.Delete(rolId: _rolId);
                        message = "deleted";
                        break;
                }
            }
            catch (Exception ex)
            {
                //Si la excepcion capturada es de tipo sqlexception
                //y corresponde a un dato duplicado(2627) informar
                //de lo contrario simplemente devolver cualquier
                //otro error que haya sido capturado
                SqlException sqlException = ex as SqlException;

                if (sqlException != null && sqlException.Number == 2627)
                {
                    message = "Ya existe un rol con ese nombre";
                }
                else
                {
                    message = ex.Message.ToString();
                }
            }
            return message;
        }

        public async Task<List<RolModel>> GetAllRoles()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _rolRepository.GetAll();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<RolModel>();

            //Mapear y retornar la lista
            foreach (Rol rol in lstDataAccess)
            {
                _lstDomain.Add(new RolModel
                {
                    _rolId = rol.RolId,
                    _nombre = rol.Nombre,
                    _createdAt = rol.CreatedAt,
                    _updatedAt = rol.UpdatedAt
                });
            }
            return _lstDomain;
        }

        public List<RolModel> SearchRol(string rol)
        {
            //Realizar la busqueda de esta manera evita que se consulte
            //en la base de datos con cada pulsasion de teclas
            return _lstDomain.FindAll(e =>
            e._rolId.ToString().Equals(rol) ||
            e._nombre.ToLower().Contains(rol.ToLower()));
        }

        public List<RolModel> GetAllRolesOnComboBox()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = _rolRepository.GetRolesOnComboBox();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<RolModel>();

            //Mapear y retornar la lista
            foreach (Rol rol in lstDataAccess)
            {
                _lstDomain.Add(new RolModel
                {
                    _rolId = rol.RolId,
                    _nombre = rol.Nombre,
                });
            }
            return _lstDomain;
        }

        public byte GetLastRolId()
        {
            return _rolRepository.GetLastRolId();
        }
    }
}
