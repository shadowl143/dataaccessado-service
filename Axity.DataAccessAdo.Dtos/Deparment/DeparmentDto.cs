﻿// <summary>
// <copyright file="DepartamentoDto.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Dtos.Deparment
{
    using System;

    /// <summary>
    /// DepartamentoDto.
    /// </summary>
    public class DepartamentoDto
    {
        // <summary>
        /// Gets or sets column DeparmentId.
        /// </summary>
        /// <value>int primary key deparmentId</value>
        public int Id { get; set; }
        public string Nombre{ get; set; }
        public decimal Presupuesto { get; set; }
        public string Fecha { get; set; }
        public int Administrador { get; set; }

        public string AdministratorName { get; set; }
    }
}
