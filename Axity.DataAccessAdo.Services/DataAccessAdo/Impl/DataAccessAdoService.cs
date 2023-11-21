// <summary>
// <copyright file="DataAccessAdoService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Services.DataAccessAdo.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Axity.DataAccessAdo.DataAccess.DAO.DataAccessAdo;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Entities.Model;

    /// <summary>
    /// Class DataAccessAdo Service.
    /// </summary>
    public class DataAccessAdoService : IDataAccessAdoService
    {
        private readonly IMapper mapper;

        private readonly IDataAccessAdoDao modelDao;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessAdoService"/> class.
        /// </summary>
        /// <param name="mapper">Object to mapper.</param>
        /// <param name="modelDao">Object to modelDao.</param>
        public DataAccessAdoService(IMapper mapper, IDataAccessAdoDao modelDao)
        {
            this.mapper = mapper;
            this.modelDao = modelDao ?? throw new ArgumentNullException(nameof(modelDao));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<DataAccessAdoDto>> GetAllDataAccessAdoAsync()
        {
            return this.mapper.Map<List<DataAccessAdoDto>>(await this.modelDao.GetAllDataAccessAdoAsync());
        }

        /// <inheritdoc/>
        public async Task<DataAccessAdoDto> GetDataAccessAdoAsync(int id)
        {
            return this.mapper.Map<DataAccessAdoDto>(await this.modelDao.GetDataAccessAdoAsync(id));
        }

        /// <inheritdoc/>
        public async Task<bool> InsertDataAccessAdo(DataAccessAdoDto model)
        {
            return await this.modelDao.InsertDataAccessAdo(this.mapper.Map<DataAccessAdoModel>(model));
        }
    }
}
