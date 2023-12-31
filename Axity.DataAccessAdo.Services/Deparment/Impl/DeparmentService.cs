﻿// <summary>
// <copyright file="DeparmentService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Services.Deparment.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Threading.Tasks;
    using AutoMapper;
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
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeparmentService"/> class.
        /// </summary>
        /// <param name="modelDao">model dao.</param>
        public DeparmentService(IDeparmentDao modelDao, IMapper mapper)
        {
            this.modelDao = modelDao;
            this.mapper = mapper;
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

        public async Task<DepartamentoDto> GetByAutId(int id)
        {
            var modelDto = this.mapper.Map<DepartamentoDto>(await this.modelDao.GetById(id));
            return modelDto;
        }

        /// <inheritdoc/>
        public async Task<DeparmentDto> GetById(int id)
        {
            var deparmentModel = this.mapper.Map<DeparmentDto>(await this.modelDao.GetById(id));
            return deparmentModel;
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
        public async Task<List<DeparmentDto>> GetPaginator(int page, int size)
        {
            var model = new List<DeparmentDto>();
            DataSet ds = await this.modelDao.GetPaginator(page, size);
            DataTable table = ds.Tables[0];
            foreach (DataRow item in table.Rows)
            {
                Console.WriteLine(item);
                model.Add(new DeparmentDto
                {
                    Id = Convert.ToInt32(item[0].ToString()),
                    Administrator = Convert.ToInt32(item[4].ToString()),
                    Budget = Convert.ToDecimal(item[2].ToString()),
                    Date = Convert.ToDateTime(item[3].ToString()),
                    Name = item[1].ToString(),
                });
            }
            return model;
        }

        /// <inheritdoc/>
        public Task<int> Update(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
