using Application.Services;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;
using Persistence.Repositories;

namespace Locadora.DependencyInjection
{
    public class DependencyInjection
    {
        protected DependencyInjection() { }

        public static void AddDependencyInjection(IServiceCollection services)
        {
            AddServices(services);
            AddRepositories(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<ITelefoneService, TelefoneService>();
            services.AddScoped<IGeneroService, GeneroService>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            services.AddScoped<IGeneroRepository, GeneroRepository>();
        }


    }
}
