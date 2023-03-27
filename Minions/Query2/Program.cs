using Minions;
using System.Data.SqlClient;

namespace Query2
{
    internal class Program
    {
        static void Main()
        {
            var connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            using (connection)
            {
                var query = @"SELECT v.name, COUNT(mv.minionId) AS [Count] 
                FROM Villains AS v 
                JOIN MinionsVillains AS mv 
                ON mv.villainId = v.id 
                GROUP BY v.name HAVING COUNT(mv.minionId) >=0 ORDER BY Count DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"{reader[0]} - {reader[1]}");
                        }
                    }
                }
            }
        }
    }
}