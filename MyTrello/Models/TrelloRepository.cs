using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrello.Models
{
    public class TrelloRepository
    {
        private static ILogger<TrelloRepository> _logger;
        public TrelloRepository(ILogger<TrelloRepository> logger)
        {
            _logger = logger;
        }

        static string connStr = "Data Source=SQL5063.site4now.net;Initial Catalog=db_a7c5be_sellboarddb;User Id=db_a7c5be_sellboarddb_admin;Password=qwerty009";
        public static List<Projects> GetProjects()
        {
            List<Projects> projects = new List<Projects>();
            using (IDbConnection db = new SqlConnection(connStr))
            {
                try
                {
                    db.Open();
                    var query = "EXEC [dbo].[GetProjects]";
                    projects = db.Query<Projects>(query).ToList();
                    _logger.LogInformation($"Get data has been accesed {DateTime.Now}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return projects;
        }

        public static List<Team> GetTeams()
        {
            List<Team> teams = new List<Team>();
            using (IDbConnection db = new SqlConnection(connStr))
            {
                try
                {
                    db.Open();
                    var query = "EXEC [dbo].[GetTeams]";
                    teams = db.Query<Team>(query).ToList();
                    _logger.LogInformation($"Get data has been accesed {DateTime.Now}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return teams;
        }

        public static List<UpNext> GetTasks()
        {
            List<UpNext> tasks = new List<UpNext>();
            using (IDbConnection db = new SqlConnection(connStr))
            {
                try
                {
                    db.Open();
                    var query = "EXEC [dbo].[GetTasks]";
                    tasks = db.Query<UpNext>(query).ToList();
                    _logger.LogInformation($"Get data has been accesed {DateTime.Now}");
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return tasks;
        }
    }
}
