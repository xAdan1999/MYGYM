using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;
using System.ComponentModel;
using DataAccess.Entities;
using Domain.ValueObjects;
using System;

namespace Domain.Models
{
    public class MiembroModel
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

        private EntityState _entityState;
        private MiembroRepository _miembroRepository;
        private List<MiembroModel> _lstDomain;

        [DisplayName("ID")]
        public int MiembroId { get => _miembroId; set => _miembroId = value; }

        [DisplayName("Nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DisplayName("Apellido")]
        public string Apellido { get => _apellido; set => _apellido = value; }

        [DisplayName("Teléfono")]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [DisplayName("Sexo")]
        public string Sexo { get => _sexo; set => _sexo = value; }

        public short MembresiaId { get => _membresiaId; set => _membresiaId = value; }

        [DisplayName("Membresía")]
        public string NombreMembresia { get => _nombreMembresia; private set => _nombreMembresia = value; }

        [DisplayName("Costo membresía")]
        public decimal CostoMembresia { get => _costoMembresia; set => _costoMembresia = value; }

        [DisplayName("Status")]
        public string Status { get => _status; set => _status = value; }

        [DisplayName("Inicia")]
        public DateTime FechaInicio { get => _fechaInicio; set => _fechaInicio = value; }

        [DisplayName("Termina")]
        public DateTime FechaFin { get => _fechaFin; set => _fechaFin = value; }

        [DisplayName("Fecha de creación")]
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }

        [DisplayName("Última modificación")]
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public EntityState EntityState { private get => _entityState; set => _entityState = value; }

        public MiembroModel()
        {
            _miembroRepository = new MiembroRepository();
        }

        public async Task<string> SaveChanges()
        {
            string message = string.Empty;

            try
            {
                //Crear el objeto
                Miembro miembro = new Miembro();
                miembro.MiembroId = _miembroId;
                miembro.Nombre = _nombre;
                miembro.Apellido = _apellido;
                miembro.Telefono = _telefono;
                miembro.Sexo = _sexo;
                miembro.MembresiaId = _membresiaId;
                miembro.Status = _status;
                miembro.FechaInicio = _fechaInicio;
                miembro.FechaFin = _fechaFin;

                //Indicar el comportamiento de la entidad
                switch (_entityState)
                {
                    case EntityState.Created:
                        await _miembroRepository.Create(miembro: miembro);
                        message = "created";
                        break;
                    case EntityState.Updated:
                        await _miembroRepository.Update(miembro: miembro);
                        message = "updated";
                        break;
                    case EntityState.Deleted:
                        await _miembroRepository.Delete(miembroId: _miembroId);
                        message = "deleted";
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.ToString();
            }
            return message;
        }

        public async Task<List<MiembroModel>> GetAllMiembros()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _miembroRepository.GetAll();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<MiembroModel>();

            //Mapear y retornar la lista
            foreach (Miembro miembro in lstDataAccess)
            {
                _lstDomain.Add(new MiembroModel
                {
                    _miembroId = miembro.MiembroId,
                    _nombre = miembro.Nombre,
                    _apellido = miembro.Apellido,
                    _telefono = miembro.Telefono,
                    _sexo = miembro.Sexo,
                    _membresiaId = miembro.MembresiaId,
                    _nombreMembresia = miembro.NombreMembresia,
                    _costoMembresia = miembro.CostoMembresia,
                    _status = miembro.Status,
                    _fechaInicio = miembro.FechaInicio,
                    _fechaFin = miembro.FechaFin,
                    _createdAt = miembro.CreatedAt,
                    _updatedAt = miembro.UpdatedAt
                });
            }
            return _lstDomain;
        }

        public List<MiembroModel> SearchMiembro(string miembro)
        {
            //Realizar la busqueda de esta manera evita que se consulte
            //en la base de datos con cada pulsasion de teclas
            return _lstDomain.FindAll(m =>
            m._miembroId.ToString().Equals(value: miembro) ||
            m._nombre.Contains(value: miembro.ToLower()) ||
            m._apellido.Contains(value: miembro.ToLower()));
        }

        public List<MiembroModel> GetMiembrosByStatus(string status)
        {
            //Para evitar obtener toda la informacion de la base de datos 
            //tras seleccionar la opcion de "todos", simplemente comprobar si el
            //el status por el que se desea buscar es activo, inactivo o pendiente 
            //de lo contrario devolver la lista por defecto que ya habia sido 
            //llenada con toda la informacion
            if (status != "Todos")
            {
                return _lstDomain.FindAll(m => m._status.Equals(value: status));
            }
            else
            {
                return _lstDomain;
            }
        }

        public List<MiembroModel> GetMiembrosByValue(string status, string sexo)
        {
            //Este filtrado se puede mejorar
            if (sexo != "Todos")
            {
                if (status != "Todos")
                {
                    return _lstDomain.FindAll(m =>
                    m._status.Equals(value: status) &&
                    m._sexo.Equals(sexo));
                }
                return _lstDomain.FindAll(m =>
                m._sexo.Equals(sexo));
            }
            else if (status != "Todos")
            {
                if(sexo != "Todos")
                {
                    return _lstDomain.FindAll(m => 
                    m._status.Equals(value: status) &&
                    m._sexo.Equals(sexo));
                }
                return _lstDomain.FindAll(m =>
                m._status.Equals(value: status));
            }
            else
            {
                return _lstDomain;
            }
        }

        public async Task<List<MiembroModel>> GetPendientesOnDashboard(string miembroStatus)
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _miembroRepository.GetPendientesOnDashboard(miembroStatus: miembroStatus);

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<MiembroModel>();

            //Mapear y retornar la lista
            foreach (Miembro miembro in lstDataAccess)
            {
                _lstDomain.Add(new MiembroModel
                {
                    _miembroId = miembro.MiembroId,
                    _nombre = miembro.Nombre,
                    _apellido = miembro.Apellido,
                    _fechaFin = miembro.FechaFin,
                });
            }
            return _lstDomain;
        }

        public async Task<List<decimal>> GetTotalMiembrosByStatus()
        {
            //Obtener lista de totales
            var lst = await _miembroRepository.GetCantidadMiembrosByStatus();

            //Lista a devolver
            var lstPorcentajes = new List<decimal>();

            //Separar totales
            int totalActivos = lst[0];
            int totalInactivos = lst[1];
            int totalPendientes = lst[2];

            //Suma total de miembros por status
            int sumaTotal = totalActivos + totalInactivos + totalPendientes;

            //Para obtener los porcentajes
            decimal porcentajeActivos = 0;
            decimal porcentajeInactivos = 0;
            decimal porcentajePendientes = 0;

            //Solo si la suma total es mayor a 0 se podran sacar los
            //porcentajes esto para evitar errores en caso de querer dividir entre 0
            if (sumaTotal > 0)
            {
                //Obtener porcentajes
                porcentajeActivos = totalActivos * 100 / sumaTotal;
                porcentajeInactivos = totalInactivos * 100 / sumaTotal;
                porcentajePendientes = totalPendientes * 100 / sumaTotal;
            }

            //Asignar los porcentajes a la nueva lista
            lstPorcentajes.Add(porcentajeActivos);
            lstPorcentajes.Add(porcentajeInactivos);
            lstPorcentajes.Add(porcentajePendientes);

            return lstPorcentajes;
        }

        public async Task<List<decimal>> GetTotalMiembrosBySexo()
        {
            //Obtener lista de totales
            var lst = await _miembroRepository.GetCantidadMiembrosBySexo();

            //Lista a devolver
            var lstPorcentajes = new List<decimal>();

            //Separar totales
            int totalHombres = lst[0];
            int totalMujeres = lst[1];
            int totalOtros = lst[2];

            //Suma total de miembros por status
            int sumaTotal = totalHombres + totalMujeres + totalOtros;

            //Para obtener los porcentajes
            decimal porcentajeHombres = 0;
            decimal porcentajeMujeres = 0;
            decimal porcentajeOtros = 0;

            //Solo si la suma total es mayor a 0 se podran sacar los
            //porcentajes esto para evitar errores en caso de querer dividir entre 0
            if (sumaTotal > 0)
            {
                //Obtener porcentajes
                porcentajeHombres = totalHombres * 100 / sumaTotal;
                porcentajeMujeres = totalMujeres * 100 / sumaTotal;
                porcentajeOtros = totalOtros * 100 / sumaTotal;
            }

            //Asignar los porcentajes a la nueva lista
            lstPorcentajes.Add(porcentajeHombres);
            lstPorcentajes.Add(porcentajeMujeres);
            lstPorcentajes.Add(porcentajeOtros);

            return lstPorcentajes;
        }

        public async Task UpdateStatus()
        {
            await _miembroRepository.UpdateStatus();
        }
    }
}