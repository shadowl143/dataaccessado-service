// <summary>
// <copyright file="DeparmentService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Services.Deparment.Impl
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.DataAccess.DAO.Department;
    using Axity.DataAccessAdo.Dtos.Deparment;
    using Axity.DataAccessAdo.Entities.Model;
    using Axity.DataAccessAdo.Services.Deparment;

    /// <summary>
    /// DeparmentService.
    /// </summary>
    public class DeparmentService : IDeparmentService
    {
        private readonly IDeparmentDao modelDao;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeparmentService"/> class.
        /// </summary>
        /// <param name="modelDao">model dao.</param>
        public DeparmentService(IDeparmentDao modelDao)
        {
            this.modelDao = modelDao;
        }

        /// <inheritdoc/>
        public async Task<int> Create(DeparmentDto model)
        {
            var deparmentModel = new DeparmentModel
            {
                Id = model.Id,
                Budget = model.Budget,
                Administratr = model.Administrator,
                Name = model.Name,
                StartDate = model.Date,
            };

            return await this.modelDao.Create(deparmentModel);
        }

        /// <inheritdoc/>
        public Task<int> CreateSp(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<List<DeparmentDto>> GetAll()
        {
            var deparmentModel = await this.modelDao.GetAll();
            var model = new List<DeparmentDto>();
            foreach (var item in deparmentModel)
            {
                model.Add(new DeparmentDto
                {
                    Id = item.Id,
                    Administrator = item.Administratr,
                    Budget = item.Budget,
                    Date = item.StartDate,
                    Name = item.Name,
                });
            }

            return model;
        }

        /// <inheritdoc/>
        public async Task<List<DeparmentDto>> GetAllSp()
        {
            throw new System.NotImplementedException();

        }

        /// <inheritdoc/>
        public async Task<DeparmentDto> GetById(int id)
        {
            // var deparmentModel = await this.modelDao.GetById(id);
              var deparmentModel = await this.modelDao.GetByIdSp(id);
            return new DeparmentDto
            {
                Id = deparmentModel.Id,
                Administrator = deparmentModel.Administratr,
                Budget = deparmentModel.Budget,
                Date = deparmentModel.StartDate,
                Name = deparmentModel.Name,
            };
        }

        /// <inheritdoc/>
        public async Task<DeparmentDto> GetByIdSp(int id)
        {
            var deparmentModel = await this.modelDao.GetByIdSp(id);
            return new DeparmentDto
            {
                Id = deparmentModel.Id,
                Administrator = deparmentModel.Administratr,
                Budget = deparmentModel.Budget,
                Date = deparmentModel.StartDate,
                Name = deparmentModel.Name,
            };
        }

        /// <inheritdoc/>
        public async Task<List<DeparmentDto>> GetInjection(string description)
        {
            var deparmentModel = await this.modelDao.GetInjection(description);
            var model = new List<DeparmentDto>();
            foreach (var item in deparmentModel)
            {
                model.Add(new DeparmentDto
                {
                    Id = item.Id,
                    Administrator = item.Administratr,
                    Budget = item.Budget,
                    Date = item.StartDate,
                    Name = item.Name,
                });
            }

            return model;
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetPaginator(int page, int size)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> Update(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
