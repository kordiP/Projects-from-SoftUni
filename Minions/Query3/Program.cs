using Minions;
using System.Data.SqlClient;

namespace Query3
{
    internal class Program
    {
        static void Main()
        {
            int id = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            var query = $@"SELECT v.name, m.name, m.age
            FROM Villains AS v
            JOIN MinionsVillains AS mv
            ON mv.villainId = v.Id
            JOIN Minions as m
            ON mv.MinionId = m.Id
            WHERE v.id = @id
            ORDER BY m.name ASC";

            using (connection)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.HasRows) Console.WriteLine($"No villain with ID {id} exists in database.");

                        int count = 1;

                        while (reader.Read())
                        {
                            if (reader.HasRows) Console.WriteLine("No minions.");
                            if (count == 1) Console.WriteLine($"Villain: {reader[0]}");

                            Console.WriteLine($"{count}. {reader[1]} {reader[2]}");

                            count++;
                        }

                    }

                }
            }
        }
    }
}