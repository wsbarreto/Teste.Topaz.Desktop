using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Data.Mapping;

public class GeneroMapping : IEntityTypeConfiguration<GeneroEntity>
{
    public void Configure(EntityTypeBuilder<GeneroEntity> builder)
    {
        builder.ToTable("TB_GENERO");

        builder.HasKey(w => w.ID);

        builder.Property(w => w.NOME)
            .HasColumnName("NOME")
            .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                .IsRequired();

        builder.Property(w => w.DATA_CADASTRO)
            .HasColumnName("DATA_CADASTRO")
            .HasColumnType("DATETIME")
                .IsRequired();

        //builder.Navigation(w => w.CompactDisc)
            //.AutoInclude();
    }
}
