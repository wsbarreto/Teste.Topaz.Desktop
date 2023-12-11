using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.Domain.Interface.Service;

namespace Teste.Topaz.Desktop.Service;

public class FaixaService : BaseService<FaixaEntity>, IFaixaService
{
    private readonly IFaixaRepository _repository;
    public FaixaService(IFaixaRepository repository) : base(repository) =>
        this._repository = repository;

    public async Task InserirListAsync(IEnumerable<FaixaEntity> list) => await this._repository.InserirListAsync(list);
}