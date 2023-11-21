// <summary>
// <copyright file="DependencyInjector.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.DependencyInjection
{
    using AutoMapper;
    using Axity.DataAccessAdo.DataAccess.DAO.DataAccessAdo;
    using Axity.DataAccessAdo.Entities.Context;
    using Axity.DataAccessAdo.Facade.DataAccessAdo;
    using Axity.DataAccessAdo.Facade.DataAccessAdo.Impl;
    using Axity.DataAccessAdo.Services.Mapping;
    using Axity.DataAccessAdo.Services.DataAccessAdo;
    using Axity.DataAccessAdo.Services.DataAccessAdo.Impl;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// Class for DependencyInjector.
    /// </summary>
    public static class DependencyInjector
    {
        private static IServiceCollection Services { get; set; }

        /// <summary>
        /// Method to register Services.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <returns>Interface Service Collection.</returns>
        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;
            Services.AddTransient<IDataAccessAdoFacade, DataAccessAdoFacade>();
            Services.AddTransient<IDataAccessAdoService, DataAccessAdoService>();
            Services.AddTransient<IDataAccessAdoDao, DataAccessAdoDao>();
            Services.AddTransient<IDatabaseContext, DatabaseContext>();
            return Services;
        }

        /// <summary>
        /// Method to add Db Context.
        /// </summary>
        /// <param name="configuration">Configuration Options.</param>
        public static void AddDbContext(IConfiguration configuration)
        {
            Services.AddDbContextPool<DatabaseContext>(options => options.UseSqlServer(configuration.GetConnectionString(nameof(DatabaseContext))));
        }

        /// <summary>
        /// Add configuration Auto Mapper.
        /// </summary>
        public static void AddAutoMapper()
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new AutoMapperProfile()); });
            Services.AddSingleton(mappingConfig.CreateMapper());
        }
    }
}
