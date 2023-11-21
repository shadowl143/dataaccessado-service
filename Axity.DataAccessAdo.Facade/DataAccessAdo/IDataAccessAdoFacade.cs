// <summary>
// <copyright file="IDataAccessAdoFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Facade.DataAccessAdo
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;

    /// <summary>
    /// Interface User Facade.
    /// </summary>
    public interface IDataAccessAdoFacade
    {
        /// <summary>
        /// Method for get all list of Users.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<DataAccessAdoDto>> GetListDataAccessAdoActive();

        /// <summary>
        /// Method for get User by id.
        /// </summary>
        /// <param name="id">Id User.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<DataAccessAdoDto> GetListDataAccessAdoActive(int id);

        /// <summary>
        /// Method to add user to DB.
        /// </summary>
        /// <param name="model">User Model.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertDataAccessAdo(DataAccessAdoDto model);
    }
}