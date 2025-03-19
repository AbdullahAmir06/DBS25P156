using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace DBS25P156
{
    public class DatabaseHelper
    {
        private readonly string connectionString;

        private DatabaseHelper()
        {
            connectionString = "server=127.0.0.1;port=3306;user=root;database=projecta;password=Abdullahx12345678909_;SslMode=None;";
        }

        private static DatabaseHelper _instance;
        public static DatabaseHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DatabaseHelper();
                return _instance;
            }
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // ✅ GetData (Parameterized)
        public DataTable GetData(string query, object[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        // ✅ ExecuteQuery (Parameterized)
        public int ExecuteQuery(string query, object[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    return command.ExecuteNonQuery();
                }
            }
        }

        // ✅ GetSingleValue (Parameterized)
        public object GetSingleValue(string query, object[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    return command.ExecuteScalar();
                }
            }
        }

        // ✅ CheckIfExists (Parameterized)
        public bool CheckIfExists(string query, object[] parameters = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    object result = command.ExecuteScalar();
                    int count = result != null ? Convert.ToInt32(result) : 0;
                    return count > 0;
                }
            }
        }

        // ✅ GetRow (Parameterized)
        public Dictionary<string, object> GetRow(string query, object[] parameters = null)
        {
            Dictionary<string, object> row = new Dictionary<string, object>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader[i];
                            }
                        }
                    }
                }
            }
            return row;
        }

        // ✅ GetColumn (Parameterized)
        public List<object> GetColumn(string query, object[] parameters = null)
        {
            List<object> columnValues = new List<object>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand(query, connection))
                {
                    AddParameters(command, parameters);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnValues.Add(reader[0]);
                        }
                    }
                }
            }
            return columnValues;
        }

        // 🔹 Helper Function: Add Parameters to Query
        private void AddParameters(MySqlCommand command, object[] parameters)
        {
            if (parameters == null || parameters.Length == 0) return;

            var matches = System.Text.RegularExpressions.Regex.Matches(command.CommandText, @"@\w+");

            int paramCount = 0;
            foreach (System.Text.RegularExpressions.Match match in matches)
            {
                if (paramCount < parameters.Length)
                {
                    command.Parameters.AddWithValue(match.Value, parameters[paramCount]);
                    paramCount++;
                }
                else
                {
                    break; // Stop if there are more named parameters than provided values
                }
            }
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using MySql.Data.MySqlClient;
//using System;
//using System.Data;
//using System.Collections.Generic;


//namespace DBS25P156
//{
//    public class DatabaseHelper
//    {
//        private readonly string connectionString;
//        private DatabaseHelper()
//        {
//            connectionString = "server=127.0.0.1;port=3306;user=root;database=projecta;password=Abdullahx12345678909_;SslMode=None;";
//        }

//        private static DatabaseHelper _instance;
//        public static DatabaseHelper Instance
//        {
//            get
//            {
//                if (_instance == null)
//                    _instance = new DatabaseHelper();
//                return _instance;
//            }
//        }

//        public MySqlConnection GetConnection()
//        {
//            return new MySqlConnection(connectionString);
//        }

//        public DataTable GetData(string query)
//        {
//            DataTable dataTable = new DataTable();
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    using (var adapter = new MySqlDataAdapter(command))
//                    {
//                        adapter.Fill(dataTable);
//                    }
//                }
//            }
//            return dataTable;
//        }

//        public int ExecuteQuery(string query)
//        {
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    return command.ExecuteNonQuery();
//                }
//            }
//        }

//        public object GetSingleValue(string query)
//        {
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    return command.ExecuteScalar();
//                }
//            }
//        }

//        public List<string> GetList(string query)
//        {
//            List<string> items = new List<string>();
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    using (var reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            items.Add(reader[0].ToString());
//                        }
//                    }
//                }
//            }
//            return items;
//        }

//        public Dictionary<string, object> GetRow(string query)
//        {
//            Dictionary<string, object> row = new Dictionary<string, object>();
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    using (var reader = command.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            for (int i = 0; i < reader.FieldCount; i++)
//                            {
//                                row[reader.GetName(i)] = reader[i];
//                            }
//                        }
//                    }
//                }
//            }
//            return row;
//        }

//        public List<object> GetColumn(string query)
//        {
//            List<object> columnValues = new List<object>();
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    using (var reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            columnValues.Add(reader[0]);
//                        }
//                    }
//                }
//            }
//            return columnValues;
//        }

//        public bool CheckIfExists(string query)
//        {
//            using (var connection = GetConnection())
//            {
//                connection.Open();
//                using (var command = new MySqlCommand(query, connection))
//                {
//                    //return command.ExecuteScalar() != null;
//                    object result = command.ExecuteScalar();
//                    int count = result != null ? Convert.ToInt32(result) : 0; // Ensure it's an integer
//                    return count > 0; // Only return true if count is greater than 0
//                }
//            }
//        }
//    }
//}
