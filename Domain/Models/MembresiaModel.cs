using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using DataAccess.Entities;
using Domain.ValueObjects;
using System;

namespace Domain.Models
{
    public class MembresiaModel
    {
        private short _membresiaId;
        private string _nombre;
        private decimal _costo;
        private DateTime _createdAt;
        private DateTime _updatedAt;

        private EntityState _entityState;
        private MembresiaRepository _membresiaRepository;
        private List<MembresiaModel> _lstDomain;

        [DisplayName("ID")]
        public short MembresiaId { get => _membresiaId; set => _membresiaId = value; }

        [DisplayName("Nombre")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [DisplayName("Costo")]
        public decimal Costo { get => _costo; set => _costo = value; }

        [DisplayName("Fecha de creación")]
        public DateTime CreatedAt { get => _createdAt; private set => _createdAt = value; }

        [DisplayName("Última modificación")]
        public DateTime UpdatedAt { get => _updatedAt; private set => _updatedAt = value; }

        public EntityState EntityState { private get => _entityState; set => _entityState = value; }

        public MembresiaModel()
        {
            _membresiaRepository = new MembresiaRepository();
        }

        public async Task<string> SaveChanges()
        {
            string message = string.Empty;

            try
            {
                //Crear el objeto
                Membresia membresia = new Membresia();
                membresia.MembresiaId = _membresiaId;
                membresia.Nombre = _nombre;
                membresia.Costo = _costo;

                //Indicar el comportamiento de la entidad
                switch (_entityState)
                {
                    case EntityState.Created:
                        await _membresiaRepository.Create(membresia: membresia);
                        message = "created";
                        break;
                    case EntityState.Updated:
                        await _membresiaRepository.Update(membresia: membresia);
                        message = "updated";
                        break;
                    case EntityState.Deleted:
                        await _membresiaRepository.Delete(membresiaId: _membresiaId);
                        message = "deleted";
                        break;
                }
            }
            catch (Exception ex)
            {
                //Si la excepcion capturada es de tipo sqlexception
                //y corresponde a un dato duplicado (2627) informar
                //de lo contrario simplemente devolver el error capturado
                SqlException sqlException = ex as SqlException;

                if (sqlException != null && sqlException.Number == 2627)
                {
                    message = "Ya existe una membresía con ese nombre";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public async Task<List<MembresiaModel>> GetAllMembresias()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = await _membresiaRepository.GetAll();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<MembresiaModel>();

            //Mapear y retornar la lista
            foreach (Membresia membresia in lstDataAccess)
            {
                _lstDomain.Add(new MembresiaModel
                {
                    _membresiaId = membresia.MembresiaId,
                    _nombre = membresia.Nombre,
                    _costo = membresia.Costo,
                    _createdAt = membresia.CreatedAt,
                    _updatedAt = membresia.UpdatedAt
                });
            }
            return _lstDomain;
        }

        public List<MembresiaModel> SearchMembresia(string membresia)
        {
            //Realizar la busqueda de esta manera evita que se consulte
            //en la base de datos con cada pulsasion de teclas
            return _lstDomain.FindAll(e =>
            e._membresiaId.ToString().Equals(membresia) ||
            e._nombre.ToLower().Contains(membresia.ToLower()));
        }

        public List<MembresiaModel> GetAllMembresiasOnComboBox()
        {
            //Lista que devuelve la capa de datos
            var lstDataAccess = _membresiaRepository.GetMembresiasOnComboBox();

            //Lista a devolver a la capa de presentacion
            _lstDomain = new List<MembresiaModel>();

            //Mapear y retornar la lista
            foreach (Membresia membresia in lstDataAccess)
            {
                _lstDomain.Add(new MembresiaModel
                {
                    _membresiaId = membresia.MembresiaId,
                    _nombre = membresia.Nombre,
                });
            }
            return _lstDomain;
        }

        public async Task<decimal> GetCostoMembresiaById(short membresiaId)
        {
            return await _membresiaRepository.GetCostoMembresiaById(membresiaId: membresiaId);
        }
    }
}