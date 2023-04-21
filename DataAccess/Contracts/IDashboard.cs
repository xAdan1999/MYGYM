using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IDashboard
    {
        Task<List<int>> GetTotales();
    }
}
