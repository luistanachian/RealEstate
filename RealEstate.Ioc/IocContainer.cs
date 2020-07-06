using Microsoft.Extensions.DependencyInjection;
using RealEstate.Business.Class;
using RealEstate.Business.Interface;
using RealEstate.Dao.Class;
using RealEstate.Dao.Context;
using RealEstate.Dao.Interface;
using RealEstate.Repository.Class;
using RealEstate.Repository.Interface;

namespace RealEstate.Ioc
{
    public static class IocContainer
    {
        public static void ConfigureIOC(this IServiceCollection services)
        {
            services.AddDbContext<RealEstateContext>();

            services.AddSingleton<IMonedasBusiness, MonedasBusiness>();
            services.AddSingleton<IMonedasRepository, MonedasRepository>();
            services.AddSingleton<IMonedasDao, MonedasDao>();
            services.AddSingleton<IDireccionEstadosBusiness, DireccionEstadosBusiness>();
            services.AddSingleton<IDireccionEstadosRepository, DireccionEstadosRepository>();
            services.AddSingleton<IDireccionEstadosDao, DireccionEstadosDao>();
            services.AddSingleton<IDireccionLocalidadesBusiness, DireccionLocalidadesBusiness>();
            services.AddSingleton<IDireccionLocalidadesRepository, DireccionLocalidadesRepository>();
            services.AddSingleton<IDireccionLocalidadesDao, DireccionLocalidadesDao>();
            services.AddSingleton<IDireccionBarriosBusiness, DireccionBarriosBusiness>();
            services.AddSingleton<IDireccionBarriosRepository, DireccionBarriosRepository>();
            services.AddSingleton<IDireccionBarriosDao, DireccionBarriosDao>();
        }
    }
}