// <summary>
// <copyright file="ServiceResponse.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Dtos.Shared
{
    using System.Net;

    /// <summary>
    /// Response api.
    /// </summary>
    /// <typeparam name="T">Generic class.</typeparam>
    public class ServiceResponse<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceResponse{T}"/> class.
        /// </summary>
        /// <param name="data">Data.</param>
        /// <param name="code">http status code.</param>
        /// <param name="message">Message.</param>
        public ServiceResponse(T data, HttpStatusCode code = HttpStatusCode.OK, string message = "Ok")
        {
            this.Data = data;
            this.Code = code;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets http status code.
        /// </summary>
        /// <value>http status.</value>
        public HttpStatusCode Code { get; set; }

        /// <summary>
        /// Gets or sets Message fro show to user.
        /// </summary>
        /// <value>string.</value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Data will send to user.
        /// </summary>
        /// <value>Generyc data.</value>
        public T Data { get; set; }
    }
}
