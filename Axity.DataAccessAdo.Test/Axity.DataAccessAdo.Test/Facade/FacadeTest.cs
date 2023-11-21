// <summary>
// <copyright file="FacadeTest.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Test.Facade
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Moq;
    using NUnit.Framework;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Facade.DataAccessAdo.Impl;
    using Axity.DataAccessAdo.Services.DataAccessAdo;

    /// <summary>
    /// Class DataAccessAdoServiceTest.
    /// </summary>
    [TestFixture]
    public class FacadeTest : BaseTest
    {
        private DataAccessAdoFacade modelFacade;

        /// <summary>
        /// The init.
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            var mockServices = new Mock<IDataAccessAdoService>();
            var model = this.GetDataAccessAdoDto();
            IEnumerable<DataAccessAdoDto> listDataAccessAdo = new List<DataAccessAdoDto> { model };

            mockServices
                .Setup(m => m.GetAllDataAccessAdoAsync())
                .Returns(Task.FromResult(listDataAccessAdo));

            mockServices
                .Setup(m => m.GetDataAccessAdoAsync(It.IsAny<int>()))
                .Returns(Task.FromResult(model));

            mockServices
                .Setup(m => m.InsertDataAccessAdo(It.IsAny<DataAccessAdoDto>()))
                .Returns(Task.FromResult(true));

            this.modelFacade = new DataAccessAdoFacade(mockServices.Object);
        }

        /// <summary>
        /// Test for selecting all models.
        /// </summary>
        /// <returns>nothing.</returns>
        [Test]
        public async Task GetAllDataAccessAdoAsyncTest()
        {
            // arrange

            // Act
            var response = await this.modelFacade.GetListDataAccessAdoActive();

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response.Any());
        }

        /// <summary>
        /// gets the model.
        /// </summary>
        /// <returns>the model with the correct id.</returns>
        [Test]
        public async Task GetListDataAccessAdoActive()
        {
            // arrange
            var id = 10;

            // Act
            var response = await this.modelFacade.GetListDataAccessAdoActive(id);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(id, response.Id);
        }

        /// <summary>
        /// Test for inseting models.
        /// </summary>
        /// <returns>the bool if it was inserted.</returns>
        [Test]
        public async Task InsertDataAccessAdo()
        {
            // Arrange
            var model = new DataAccessAdoDto();

            // Act
            var response = await this.modelFacade.InsertDataAccessAdo(model);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(response);
        }
    }
}
