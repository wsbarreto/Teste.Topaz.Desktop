namespace Teste.Topaz.Desktop.Domain.Interface.Service;

public interface IBaseService<TEntity> where TEntity : class
{
    Task<TEntity> AddAsync(TEntity obj);
    Task<IList<TEntity>> AddRangeAsync(IList<TEntity> obj);
    Task<TEntity> UpdateAsync(TEntity obj);
    Task DeleteAsync(TEntity entity);
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity> GetByPredicateAsync(Predicate<TEntity> predicate);
    Task<TEntity> GetByIdAsync(Guid id);
}