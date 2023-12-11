using System.Text.Json.Nodes;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop.Domain.Interface.Service;

public interface ICompactDiscService : IBaseService<CompactDiscEntity>
{
    Task<List<DiscoDTO>> GetAllDiscDapperAsync();
    Task InserirListaAsync(List<CompactDiscEntity> list);
    Task<List<DiscoDTO>> BuscaPorFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa);
    Task<List<DiscoDTO>> BuscaDiscoAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa);
}
