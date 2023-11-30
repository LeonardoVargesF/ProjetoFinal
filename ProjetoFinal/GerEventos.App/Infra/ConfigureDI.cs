using AutoMapper;
using GerEventos.App.Cadastros;
using GerEventos.App.Models;
using GerEventos.Domain.Base;
using GerEventos.Domain.Entities;
using GerEventos.Repository.Context;
using GerEventos.Repository.Repository;
using GerEventos.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;


namespace GerEventos.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;

        public static ServiceProvider? ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DataBaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Evento>, BaseRepository<Evento>>();
            Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<EventoPalestrante>, BaseRepository<EventoPalestrante>>();
            Services.AddScoped<IBaseRepository<Palestrante>, BaseRepository<Palestrante>>();
            Services.AddScoped<IBaseRepository<Participante>, BaseRepository<Participante>>();

            // Services
            Services.AddScoped<IBaseService<Evento>, BaseService<Evento>>();
            Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<EventoPalestrante>, BaseService<EventoPalestrante>>();
            Services.AddScoped<IBaseService<Palestrante>, BaseService<Palestrante>>();
            Services.AddScoped<IBaseService<Participante>, BaseService<Participante>>();

            // Formulários
            
            Services.AddTransient<CadastroEvento, CadastroEvento>();
            Services.AddTransient<CadastroPalestrante, CadastroPalestrante>();
            Services.AddTransient<CadastroParticipante, CadastroParticipante>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroInscricao, CadastroInscricao>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                /*
                config.CreateMap<Cidade, CidadeModel>()
                    .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));
                config.CreateMap<Evento, EventoModel>()
                    .ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    .ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));
                config.CreateMap<Grupo, Grupo>();
                config.CreateMap<Produto, ProdutoModel>()
                    .ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                    .ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));
                config.CreateMap<Venda, VendaModel>()
                    .ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    .ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                config.CreateMap<VendaItem, VendaItemModel>()
                    .ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    .ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));
            */
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
