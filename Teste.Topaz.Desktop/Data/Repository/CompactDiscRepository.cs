using Dapper;
using System.Text;
using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.DTO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Teste.Topaz.Desktop.Data.Repository;

public class CompactDiscRepository : BaseRepository<CompactDiscEntity>, ICompactDiscRepository
{
    private readonly DataContext _dataContext;
    public CompactDiscRepository(DataContext dataContext) : base(dataContext) =>
        this._dataContext = dataContext;

    public async Task<List<DiscoDTO>> GetAllDiscDapperAsync()
    {
        try
        {
            var query = @"SELECT
	                        A.TITULO,
	                        B.NOME 'GENERO',
                            CAST(A.DATA_CADASTRO AS DATE) 'DATA'
                        FROM TOPAZ.TB_COMPACT_DISC A
                        INNER JOIN TOPAZ.TB_GENERO B ON A.TB_GENERO_ID = B.ID
                        INNER JOIN TOPAZ.TB_FAIXA C ON A.TB_FAIXA_ID = C.ID
                        GROUP BY
	                        A.TITULO,
	                        B.NOME,
                            CAST(A.DATA_CADASTRO AS DATE)";

            var result = await QueryAsync(query);
            return result.ToList();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task InserirListaAsync(List<CompactDiscEntity> list)
    {
        foreach (var item in list)
        {
            var query = @$"INSERT INTO TOPAZ.TB_COMPACT_DISC (ID, TB_FAIXA_ID, TB_GENERO_ID, TITULO) 
                            VALUES(
                                '{item.ID}', 
                                '{item.TB_FAIXA_ID}', 
                                '{item.TB_GENERO_ID}', 
                                '{item.TITULO}');";
            var result = await ExecuteAsync(query);
        }
    }

    public async Task<List<DiscoDTO>> BuscaDiscoAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa)
    {
        try
        {
            var query = @"SELECT
                A.TITULO,
                C.TITULO 'MUSICA',
                C.ARTISTA,
                C.DURACAO,
                B.NOME 'GENERO',
                CAST(A.DATA_CADASTRO AS DATE) 'DATA'
            FROM TOPAZ.TB_COMPACT_DISC A
            INNER JOIN TOPAZ.TB_GENERO B ON A.TB_GENERO_ID = B.ID
            INNER JOIN TOPAZ.TB_FAIXA C ON A.TB_FAIXA_ID = C.ID 
            WHERE 1=1 ";

            if (string.IsNullOrWhiteSpace(tituloAlbum) is false)
                query += $"AND A.TITULO LIKE '%{tituloAlbum}%' ";
            if (string.IsNullOrWhiteSpace(artista) is false)
                query += $"AND C.ARTISTA LIKE '%{artista}%' ";
            if (string.IsNullOrWhiteSpace(genero) is false)
                query += $"AND B.NOME LIKE '%{genero}%' ";
            if (string.IsNullOrWhiteSpace(tituloFaixa) is false)
                query += $"AND C.TITULO LIKE '%{tituloFaixa}%' ";
            //query += "FOR JSON PATH;";

            var result = await QueryAsync(query);
            return result.ToList();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<List<DiscoDTO>> BuscaPorFiltroAsync(string? tituloAlbum, string? artista, string? genero, string? tituloFaixa)
    {
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT ");
            sb.AppendLine("A.TITULO, ");
            sb.AppendLine("B.NOME 'GENERO', ");
            sb.AppendLine("CAST(A.DATA_CADASTRO AS DATE) 'CADASTRO' ");
            sb.AppendLine("FROM TOPAZ.TB_COMPACT_DISC A ");
            sb.AppendLine("INNER JOIN TOPAZ.TB_GENERO B ON A.TB_GENERO_ID = B.ID ");
            sb.AppendLine("INNER JOIN TOPAZ.TB_FAIXA C ON A.TB_FAIXA_ID = C.ID ");
            sb.AppendLine("WHERE 1=1 ");

            if (string.IsNullOrWhiteSpace(tituloAlbum) is false)
                sb.AppendLine($"AND A.TITULO LIKE '%{tituloAlbum}%' ");
            if (string.IsNullOrWhiteSpace(artista) is false)
                sb.AppendLine($"AND C.ARTISTA LIKE '%{artista}%' ");
            if (string.IsNullOrWhiteSpace(genero) is false)
                sb.AppendLine($"AND B.NOME LIKE '%{genero}%' ");
            if (string.IsNullOrWhiteSpace(tituloFaixa) is false)
                sb.AppendLine($"AND C.TITULO LIKE '%{tituloFaixa}%' ");

            sb.AppendLine("GROUP BY  ");
            sb.AppendLine("A.TITULO, ");
            sb.AppendLine("B.NOME, ");
            sb.AppendLine("CAST(A.DATA_CADASTRO AS DATE) ");

            var result = await QueryAsync(sb.ToString());
            return result.ToList();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private async Task<IEnumerable<DiscoDTO>> QueryAsync(string query)
    {
        try
        {
            using (var cn = this._dataContext.CreateConnection())
            {
                await cn.OpenAsync();
                var result = await cn.QueryAsync<DiscoDTO>(query);
                return result;
            }
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    private async Task<int> ExecuteAsync(string query)
    {
        using (var cn = this._dataContext.CreateConnection())
        {
            cn.Open();
            return await cn.ExecuteAsync(query);
        }
    }

    ~CompactDiscRepository() => this.Dispose();
    public void Dispose() => GC.SuppressFinalize(this);
}