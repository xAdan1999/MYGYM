using System;

namespace DataAccess.Entities
{
    public class Permiso
    {
        private short _permisoId;
        private byte _rolId;
        private byte _operacionId;
        private byte _status;

        public short PermisoId { get => _permisoId; set => _permisoId = value; }
        public byte RolId { get => _rolId; set => _rolId = value; }
        public byte OperacionId { get => _operacionId; set => _operacionId = value; }
        public byte Status { get => _status; set => _status = value; }
    }
}
