using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        //Repositorio generico con los 4 metodos basicos
        Task Create(Entity entity);
        Task Update(Entity entity);
        Task Delete(int id);
        Task<IEnumerable<Entity>> GetAll();
    }
}
