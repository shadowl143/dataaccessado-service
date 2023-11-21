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
    using Axity.DataAccessAdo.DataAccess.DAO.Department;
    using Axity.DataAccessAdo.Dtos.DataAccessAdo;
    using Axity.DataAccessAdo.Dtos.Deparment;
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
            this.CreateMap<DeparmentModel, DeparmentDto>()
                .ForMember(e => e.Date, src => src.MapFrom(src => src.StartDate))
                .ForMember(e => e.Administrator, src => src.MapFrom(src => src.Administratr));

            this.CreateMap<DeparmentModel, DepartamentoDto>()
                .ForMember(e => e.Presupuesto, opt => opt.MapFrom(src => src.Budget))
                .ForMember(e => e.Nombre, opt => opt.MapFrom(src => src.Name))
                .ForMember(e => e.Administrador, opt => opt.MapFrom(src => src.Administratr))
                .ForMember(e => e.Fecha, src => src.MapFrom(src => src.StartDate.ToString("dd-MM-yyyy")));
        }
    }
}