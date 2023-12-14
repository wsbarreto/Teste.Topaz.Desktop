using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Teste.Topaz.Desktop.Data.Context;
using Teste.Topaz.Desktop.Data.Repository;
using Teste.Topaz.Desktop.Domain.Entity;
using Teste.Topaz.Desktop.Domain.Interface.Repository;
using Teste.Topaz.Desktop.Domain.Interface.Service;
using Teste.Topaz.Desktop.DTO;
using Teste.Topaz.Desktop.Service;

namespace Teste.Topaz.Desktop;

internal static class Program
{
    private static string connectionString = "Data Source=localhost;Initial Catalog=DIVERSOS_TESTES;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;User Id=sa;Password=teste1234;";
    private static IMapper _mapper;

    [STAThread]
    static void Main()
    {

        IServiceCollection serviceCollection = new ServiceCollection();
        ConfigureService(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();
        
        var mapper = _mapper;
        var discService = serviceProvider.GetService<ICompactDiscService>();
        var generoService = serviceProvider.GetService<IGeneroService>();
        var faixaService = serviceProvider.GetService<IFaixaService>();

        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain2(discService, generoService, faixaService, mapper));
    }

    public static void ConfigureService(IServiceCollection serviceCollection)
    {
        var configuration = new MapperConfiguration(w =>
        {
            w.CreateMap<CompactDiscEntity, CompactDiscDTO>();
            w.CreateMap<CompactDiscDTO, CompactDiscEntity>();
            w.CreateMap<GeneroEntity, GeneroDTO>();
            w.CreateMap<GeneroDTO, GeneroEntity>();
            w.CreateMap<FaixaEntity, FaixaDTO>();
            w.CreateMap<FaixaDTO, FaixaEntity>();
        });

        _mapper = configuration.CreateMapper();

        serviceCollection.AddSingleton<IMapper, Mapper>();

        serviceCollection.AddScoped<ICompactDiscService, CompactDiscService>()
        .AddScoped<IGeneroService, GeneroService>()
        .AddScoped<IFaixaService, FaixaService>()
        .AddScoped<ICompactDiscRepository, CompactDiscRepository>()
        .AddScoped<IGeneroRepository, GeneroRepository>()
        .AddScoped<IFaixaRepository, FaixaRepository>()
        .AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });
    }
}