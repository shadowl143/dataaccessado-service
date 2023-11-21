// <summary>
// <copyright file="CustomServiceException.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.Resources.Exceptions
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Class Custom Service.
    /// </summary>
    [Serializable]
    public class CustomServiceException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException"/> class.
        /// </summary>
        public CustomServiceException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException"/> class.
        /// </summary>
        /// <param name="message">Message Exception.</param>
        public CustomServiceException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException"/> class.
        /// </summary>
        /// <param name="message">Message Exception.</param>
        /// <param name="innerException">Inner Exception.</param>
        public CustomServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomServiceException"/> class.
        /// </summary>
        /// <param name="info">info.</param>
        /// <param name="context">context.</param>
        protected CustomServiceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
