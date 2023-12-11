namespace Teste.Topaz.Desktop.Domain.Entity;

public class FaixaEntity : IBaseEntity
{
    public Guid ID { get; set; }
    public DateTime DATA_CADASTRO { get; set; }
    public string TITULO { get; set; }
    public string ARTISTA { get; set; }
    public decimal DURACAO { get; set; }

    //public virtual CompactDiscEntity CompactDisc { get; set; }
}