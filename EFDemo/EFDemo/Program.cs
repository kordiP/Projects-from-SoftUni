using System.Data.SqlClient;
namespace EFDemo
{
    internal class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string connectionString = "Server=DESKTOP-LA33O3R;Database=MyDB;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string[] createTableStatements = // insert statements work here too.
                {
                    @"CREATE TABLE Subjects
                    (
                    Id INT PRIMARY KEY IDENTITY NOT NULL,
                    Name NVARCHAR(20) NOT NULL,
                    Lessons INT NOT NULL,
                    )"
                };

                string[] insertSubjects =
                {
                    @"INSERT INTO Subjects (Name, Lessons)
                    VALUES ('Mat', 0),
                     ('Bel', 0),
                     ('Fvs', 0),
                     ('Ae', 0)"
                };

                var query = @"SELECT Id, Name, Lessons 
                    FROM Subjects 
                    WHERE Name = @name
                    ORDER BY Name, Id";

                using (SqlCommand cmd = new SqlCommand(query, con)) // change first param here to change which query is executed like<insertSubjects[0]>
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    // for the insert/create -> cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader()) // for "output" queries
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["Name"]);
                        }
                    }
                }

                con.Dispose();

            }
            
        }
    }
}