namespace Teste.Topaz.Desktop.Domain.Entity;

public class GeneroEntity : IBaseEntity
{
    public Guid ID { get; set; }
    public DateTime DATA_CADASTRO { get; set; }
    public string NOME { get; set; }

    //public virtual IList<CompactDiscEntity> CompactDisc { get; set; }
}