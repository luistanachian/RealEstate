﻿using Microsoft.Extensions.DependencyInjection;
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

            services.AddTransient<IMonedasBusiness, MonedasBusiness>();
            services.AddTransient<IMonedasRepository, MonedasRepository>();
            services.AddTransient<IMonedasDao, MonedasDao>();

            services.AddTransient<IDireccionPaisesBusiness, DireccionPaisesBusiness>();
            services.AddTransient<IDireccionPaisesRepository, DireccionPaisesRepository>();
            services.AddTransient<IDireccionPaisesDao, DireccionPaisesDao>();
        }
    }
}