using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Domain.Interface.Repository;

public interface IFaixaRepository : IBaseRepository<FaixaEntity>, IDisposable
{
    Task InserirListAsync(IEnumerable<FaixaEntity> list);
}
