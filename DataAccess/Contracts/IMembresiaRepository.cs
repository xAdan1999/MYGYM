using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IMembresiaRepository : IGenericRepository<Membresia>
    {
        //Metodos extra
        IEnumerable<Membresia> GetMembresiasOnComboBox();
        Task<decimal> GetCostoMembresiaById(short membresiaId);
    }
}