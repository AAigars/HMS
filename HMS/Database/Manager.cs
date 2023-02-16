﻿using DbDataReaderMapper;
using System.Data.SQLite;

namespace HMS.Database
{
    public class Manager
    {
        private SQLiteConnection connection;

        /// <summary>
        /// Establishes a connection with the sql database
        /// </summary>
        public Manager()
        {
            // construct connection string
            var builder = new SQLiteConnectionStringBuilder()
            {
                DataSource = "hms.db"
            };

            // establish connection
            connection = new SQLiteConnection(builder.ConnectionString);

            // open connection
            connection.Open();  
        }

        /// <summary>
        /// Retrieves the sql connection
        /// </summary>
        /// <returns>The sql connection</returns>
        public SQLiteConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Executes a query and maps it into an object
        /// </summary>
        /// <typeparam name="T">The class of the object</typeparam>
        /// <param name="command">The sql command</param>
        /// <returns></returns>
        public T? ExecuteMappedQuery<T>(SQLiteCommand command) where T : class
        {
            using (command)
            { 
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.MapToObject<T>();
                    }
                }
            }

            return default(T);
        }

        /// <summary>
        /// Executes a query and maps it into an object
        /// </summary>
        /// <typeparam name="T">The class of the object</typeparam>
        /// <param name="query">The sql query</param>
        /// <returns></returns>
        public T? ExecuteMappedQuery<T>(string query) where T : class
        {
            return ExecuteMappedQuery<T>(new SQLiteCommand(query, connection));
        }

        /// <summary>
        /// Executes a query and casts to the template type
        /// </summary>
        /// <typeparam name="T">The template type</typeparam>
        /// <param name="command">The sql command</param>
        /// <returns></returns>
        public T? ExecuteQuery<T>(SQLiteCommand command)
        {
            using (command)
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return (T)reader.GetValue(0);
                    }
                }
            }

            return default(T);
        }

        /// <summary>
        /// Executes a query and casts to the template type
        /// </summary>
        /// <typeparam name="T">The template type</typeparam>
        /// <param name="query">The sql query</param>
        /// <returns></returns>
        public T? ExecuteQuery<T>(string query)
        {
            return ExecuteQuery<T>(new SQLiteCommand(query, connection));
        }
    }
}
