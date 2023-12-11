using Dapper;
using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;

namespace Teste.Topaz.Desktop.Data.Repository;

public class FaixaRepository : BaseRepository<FaixaEntity>, IFaixaRepository
{
    private readonly DataContext _dataContext;

    public FaixaRepository(DataContext dataContext) : base(dataContext) =>
        this._dataContext = dataContext;

    public async Task InserirListAsync(IEnumerable<FaixaEntity> list)
    {
        using (var cn = this._dataContext.CreateConnection())
        {
            cn.Open();
            foreach (var item in list)
            {
                var query = @$"INSERT INTO TOPAZ.TB_FAIXA (ID, TITULO, DURACAO, ARTISTA) VALUES ('{item.ID}', '{item.TITULO}', {item.DURACAO}, '{item.ARTISTA}')";
                var result = await cn.ExecuteAsync(query);
            }
        }
    }

    ~FaixaRepository() => this.Dispose();
    public void Dispose() => GC.SuppressFinalize(this);
}
