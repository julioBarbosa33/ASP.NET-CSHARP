using ProjetoJulio3.Models;

namespace ProjetoJulio3.Repositores
{
    public interface IUsuarioRepositorio
    {
        List<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel>Adicionar(UsuarioModel usuario);
        Task<UsuarioModel>Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
        
    }
}
