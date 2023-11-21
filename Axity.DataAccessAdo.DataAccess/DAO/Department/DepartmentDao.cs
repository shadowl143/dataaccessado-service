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
    using System.Data;
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
        public async Task<int> Create(DeparmentModel model)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(this.connectionString))
                {
                    using SqlCommand cmd = sqlConnection.CreateCommand();
                    cmd.CommandText = "insert into Department (Name, Budget, StartDate, Administrator) values (@Name,@Budget,@StartDate,@Administrator);";
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("@Name", SqlDbType.VarChar);
                    cmd.Parameters.Add("@Budget", SqlDbType.Decimal);
                    cmd.Parameters.Add("@StartDate", SqlDbType.Date);
                    cmd.Parameters.Add("@Administrator", SqlDbType.Int);

                    cmd.Parameters["@Name"].Value = model.Name;
                    cmd.Parameters["@Budget"].Value = model.Budget;
                    cmd.Parameters["@StartDate"].Value = model.StartDate;
                    cmd.Parameters["@Administrator"].Value = model.Administratr;
                    sqlConnection.Open();
                    var execute = await cmd.ExecuteNonQueryAsync();
                    return execute;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new BusinessException("Error consulte al administredor");
            }
            
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
                    SqlCommand comman = new SqlCommand("select a.DepartmentID, a.Name, a.Budget,a.StartDate, a.Administrator from Department a", con);
                    con.Open();
                    var reader = await comman.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        departmets.Add(new DeparmentModel()
                        {
                            Id = Convert.ToInt32(reader[0].ToString()),
                            Name = reader[1].ToString(),
                            Budget = Convert.ToDecimal(reader[2].ToString()),
                            StartDate = Convert.ToDateTime(reader[3].ToString()),
                            Administratr = Convert.ToInt32(reader[4].ToString()),
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
        public async Task<DeparmentModel> GetById(int id)
        {

            try
            {
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    var query = $"select DepartmentID, Name, Budget, StartDate, Administrator from Department where DepartmentID = @id";
                    using SqlCommand comman = new SqlCommand();
                    comman.Connection = con;
                    comman.CommandType = CommandType.Text;
                    comman.CommandText = query;
                    comman.Parameters.Add("@id", SqlDbType.Int);
                    comman.Parameters["@id"].Value = id;

                    con.Open();
                    var reader = await comman.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        return new DeparmentModel()
                        {
                            Id = Convert.ToInt32(reader["DepartmentID"].ToString()),
                            Name = reader["Name"].ToString(),
                            Budget = Convert.ToDecimal(reader["Budget"].ToString()),
                            StartDate = Convert.ToDateTime(reader["StartDate"].ToString()),
                            Administratr = Convert.ToInt32(reader["Administrator"].ToString()),
                        };
                    }
                    throw new NotFoundException("Dato no encontrado");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new BusinessException("Error consulte al administredor");
            }
        }

        /// <inheritdoc/>
        public async Task<DeparmentModel> GetByIdSp(int id)
        {


            try
            {
                var departmets = new DeparmentModel();
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    var query = $"GetById";
                    using SqlCommand comman = new SqlCommand();
                    comman.Connection = con;
                    comman.CommandType = CommandType.StoredProcedure;
                    comman.CommandText = query;
                    comman.Parameters.Add("@departmentId", SqlDbType.Int);
                    comman.Parameters["@departmentId"].Value = id;

                    con.Open();
                    var reader = await comman.ExecuteReaderAsync();
                    if (reader.Read())
                    {
                        departmets = new DeparmentModel()
                        {
                            Id = Convert.ToInt32(reader["DepartmentID"].ToString()),
                            Name = reader["Name"].ToString(),
                            Budget = Convert.ToDecimal(reader["Budget"].ToString()),
                            StartDate = Convert.ToDateTime(reader["StartDate"].ToString()),
                            Administratr = Convert.ToInt32(reader["Administrator"].ToString()),
                        };
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
        public async Task<List<DeparmentModel>> GetInjection(string description)
        {
            try
            {
                var departmets = new List<DeparmentModel>();
                using (SqlConnection con = new SqlConnection(this.connectionString))
                {
                    var query = $"select a.DepartmentID, a.Name, a.Budget,a.StartDate, a.Administrator from Department a where a.name = '{description}'";
                    SqlCommand comman = new SqlCommand(query, con);
                    con.Open();
                    var reader = await comman.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        departmets.Add(new DeparmentModel()
                        {
                            Id = Convert.ToInt32(reader[0].ToString()),
                            Name = reader[1].ToString(),
                            Budget = Convert.ToDecimal(reader[2].ToString()),
                            StartDate = Convert.ToDateTime(reader[3].ToString()),
                            Administratr = Convert.ToInt32(reader[4].ToString()),
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
