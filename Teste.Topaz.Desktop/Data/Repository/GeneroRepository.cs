using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;

namespace Teste.Topaz.Desktop.Data.Repository;

public class GeneroRepository : BaseRepository<GeneroEntity>, IGeneroRepository
{
    private readonly DataContext _dataContext;
    public GeneroRepository(DataContext dataContext) : base(dataContext) =>
        this._dataContext = dataContext;

    ~GeneroRepository() => this.Dispose();
    public void Dispose() => GC.SuppressFinalize(this);
}