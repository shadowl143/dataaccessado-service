// <summary>
// <copyright file="IDataAccessAdoService.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Services.DataAccessAdo
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;

    /// <summary>
    /// Interface DataAccessAdo Service.
    /// </summary>
    public interface IDataAccessAdoService
    {
        /// <summary>
        /// Method for get all users from db.
        /// </summary>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<IEnumerable<DataAccessAdoDto>> GetAllDataAccessAdoAsync();

        /// <summary>
        /// Method for get DataAccessAdo by id from db.
        /// </summary>
        /// <param name="id">User Id.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<DataAccessAdoDto> GetDataAccessAdoAsync(int id);

        /// <summary>
        /// Method for add DataAccessAdo to DB.
        /// </summary>
        /// <param name="model">DataAccessAdo Dto.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        Task<bool> InsertDataAccessAdo(DataAccessAdoDto model);
    }
}
