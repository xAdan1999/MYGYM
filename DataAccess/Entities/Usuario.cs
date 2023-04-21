using System;

namespace DataAccess.Entities
{
    public class Usuario
    {
        private byte _usuarioId;
        private string _nombreUsuario;
        private string _contrasena;
        private byte _rolId;
        private string _rolNombre;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        public byte UsuarioId { get => _usuarioId; set => _usuarioId = value; }
        public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
        public string Contrasena { get => _contrasena; set => _contrasena = value; }
        public byte RolId { get => _rolId; set => _rolId = value; }
        public string RolNombre { get => _rolNombre; set => _rolNombre = value; }
        public DateTime CreatedAt { get => _createdAt; set => _createdAt = value; }
        public DateTime UpdatedAt { get => _updatedAt; set => _updatedAt = value; }
    }
}
