using System;

namespace DataAccess.Entities
{
    public class Membresia
    {
        private short _membresiaId;
        private string _nombre;
        private decimal _costo;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public short MembresiaId { get => _membresiaId; set => _membresiaId = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Costo { get => _costo; set => _costo = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
    }
}
