using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace TrainingASPDotNet
{
    public static class ConnectionManager
    {
        public static SqlConnection GetConnection()
        {
            var connection = ConfigurationManager.ConnectionStrings["Database"].ToString();
            return new SqlConnection(connection);
        }
    }
}