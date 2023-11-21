// <summary>
// <copyright file="DataAccessAdoDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.DataAccess.DAO.DataAccessAdo
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Axity.DataAccessAdo.Entities.Context;
    using Axity.DataAccessAdo.Entities.Model;

    /// <summary>
    /// Class DataAccessAdo Dao.
    /// </summary>
    public class DataAccessAdoDao : IDataAccessAdoDao
    {
        private readonly IDatabaseContext databaseContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessAdoDao"/> class.
        /// </summary>
        /// <param name="databaseContext">DataBase Context.</param>
        public DataAccessAdoDao(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<DataAccessAdoModel>> GetAllDataAccessAdoAsync()
        {
            return await this.databaseContext.CatDataAccessAdo.ToListAsync();
        }

        /// <inheritdoc/>
        public async Task<DataAccessAdoModel> GetDataAccessAdoAsync(int id)
        {
            return await this.databaseContext.CatDataAccessAdo.FirstOrDefaultAsync(p => p.Id.Equals(id));
        }

        /// <inheritdoc/>
        public async Task<bool> InsertDataAccessAdo(DataAccessAdoModel model)
        {
            var response = await this.databaseContext.CatDataAccessAdo.AddAsync(model);
            bool result = response.State.Equals(EntityState.Added);
            await ((DatabaseContext)this.databaseContext).SaveChangesAsync();
            return result;
        }
    }
}
