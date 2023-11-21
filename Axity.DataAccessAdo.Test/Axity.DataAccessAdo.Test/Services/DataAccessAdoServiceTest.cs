// <summary>
// <copyright file="DataAccessAdoServiceTest.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Test.Services.DataAccessAdo
{
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Axity.DataAccessAdo.DataAccess.DAO.DataAccessAdo;
    using Axity.DataAccessAdo.Entities.Context;
    using Axity.DataAccessAdo.Services.Mapping;
    using Axity.DataAccessAdo.Services.DataAccessAdo;
    using Axity.DataAccessAdo.Services.DataAccessAdo.Impl;
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;

    /// <summary>
    /// Class DataAccessAdoServiceTest.
    /// </summary>
    [TestFixture]
    public class DataAccessAdoServiceTest : BaseTest
    {
        private IDataAccessAdoService modelServices;

        private IMapper mapper;

        private IDataAccessAdoDao modelDao;

        private DatabaseContext context;

        /// <summary>
        /// Init configuration.
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            this.mapper = mapperConfiguration.CreateMapper();

            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Temporal")
                .Options;

            this.context = new DatabaseContext(options);
            this.context.CatDataAccessAdo.AddRange(this.GetAllDataAccessAdos());
            this.context.SaveChanges();

            this.modelDao = new DataAccessAdoDao(this.context);
            this.modelServices = new DataAccessAdoService(this.mapper, this.modelDao);
        }

        /// <summary>
        /// Method to verify Get All DataAccessAdos.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task ValidateGetAllDataAccessAdos()
        {
            var result = await this.modelServices.GetAllDataAccessAdoAsync();

            Assert.True(result != null);
            Assert.True(result.Any());
        }

        /// <summary>
        /// Method to validate get model by id.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task ValidateSpecificDataAccessAdos()
        {
            var result = await this.modelServices.GetDataAccessAdoAsync(2);

            Assert.True(result != null);
            Assert.True(result.FirstName == "Jorge");
        }

        /// <summary>
        /// test the insert.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task InsertDataAccessAdo()
        {
            // Arrange
            var model = this.GetDataAccessAdoDto();

            // Act
            var result = await this.modelServices.InsertDataAccessAdo(model);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }
    }
}
