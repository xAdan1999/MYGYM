using System.Collections.Generic;
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IRolRepository : IGenericRepository<Rol>
    {
        //Metodos extra
        IEnumerable<Rol> GetRolesOnComboBox();
        byte GetLastRolId();
    }
}
