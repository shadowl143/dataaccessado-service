// <summary>
// <copyright file="DeparmentFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Facade.Deparment.Impl
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.Deparment;
    using Axity.DataAccessAdo.Dtos.Shared;
    using Axity.DataAccessAdo.Services.Deparment;

    /// <summary>
    /// Deparment facade.
    /// </summary>
    public class DeparmentFacade : IDeparmentFacade
    {
        private readonly IDeparmentService modelService;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeparmentFacade"/> class.
        /// </summary>
        /// <param name="modelService">model service.</param>
        public DeparmentFacade(IDeparmentService modelService)
        {
            this.modelService = modelService;
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<int>> Create(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<int>> CreateSp(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetAllSp()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetByIdSp(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetInjection(string description)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<List<DeparmentDto>>> GetPaginator(int page, int size)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<ServiceResponse<int>> Update(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }
    }
}
