using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IPermisoRepository
    {
        Task Create(Permiso permiso);
        Task Update(Permiso permiso);
        Task<IEnumerable<Permiso>> GetPermisosByRolId(byte rolId);
    }
}

