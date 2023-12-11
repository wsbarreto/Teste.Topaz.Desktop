using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Domain.Interface.Service;

public interface IFaixaService : IBaseService<FaixaEntity>
{
    Task InserirListAsync(IEnumerable<FaixaEntity> list);
}
