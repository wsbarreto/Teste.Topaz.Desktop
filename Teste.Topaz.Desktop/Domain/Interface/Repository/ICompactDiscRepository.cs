using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop.Domain.Interface.Repository;

public interface ICompactDiscRepository : IBaseRepository<CompactDiscEntity>, IDisposable
{
    Task<List<DiscoDTO>> GetAllDiscDapperAsync();
    Task InserirListaAsync(List<CompactDiscEntity> list);
    Task<List<DiscoDTO>> BuscaPorFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa);
    Task<List<DiscoDTO>> BuscaDiscoAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa);
}
