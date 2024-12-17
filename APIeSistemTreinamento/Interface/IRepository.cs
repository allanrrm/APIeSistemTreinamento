using APIeSistemTreinamento.Models;

namespace APIeSistemTreinamento.Interface
{
    public interface IRepository<TEntity> :  IDisposable where TEntity : Entity
    {
    }
}
