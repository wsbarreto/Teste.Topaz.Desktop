using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.Domain.Interface.Service;

namespace Teste.Topaz.Desktop.Service;

public class GeneroService : BaseService<GeneroEntity>, IGeneroService
{
    private readonly IGeneroRepository _repository;
    public GeneroService(IGeneroRepository repository) : base(repository) =>
        this._repository = repository;
}