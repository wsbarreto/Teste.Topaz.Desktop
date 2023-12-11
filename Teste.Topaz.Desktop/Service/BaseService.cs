using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.Domain.Interface.Service;

namespace Teste.Topaz.Desktop.Service;

public abstract class BaseService<TEntity> : IDisposable, IBaseService<TEntity> where TEntity : class
{
    private readonly IBaseRepository<TEntity> _baseRepository;

    public BaseService(IBaseRepository<TEntity> baseRepository) =>
        _baseRepository = baseRepository;

    public async Task<TEntity> AddAsync(TEntity obj)
    {
        await _baseRepository.InsertAsync(obj);
        return obj;
    }

    public async Task<IList<TEntity>> AddRangeAsync(IList<TEntity> obj)
    {
        await _baseRepository.InsertRangeAsync(obj);
        return obj;
    }

    public async Task DeleteAsync(TEntity entity) => await _baseRepository.DeleteAsync(entity);

    public async Task<IEnumerable<TEntity>> GetAllAsync() => await _baseRepository.FindAllAsync();

    public async Task<TEntity> GetByIdAsync(Guid id) => await _baseRepository.FindByIdAsync(id);

    public async Task<TEntity> GetByPredicateAsync(Predicate<TEntity> predicate) => await this._baseRepository.FindByPredicateAsync(predicate);

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        await _baseRepository.UpdateAsync(entity);
        return entity;
    }

    ~BaseService() => Dispose();

    public void Dispose() => GC.SuppressFinalize(this);
}