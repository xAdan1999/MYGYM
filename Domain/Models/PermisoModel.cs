using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;
using DataAccess.Entities;
using Domain.ValueObjects;

namespace Domain.Models
{
    public class PermisoModel
    {
        private short _permisoId;
        private byte _rolId;
        private byte _operacionId;
        private byte _status;

        private EntityState _entityState;
        private PermisoRepository _permisoRepository;
        private List<PermisoModel> _lstDomain;

        public short PermisoId { get => _permisoId; set => _permisoId = value; }
        public byte RolId { get => _rolId; set => _rolId = value; }
        public byte OperacionId { get => _operacionId; set => _operacionId = value; }
        public byte Status { get => _status; set => _status = value; }
        public EntityState EntityState { private get => _entityState; set => _entityState = value; }

        public PermisoModel()
        {
            _permisoRepository = new PermisoRepository();
        }

        public async Task SaveChanges()
        {
            //Crear el objeto
            Permiso permiso = new Permiso();
            permiso.PermisoId = _permisoId;
            permiso.RolId = _rolId;
            permiso.OperacionId = _operacionId;
            permiso.Status = _status;

            //Indicar el comportamiento de la entidad
            switch (_entityState)
            {
                case EntityState.Created:
                    await _permisoRepository.Create(permiso: permiso);
                    break;
                case EntityState.Updated:
                    await _permisoRepository.Update(permiso: permiso);
                    break;
            }
        }

        public async Task<List<PermisoModel>> GetPermisosByRolId(byte rolId)
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _permisoRepository.GetPermisosByRolId(rolId: rolId);

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<PermisoModel>();

            //Mapear y retornar la lista
            foreach (Permiso permiso in lstDataAccess)
            {
                _lstDomain.Add(new PermisoModel
                {
                    _permisoId = permiso.PermisoId,
                    _operacionId = permiso.OperacionId,
                    _status = permiso.Status
                });
            }
            return _lstDomain;
        }
    }
}
