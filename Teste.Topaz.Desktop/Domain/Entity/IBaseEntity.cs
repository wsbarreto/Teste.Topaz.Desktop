namespace Teste.Topaz.Desktop.Domain.Entity;

public interface IBaseEntity
{
    Guid ID { get; set; }
    DateTime DATA_CADASTRO { get; set; }
}
