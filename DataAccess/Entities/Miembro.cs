using System;

namespace DataAccess.Entities
{
    public class Miembro
    {
        private int _miembroId;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private string _sexo;
        private short _membresiaId;
        private string _nombreMembresia;
        private decimal _costoMembresia;
        private string _status;
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public int MiembroId { get => _miembroId; set => _miembroId = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Sexo { get => _sexo; set => _sexo = value; }
        public short MembresiaId { get => _membresiaId; set => _membresiaId = value; }
        public string NombreMembresia { get => _nombreMembresia; set => _nombreMembresia = value; }
        public decimal CostoMembresia { get => _costoMembresia; set => _costoMembresia = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
    }
}