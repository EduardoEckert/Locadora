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
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
        }


    }
}
