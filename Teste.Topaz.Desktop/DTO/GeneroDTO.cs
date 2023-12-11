using AutoMapper;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.DTO;

public class GeneroDTO : IBaseDTO
{
    public Guid ID { get; set; }
    public DateTime DATA_CADASTRO { get; set; }
    public string NOME { get; set; }

    public GeneroDTO()
    {
        ID = Guid.NewGuid();
        DATA_CADASTRO = DateTime.Now;
    }

    public GeneroEntity ConvertDtoToEntity(IMapper mapper) => mapper.Map<GeneroEntity>(this);
    public static GeneroDTO ConvertEntityToDto(IMapper mapper, GeneroEntity faixaEntity) => mapper.Map<GeneroDTO>(faixaEntity);
    public static List<GeneroDTO> ConvertListEntityToListDto(IMapper mapper, List<GeneroEntity> faixasEntity) => mapper.Map<List<GeneroDTO>>(faixasEntity);
    public static List<GeneroEntity> ConvertListDtoToListEntity(IMapper mapper, List<GeneroDTO> faixasDTO) => mapper.Map<List<GeneroEntity>>(faixasDTO);
}