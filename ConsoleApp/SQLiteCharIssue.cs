using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SQLiteCharIssue
    {
        public static void StoreCharInSQLite() {
            using var connection = new SQLiteConnection("Data Source=MyDatabase.sqlite");
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DROP TABLE IF EXISTS MyTable";
            command.ExecuteNonQuery();
            command.CommandText = "CREATE TABLE MyTable (CharColumn TEXT)";
            command.ExecuteNonQuery();
            command.CommandText = $"INSERT INTO MyTable (CharColumn) VALUES (@value)";
            command.Parameters.AddWithValue("@value", 'A');
            command.ExecuteNonQuery();
            command.CommandText = "SELECT * FROM MyTable";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }

        public static void UseGetCharExample() {
            using var connection = new SQLiteConnection("Data Source=MyDatabase.sqlite");
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DROP TABLE IF EXISTS MyTable";
            command.ExecuteNonQuery();
            command.CommandText = "CREATE TABLE MyTable (CharColumn TEXT)";
            command.ExecuteNonQuery();
            command.CommandText = $"INSERT INTO MyTable (CharColumn) VALUES (@value)";
            command.Parameters.AddWithValue("@value", 'A'.ToString());
            command.ExecuteNonQuery();
            command.CommandText = "SELECT * FROM MyTable";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetChar(0));
            }
        }

        public static void HowToStoreAndGetCharInSQLite() {
            using var connection = new SQLiteConnection("Data Source=MyDatabase.sqlite");
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = "DROP TABLE IF EXISTS MyTable";
            command.ExecuteNonQuery();
            command.CommandText = "CREATE TABLE MyTable (CharColumn TEXT)";
            command.ExecuteNonQuery();
            command.CommandText = $"INSERT INTO MyTable (CharColumn) VALUES (@value)";
            command.Parameters.AddWithValue("@value", 'A'.ToString());
            command.ExecuteNonQuery();
            command.CommandText = "SELECT * FROM MyTable";
            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0));
            }
        }
    }
}