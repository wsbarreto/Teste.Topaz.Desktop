﻿using Dapper;
using System.Data.SqlClient;
using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
                var query = @$"INSERT INTO TOPAZ.TB_FAIXA (ID, TITULO, DURACAO, ARTISTA) VALUES (@ID, @TITULO, @DURACAO, @ARTISTA)";
                using (SqlCommand command = new SqlCommand(query, cn))
                {
                    command.Parameters.AddWithValue("@ID", item.ID);
                    command.Parameters.AddWithValue("@TITULO", item.TITULO);
                    command.Parameters.AddWithValue("@DURACAO", item.DURACAO);
                    command.Parameters.AddWithValue("@ARTISTA", item.ARTISTA);

                    command.ExecuteNonQuery();
                }
            }
        }
    }

    ~FaixaRepository() => this.Dispose();
    public void Dispose() => GC.SuppressFinalize(this);
}
