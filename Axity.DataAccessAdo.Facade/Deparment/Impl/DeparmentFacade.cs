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
        public async Task<ServiceResponse<int>> Create(DeparmentDto model)
        {
            return new ServiceResponse<int>(await this.modelService.Create(model));

        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<int>> CreateSp(DeparmentDto model)
        {
            return new ServiceResponse<int>(await this.modelService.CreateSp(model));

        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<List<DeparmentDto>>> GetAll()
        {
            return new ServiceResponse<List<DeparmentDto>>(await this.modelService.GetAll());
        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<List<DeparmentDto>>> GetAllSp()
        {
            return new ServiceResponse<List<DeparmentDto>>(await this.modelService.GetAllSp());
        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<DeparmentDto>> GetById(int id)
        {
            return new ServiceResponse<DeparmentDto>(await this.modelService.GetById(id));

        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<DeparmentDto>> GetByIdSp(int id)
        {
            return new ServiceResponse<DeparmentDto>(await this.modelService.GetByIdSp(id));

        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<List<DeparmentDto>>> GetInjection(string description)
        {
            return new ServiceResponse<List<DeparmentDto>>(await this.modelService.GetAllSp());

        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<List<DeparmentDto>>> GetPaginator(int page, int size)
        {
            return new ServiceResponse<List<DeparmentDto>>(await this.modelService.GetPaginator(page, size));
        }

        /// <inheritdoc/>
        public async Task<ServiceResponse<int>> Update(DeparmentDto model)
        {
            return new ServiceResponse<int>(await this.modelService.Update(model));

        }
    }
}
