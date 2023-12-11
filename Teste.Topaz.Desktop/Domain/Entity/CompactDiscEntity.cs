namespace Teste.Topaz.Desktop.Domain.Entity;

public class CompactDiscEntity
{
    public Guid ID { get; set; }
    public Guid TB_FAIXA_ID { get; set; }
    public Guid TB_GENERO_ID { get; set; }
    public string TITULO { get; set; }
    public DateTime DATA_CADASTRO { get; set; }

    //public virtual IList<FaixaEntity> Faixas { get; set; }
    //public virtual GeneroEntity Genero { get; set; }
}