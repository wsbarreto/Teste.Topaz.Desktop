using AutoMapper;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.DTO;

public class FaixaDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public DateTime DATA_CADASTRO { get; set; }
    public string TITULO { get; set; }
    public string ARTISTA { get; set; }
    public decimal DURACAO { get; set; }

    public FaixaDTO()
    {
        this.ID = Guid.NewGuid();
        this.DATA_CADASTRO = DateTime.Now;
    }

    public FaixaEntity ConvertDtoToEntity(IMapper mapper) => mapper.Map<FaixaEntity>(this);
    public static FaixaDTO ConvertEntityToDto(IMapper mapper, FaixaEntity faixaEntity) => mapper.Map<FaixaDTO>(faixaEntity);
    public static List<FaixaDTO> ConvertEntityToDto(IMapper mapper, List<FaixaEntity> faixasEntity) => mapper.Map<List<FaixaDTO>>(faixasEntity);
    public static List<FaixaEntity> ConvertDtoToEntity(IMapper mapper, List<FaixaDTO> faixasDTO) => mapper.Map<List<FaixaEntity>>(faixasDTO);
}