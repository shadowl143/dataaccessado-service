// <summary>
// <copyright file="IDeparmentFacade.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Facade.Deparment
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.Deparment;
    using Axity.DataAccessAdo.Dtos.Shared;

    /// <summary>
    /// Interface deparment.
    /// </summary>
    public interface IDeparmentFacade
    {
        /// <summary>
        /// Get all rows.
        /// </summary>
        /// <returns>list deparment.</returns>
        Task<ServiceResponse<List<DeparmentDto>>> GetAll();

        /// <summary>
        /// Get by id deparment rows.
        /// </summary>
        /// <param name="id">deparment id.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<DeparmentDto>> GetById(int id);

        /// <summary>
        /// Get by id deparment rows.
        /// </summary>
        /// <param name="id">deparment id.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<DepartamentoDto>> GetByAutId(int id);

        /// <summary>
        /// Example of injection dependicy.
        /// </summary>
        /// <param name="description">description for inyection dependicy.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<List<DeparmentDto>>> GetInjection(string description);

        /// <summary>
        /// Get paginator.
        /// </summary>
        /// <param name="page">int page.</param>
        /// <param name="size">int size.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<List<DeparmentDto>>> GetPaginator(int page, int size);

        /// <summary>
        /// Create new deparment.
        /// </summary>
        /// <param name="model">data for create document.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<int>> Create(DeparmentDto model);

        /// <summary>
        /// Update deparment.
        /// </summary>
        /// <param name="model">data for create document.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<int>> Update(DeparmentDto model);

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<List<DeparmentDto>>> GetAllSp();

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <param name="id">int id.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<DeparmentDto>> GetByIdSp(int id);

        /// <summary>
        /// Example storage procedure.
        /// </summary>
        /// <param name="model">model for created.</param>
        /// <returns>deparment.</returns>
        Task<ServiceResponse<int>> CreateSp(DeparmentDto model);
    }
}
