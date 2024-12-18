using APIeSistemTreinamento.Repository;

namespace APIeSistemTreinamento.Data.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<EmpresaRepository>();
            services.AddScoped<UsuarioRepository>();
            services.AddScoped<CfopRepository>();
            services.AddScoped<CidadeRepository>();
            services.AddScoped<PessoaRepository>();
            services.AddScoped<UfRepository>();
            services.AddScoped<UnidadeRepository>();

            return services;
        }
    }
}
