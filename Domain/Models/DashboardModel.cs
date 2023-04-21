using System.Collections.Generic;
using DataAccess.Repositories;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DashboardModel
    {
        private DashboardRepository _dashboardRepository;

        public DashboardModel()
        {
            _dashboardRepository = new DashboardRepository();
        }

        public async Task<List<int>> GetTotales()
        {
            return await _dashboardRepository.GetTotales();
        }
    }
}
