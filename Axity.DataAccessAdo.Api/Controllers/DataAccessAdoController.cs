// <summary>
// <copyright file="DataAccessAdoController.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Facade.DataAccessAdo;
    using Microsoft.AspNetCore.Mvc;
    using Newtonsoft.Json;
    using StackExchange.Redis;

    /// <summary>
    /// Class DataAccessAdo Controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DataAccessAdoController : ControllerBase
    {
        private readonly IDataAccessAdoFacade logicFacade;

        private readonly IDatabase database;

        private readonly IConnectionMultiplexer redis;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccessAdoController"/> class.
        /// </summary>
        /// <param name="logicFacade">DataAccessAdo Facade.</param>
        /// <param name="redis">Redis Cache.</param>
        public DataAccessAdoController(IDataAccessAdoFacade logicFacade, IConnectionMultiplexer redis)
        {
            this.logicFacade = logicFacade ?? throw new ArgumentNullException(nameof(logicFacade));
            this.redis = redis ?? throw new ArgumentNullException(nameof(redis));
            this.database = redis.GetDatabase();
        }

        /// <summary>
        /// Method to get all DataAccessAdo.
        /// </summary>
        /// <returns>List of DataAccessAdo.</returns>
        [Route("")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this.logicFacade.GetListDataAccessAdoActive();
            return this.Ok(response);
        }

        /// <summary>
        /// Method to get DataAccessAdo By Id.
        /// </summary>
        /// <param name="id">DataAccessAdo Id.</param>
        /// <returns>DataAccessAdo Model.</returns>
        [Route("{DataAccessAdoId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            DataAccessAdoDto response = null;

            ////Example to get value with Redis Cache
            var result = await this.database.StringGetAsync(id.ToString());

            if (!result.HasValue)
            {
                response = await this.logicFacade.GetListDataAccessAdoActive(id);

                ////Example to set value with Redis Cache
                await this.database.StringSetAsync(id.ToString(), JsonConvert.SerializeObject(response));
            }
            else
            {
                ////If key in Redis, deserialize response and return object
                response = JsonConvert.DeserializeObject<DataAccessAdoDto>(result);
            }

            return this.Ok(response);
        }

        /// <summary>
        /// Method to Add DataAccessAdo.
        /// </summary>
        /// <param name="dataToStore">DataAccessAdo Model.</param>
        /// <returns>Success or exception.</returns>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DataAccessAdoDto dataToStore)
        {
            var response = await this.logicFacade.InsertDataAccessAdo(dataToStore);
            return this.Ok(response);
        }

        /// <summary>
        /// Method Ping.
        /// </summary>
        /// <returns>Pong.</returns>
        [Route("/ping")]
        [HttpGet]
        public IActionResult Ping()
        {
            return this.Ok("Pong");
        }
    }
}