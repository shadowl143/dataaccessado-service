// <summary>
// <copyright file="DeparmentController.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Api.Controllers
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.Deparment;
    using Axity.DataAccessAdo.Dtos.Shared;
    using Axity.DataAccessAdo.Facade.Deparment;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller deparment.
    /// </summary>
    [Route("api/deparment")]
    [ApiController]
    public class DeparmentController : ControllerBase
    {
        private readonly IDeparmentFacade modelFacede;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeparmentController"/> class.
        /// </summary>
        /// <param name="modelFacede">modelFacade.</param>
        public DeparmentController(IDeparmentFacade modelFacede)
        {
            this.modelFacede = modelFacede;
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [HttpGet]
        public async Task<ServiceResponse<List<DeparmentDto>>> GetAll()
        {
            return await this.modelFacede.GetAll();
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <param name="id">int id.</param>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}/id")]
        public async Task<ServiceResponse<DeparmentDto>> GetById([Required] int id)
        {
            return await this.modelFacede.GetById(id);
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <param name="page">page to display.</param>
        /// <param name="size">Number of records to display.</param>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("paginator")]
        public async Task<ServiceResponse<List<DeparmentDto>>> GetPaginator([FromQuery][Required] int page, int size)
        {
            return await this.modelFacede.GetPaginator(page, size);
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [HttpGet("Sp")]
        public async Task<ServiceResponse<List<DeparmentDto>>> GetAllSp()
        {
            return await this.modelFacede.GetAllSp();
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <param name="id">int id.</param>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [HttpGet("spid")]
        public async Task<ServiceResponse<DeparmentDto>> GetByIdSp([FromQuery][Required] int id)
        {
            return await this.modelFacede.GetByIdSp(id);
        }

        /// <summary>
        /// Get All.
        /// </summary>
        /// <param name="description">int id.</param>
        /// <returns>Service response.</returns>
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ServiceResponse<List<DeparmentDto>>))]
        [HttpGet("inject")]
        public async Task<ServiceResponse<List<DeparmentDto>>> GetByIdSp([FromQuery][Required] string description)
        {
            return await this.modelFacede.GetInjection(description);
        }

        /// <summary>
        /// Create new row.
        /// </summary>
        /// <param name="model">Deparment.</param>
        /// <returns>indentity key.</returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ServiceResponse<int>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<ServiceResponse<int>> Save(DeparmentDto model)
        {
            return await this.modelFacede.Create(model);
        }

        /// <summary>
        /// Create new row.
        /// </summary>
        /// <param name="model">Deparment.</param>
        /// <returns>indentity key.</returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ServiceResponse<int>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost("createsp")]
        public async Task<ServiceResponse<int>> SaveSp(DeparmentDto model)
        {
            return await this.modelFacede.CreateSp(model);
        }

        /// <summary>
        /// Create new row.
        /// </summary>
        /// <param name="model">Deparment.</param>
        /// <returns>indentity key.</returns>
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ServiceResponse<int>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut]
        public async Task<ServiceResponse<int>> Update(DeparmentDto model)
        {
            return await this.modelFacede.Update(model);
        }
    }
}
