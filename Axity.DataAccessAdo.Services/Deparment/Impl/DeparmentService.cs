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
    using Axity.DataAccessAdo.Dtos.Deparment;
    using Axity.DataAccessAdo.Services.Deparment;

    /// <summary>
    /// DeparmentService.
    /// </summary>
    public class DeparmentService : IDeparmentService
    {
        private readonly IDeparmentService modelDao;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeparmentService"/> class.
        /// </summary>
        /// <param name="modelDao">model dao.</param>
        public DeparmentService(IDeparmentService modelDao)
        {
            this.modelDao = modelDao;
        }

        /// <inheritdoc/>
        public Task<int> Create(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> CreateSp(DeparmentDto model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetAllSp()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetByIdSp(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentDto>> GetInjection(string description)
        {
            throw new System.NotImplementedException();
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
