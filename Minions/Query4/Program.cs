using Minions;
using System.Data.SqlClient;

namespace Query4
{
    internal class Program
    {
        static void Main()
        { 
            /*
                Minions already exists, but villains or towns must be added if they don't exists in DB.
                Default value for evilness factor on villain = "bad"
                Country code in cities is unknown, so default it to 1.
             */

            Console.Write("Minion: ");  // "Bob 14 Berlin"
            string[] minionInput = Console.ReadLine().Split();

            Console.Write("Villain: "); // "Gru"
            string[] villainInput = Console.ReadLine().Split();

            SqlConnection connection = new SqlConnection
                (Connection.CONNECTION_STRING);
            connection.Open();

            string[] insertStatements = 
            {
                @"INSERT INTO Towns (name, countryCode) VALUES (@townName, 1)",

                @"INSERT INTO Villains (name, evilnessFactorId) VALUES (@villainName, 4)",

                @"INSERT INTO MinionsVillains (minionId, villainId) VALUES (@minionId, @villainId)"
            };

            var queryMinion = 
                $@"
            SELECT id
            FROM Minions
            WHERE name = @minionName
            ";

            var queryVillain =
                $@"
            SELECT id 
            FROM Villains 
            WHERE name = @villainName
            ";

            using (connection)
            {
                foreach (var statement in insertStatements)
                {
                    using (SqlCommand command = new SqlCommand(statement, connection))
                    {
                        command.Parameters.AddWithValue("@townName", minionInput[2]);

                        command.Parameters.AddWithValue("@villainName", villainInput[0]);

                        using (SqlCommand query = new SqlCommand(queryMinion, connection))
                        {
                            query.Parameters.AddWithValue("@minionName", minionInput[0]); // returns id <?>
                            using (SqlDataReader reader = query.ExecuteReader())
                            {
                                while (reader.Read()) command.Parameters.AddWithValue("@minionId", reader[0]);
                            }
                        }
                        using (SqlCommand query = new SqlCommand(queryVillain, connection))
                        {
                            query.Parameters.AddWithValue("@villainName", minionInput[0]); // returns id <?>
                            using (SqlDataReader reader = query.ExecuteReader())
                            {
                                while (reader.Read()) command.Parameters.AddWithValue("@villainId", reader[0]);
                            }
                        }
                        command.ExecuteScalar();
                        command.Parameters.Clear();
                    }
                }
            }
        }
    }
}