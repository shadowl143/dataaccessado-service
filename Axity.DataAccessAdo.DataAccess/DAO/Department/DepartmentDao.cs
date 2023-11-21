// <summary>
// <copyright file="DepartmentDao.cs" company="Axity">
// This source code is Copyright Axity and MAY NOT be copied, reproduced,
// published, distributed or transmitted to or stored in any manner without prior
// written consent from Axity (www.axity.com).
// </copyright>
// </summary>

namespace Axity.DataAccessAdo.DataAccess.DAO.Department
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Axity.DataAccessAdo.Entities.Model;
    using Axity.DataAccessAdo.Resources.Exceptions;
    using Microsoft.Data.SqlClient;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Class deparment.
    /// </summary>
    public class DepartmentDao : IDeparmentDao
    {
        private readonly string connectionString;
        private readonly IConfiguration conf;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepartmentDao"/> class.
        /// </summary>
        public DepartmentDao(IConfiguration conf)
        {
            this.conf = conf;
            this.connectionString = Environment.GetEnvironmentVariable("DataBaseSql");
            // this.connectionString = this.conf["DataBaseSql"];
        }

        /// <inheritdoc/>
        public Task<int> Create(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> CreateSp(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public async Task<List<DeparmentModel>> GetAll()
        {
            try
            {
                var departmets = new List<DeparmentModel>();
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    con.Open();
                    SqlCommand comman = new SqlCommand("select DeparmentID, Name, Budget, StarDate, administrator from deparment");
                    var reader = await comman.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        departmets.Add(new DeparmentModel()
                        {
                            Id = Convert.ToInt32(reader[0].ToString()),
                            Name = reader[0].ToString(),
                            Budget = Convert.ToInt32(reader[0].ToString()),
                            StartDate = Convert.ToDateTime(reader[0].ToString()),
                        });
                    }
                    return departmets;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new BusinessException("Error consulte al administredor");
            }
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetAllSp()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetByIdSp(int id)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetInjection(string description)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<List<DeparmentModel>> GetPaginator(int page, int size)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc/>
        public Task<int> Update(DeparmentModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}
