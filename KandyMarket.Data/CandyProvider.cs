using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;

namespace KandyMarket.Data
{
    public class CandyProvider : ICandyProvider
    {
        private readonly string connectionString;

        public IEnumerable<Candy> Get()
        {
            IEnumerable<Candy> candy = null;

            using (var connection = new SqlConnection(connectionString))
            {
                candy = connection.Query<Candy>(
                    "select id, name, color from Candy");
            }

            return candy;
        }
    }
}
