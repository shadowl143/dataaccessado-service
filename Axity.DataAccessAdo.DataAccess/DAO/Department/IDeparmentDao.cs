// <summary>
// <copyright file="IDeparmentDao.cs" company="Axity">
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
    /// Interface deparmentDao.
    /// </summary>
    public interface IDeparmentDao
    {
        /// <summary>
        /// Get all rows.
        /// </summary>
        /// <returns>list deparment.</returns>
        Task<List<DeparmentModel>> GetAll();

        /// <summary>
        /// Get by id deparment rows.
        /// </summary>
        /// <param name="id">deparment id.</param>
        /// <returns>deparment.</returns>
        Task<DeparmentModel> GetById(int id);

        /// <summary>
        /// Example of injection dependicy.
        /// </summary>
        /// <param name="description">description for inyection dependicy.</param>
        /// <returns>deparment.</returns>
        Task<List<DeparmentModel>> GetInjection(string description);

        /// <summary>
        /// Get paginator.
        /// </summary>
        /// <param name="page">int page.</param>
        /// <param name="size">int size.</param>
        /// <returns>deparment.</returns>
        Task<List<DeparmentModel>> GetPaginator(int page, int size);

        /// <summary>
        /// Create new deparment.
        /// </summary>
        /// <param name="model">data for create document.</param>
        /// <returns>deparment.</returns>
        Task<int> Create(DeparmentModel model);

        /// <summary>
        /// Update deparment.
        /// </summary>
        /// <param name="model">data for create document.</param>
        /// <returns>deparment.</returns>
        Task<int> Update(DeparmentModel model);

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <returns>deparment.</returns>
        Task<List<DeparmentModel>> GetAllSp();

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <param name="id">int id.</param>
        /// <returns>deparment.</returns>
        Task<DeparmentModel> GetByIdSp(int id);

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <param name="model">model for created.</param>
        /// <returns>deparment.</returns>
        Task<int> CreateSp(DeparmentModel model);
    }
}
