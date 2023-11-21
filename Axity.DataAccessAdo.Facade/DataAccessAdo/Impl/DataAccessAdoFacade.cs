// <summary>
// <copyright file="DataAccessAdoFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Facade.DataAccessAdo.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Services.DataAccessAdo;

    /// <summary>
    /// Class DataAccessAdo Facade.
    /// </summary>
    public class DataAccessAdoFacade : IDataAccessAdoFacade
    {
        private readonly IDataAccessAdoService modelService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessAdoFacade"/> class.
        /// </summary>
        /// <param name="modelService">Interface DataAccessAdo Service.</param>
        public DataAccessAdoFacade(IDataAccessAdoService modelService)
        {
            this.modelService = modelService ?? throw new ArgumentNullException(nameof(modelService));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<DataAccessAdoDto>> GetListDataAccessAdoActive()
        {
            return await this.modelService.GetAllDataAccessAdoAsync();
        }

        /// <inheritdoc/>
        public async Task<DataAccessAdoDto> GetListDataAccessAdoActive(int id)
        {
            return await this.modelService.GetDataAccessAdoAsync(id);
        }

        /// <inheritdoc/>
        public async Task<bool> InsertDataAccessAdo(DataAccessAdoDto model)
        {
            return await this.modelService.InsertDataAccessAdo(model);
        }
    }
}
