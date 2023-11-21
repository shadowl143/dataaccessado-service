// <summary>
// <copyright file="DeparmentDto.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Dtos.Deparment
{
    using System;

    /// <summary>
    /// DeparmentDto.
    /// </summary>
    public class DeparmentDto
    {
        // <summary>
        /// Gets or sets column DeparmentId.
        /// </summary>
        /// <value>int primary key deparmentId</value>
        public int Id { get; set; }
        public string Name{ get; set; }
        public decimal Budget { get; set; }
        public DateTime Date { get; set; }
        public int Administrator { get; set; }

        public string AdministratorName { get; set; }
    }
}
