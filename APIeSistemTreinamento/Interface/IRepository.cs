using APIeSistemTreinamento.Models;
using System.Linq.Expressions;

namespace APIeSistemTreinamento.Interface
{
    public interface IRepository<TEntity> :  IDisposable where TEntity : Entity
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> BuscarPorId(int id);
        Task<List<TEntity>> BuscarTodos();
        Task Atualizar(TEntity entity);
        Task Remover(int id);
        Task<int> SaveChanges();
    }
}
