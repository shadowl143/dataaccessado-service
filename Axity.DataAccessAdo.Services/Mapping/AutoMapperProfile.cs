// <summary>
// <copyright file="AutoMapperProfile.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Services.Mapping
{
    using AutoMapper;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Entities.Model;

    /// <summary>
    /// Class Automapper.
    /// </summary>
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoMapperProfile"/> class.
        /// </summary>
        public AutoMapperProfile()
        {
            this.CreateMap<DataAccessAdoModel, DataAccessAdoDto>();
            this.CreateMap<DataAccessAdoDto, DataAccessAdoModel>();
        }
    }
}