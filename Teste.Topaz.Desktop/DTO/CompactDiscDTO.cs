using AutoMapper;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.DTO;

public class CompactDiscDTO
{
    public Guid ID { get; set; }
    public Guid TB_FAIXA_ID { get; set; }
    public Guid TB_GENERO_ID { get; set; }
    public string TITULO { get; set; }
    public DateTime DATA_CADASTRO { get; set; }

    //public virtual IList<FaixaDTO> Faixas { get; set; }
    //public virtual GeneroDTO Genero { get; set; }

    public CompactDiscDTO()
    {
        ID = Guid.NewGuid();
        DATA_CADASTRO = DateTime.Now;
        //Faixas = new List<FaixaDTO>();
        //Genero = new GeneroDTO();
    }

    public CompactDiscEntity ConvertDtoToEntity(IMapper mapper) => mapper.Map<CompactDiscEntity>(this);
    public CompactDiscDTO ConvertEntityToDto(IMapper mapper, CompactDiscDTO discEntity) => mapper.Map<CompactDiscDTO>(discEntity);
}