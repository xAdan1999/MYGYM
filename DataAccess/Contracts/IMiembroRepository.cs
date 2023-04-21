using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IMiembroRepository : IGenericRepository<Miembro>
    {
        //Metodos extra
        Task<IEnumerable<Miembro>> GetPendientesOnDashboard(string miembroStatus);
        Task<List<int>>GetCantidadMiembrosByStatus();
        Task<List<int>> GetCantidadMiembrosBySexo();
        Task UpdateStatus();
    }
}
