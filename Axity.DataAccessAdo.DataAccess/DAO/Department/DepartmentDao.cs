// <summary>
// <copyright file="DepartmentDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.DataAccess.DAO.Department
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Entities.Model;

    /// <summary>
    /// Class deparment.
    /// </summary>
    public class DepartmentDao : IDeparmentDao
    {
        /// <inheritdoc/>
        public Task<int> Create(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> CreateSp(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetAllSp()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetByIdSp(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetInjection(string description)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetPaginator(int page, int size)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> Update(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
