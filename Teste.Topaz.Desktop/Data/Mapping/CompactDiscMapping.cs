using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Data.Mapping;

public class CompactDiscMapping : IEntityTypeConfiguration<CompactDiscEntity>
{
    public void Configure(EntityTypeBuilder<CompactDiscEntity> builder)
    {
        builder.ToTable("TB_COMPACT_DISC");

        builder.HasKey(w => w.ID);

        builder.Property(w => w.TITULO)
            .HasColumnName("TITULO")
            .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                .IsRequired();

        builder.Property(w => w.TB_FAIXA_ID)
            .HasColumnName("TB_FAIXA_ID")
            .HasColumnType("UNIQUEIDENTIFIER")
                .IsRequired();

        builder.Property(w => w.TB_GENERO_ID)
            .HasColumnName("TB_GENERO_ID")
            .HasColumnType("UNIQUEIDENTIFIER")
                .IsRequired();

        builder.Property(w => w.DATA_CADASTRO)
            .HasColumnName("DATA_CADASTRO")
            .HasColumnType("DATETIME")
                .IsRequired();

        //builder.Navigation(w => w.Faixas)
        //    .AutoInclude();

        //builder.Navigation(w => w.Genero)
        //    .AutoInclude();

    }
}
