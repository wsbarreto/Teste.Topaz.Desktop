using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Teste.Topaz.Desktop.Domain.Entity;

namespace Teste.Topaz.Desktop.Data.Context;

public class DataContext : DbContext
{
    private readonly string connectionString = "Data Source=localhost;Initial Catalog=DIVERSOS_TESTES;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User Id=sa;Password=teste1234;";

    //public IDbConnection CreateConnection() => new SqlConnection(connectionString);
    public SqlConnection CreateConnection() => new SqlConnection(connectionString);

    public DataContext CreateDbContext() => new DataContext(new DbContextOptionsBuilder().UseSqlServer(connectionString).Options);

    public DbSet<CompactDiscEntity> CompactDisc { get; set; }
    public DbSet<FaixaEntity> Faixa { get; set; }
    public DbSet<GeneroEntity> Genero { get; set; }

    public DataContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("TOPAZ");

        var mappingInterface = typeof(IEntityTypeConfiguration<>);
        var mappingTypes = typeof(DataContext).GetTypeInfo().Assembly.GetTypes()
            .Where(w => w.GetInterfaces().Any(b => b.GetTypeInfo().IsGenericType && b.GetGenericTypeDefinition() == mappingInterface));

        var entityMethod = typeof(ModelBuilder).GetMethods()
            .Single(w => w.Name == "Entity" &&
                    w.IsGenericMethod &&
                    w.ReturnType.Name == "EntityTypeBuilder`1");

        mappingTypes.ToList().ForEach((item) =>
        {
            var genericTypeArguments = item.GetInterfaces().Single().GenericTypeArguments.Single();
            var genericEntityMethod = entityMethod.MakeGenericMethod(genericTypeArguments);
            var entityBuilder = genericEntityMethod.Invoke(modelBuilder, null);

            var mapper = Activator.CreateInstance(item);
            mapper.GetType().GetMethod("Configure").Invoke(mapper, new[] { entityBuilder });
        });

        //modelBuilder.Entity<CompactDiscEntity>()
        //.HasMany(e => e.Faixas)
        //.WithOne(e => e.CompactDisc)
        //.HasForeignKey(e => e.ID)
        //.HasPrincipalKey(e => e.TB_FAIXA_ID);

        //modelBuilder.Entity<FaixaEntity>()
        //.HasOne(e => e.CompactDisc)
        //.WithMany(e => e.Faixas)
        //.HasForeignKey(e => e.ID)
        //.HasPrincipalKey(e => e.TB_FAIXA_ID);

        //modelBuilder.Entity<GeneroEntity>()
        //.HasMany(e => e.CompactDisc)
        //.WithOne(e => e.Genero)
        //.HasForeignKey(e => e.TB_GENERO_ID)
        //.HasPrincipalKey(e => e.ID);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Configuração da cadeia de conexão e outras opções

            optionsBuilder.EnableSensitiveDataLogging(); // Habilita o logging de dados sensíveis
        }
    }
}
