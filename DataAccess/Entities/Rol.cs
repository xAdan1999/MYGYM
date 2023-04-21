using System;

namespace DataAccess.Entities
{
    public class Rol
    {
        private byte _rolId;
        private string _nombre;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public byte RolId { get => _rolId; set => _rolId = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
    }
}
