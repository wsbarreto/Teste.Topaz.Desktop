using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;

namespace Teste.Topaz.Desktop.Service;

public class CompactDiscService : BaseService<CompactDiscEntity>, ICompactDiscService
{
    private readonly ICompactDiscRepository _repository;
    public CompactDiscService(ICompactDiscRepository repository) : base(repository) =>
        this._repository = repository;

    public async Task<List<DiscoDTO>> GetAllDiscDapperAsync() => await this._repository.GetAllDiscDapperAsync();
    public async Task InserirListaAsync(List<CompactDiscEntity> list) => await this._repository.InserirListaAsync(list);
    public async Task<List<DiscoDTO>> BuscaPorFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa) => await this._repository.BuscaPorFiltroAsync(tituloAlbum, artista, genero, tituloFaixa);
    public async Task<List<DiscoDTO>> BuscaDiscoAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa) => await this._repository.BuscaDiscoAsync(tituloAlbum, artista, genero, tituloFaixa);

}