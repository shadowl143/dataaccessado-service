// <summary>
// <copyright file="IDataAccessAdoDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.DataAccess.DAO.DataAccessAdo
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Entities.Model;

    /// <summary>
    /// Interface IUserDao.
    /// </summary>
    public interface IDataAccessAdoDao
    {
        /// <summary>
        /// Method for get all users from db.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<DataAccessAdoModel>> GetAllDataAccessAdoAsync();

        /// <summary>
        /// Method for get user by id from db.
        /// </summary>
        /// <param name="id">DataAccessAdo Id.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<DataAccessAdoModel> GetDataAccessAdoAsync(int id);

        /// <summary>
        /// Method for add DataAccessAdo to DB.
        /// </summary>
        /// <param name="model">DataAccessAdo Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertDataAccessAdo(DataAccessAdoModel model);
    }
}
