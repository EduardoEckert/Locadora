using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Locadora.DependencyInjection
{
    public class DependencyInjection
    {
        protected DependencyInjection() { }

        public static void AddDependencyInjection(IServiceCollection services)
        {
            AddContextDependecyInjection(services);
        }

        private static void AddContextDependecyInjection(IServiceCollection services)
        {
            services.AddScoped<DbContext, MyContext>();
        }
    }
}
