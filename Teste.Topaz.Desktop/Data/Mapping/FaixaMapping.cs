using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Data.Mapping;

public class FaixaMapping : IEntityTypeConfiguration<FaixaEntity>
{
    public void Configure(EntityTypeBuilder<FaixaEntity> builder)
    {
        builder.ToTable("TB_FAIXA");

        builder.HasKey(w => w.ID);

        builder.Property(w => w.TITULO)
            .HasColumnName("TITULO")
            .HasColumnType("NVARCHAR")
                .HasMaxLength(50)
                .IsRequired();

        builder.Property(w => w.DURACAO)
            .HasColumnName("DURACAO")
            .HasColumnType("DECIMAL")
            .HasConversion(w => ((decimal)w), w => w)
                .HasPrecision(3, 2)
                .IsRequired();

        builder.Property(w => w.DATA_CADASTRO)
            .HasColumnName("DATA_CADASTRO")
            .HasColumnType("DATETIME")
                .IsRequired();

        //builder.Navigation(w => w.CompactDisc)
        //    .AutoInclude();
    }
}
