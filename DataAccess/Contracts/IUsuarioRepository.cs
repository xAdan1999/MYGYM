using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        //Metodos extra
        Task<byte> Login(string nombreUsuario, string contrasenaUsuario);
        Task GetUsuarioById(byte usuarioId);
    }
}
