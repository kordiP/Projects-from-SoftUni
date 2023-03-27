using System.Collections.Generic;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Minions
{
    internal class Program
    {
        static void Main()
        {
            SqlConnection connection = new SqlConnection(Connection.CONNECTION_STRING);
            connection.Open();

            string[] createStatements =
                {
                "CREATE TABLE Countries (id INT PRIMARY KEY IDENTITY, name NVARCHAR(30) NOT NULL)",

                "CREATE TABLE Towns (id INT PRIMARY KEY IDENTITY, name NVARCHAR(30) NOT NULL, countryCode INT FOREIGN KEY REFERENCES Countries(id))",

                "CREATE TABLE Minions (id INT PRIMARY KEY IDENTITY, name NVARCHAR(30) NOT NULL, age INT, townId INT FOREIGN KEY REFERENCES Towns(id))",

                "CREATE TABLE EvilnessFactors (id INT PRIMARY KEY IDENTITY, name NVARCHAR(30) NOT NULL)",

                "CREATE TABLE Villains (id INT PRIMARY KEY IDENTITY, name NVARCHAR(30) NOT NULL, evilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(id))",

                "CREATE TABLE MinionsVillains (minionId INT FOREIGN KEY REFERENCES Minions(id), villainId INT FOREIGN KEY REFERENCES Villains(id), CONSTRAINT PK_Minions_Villains PRIMARY KEY(minionId, villainId))"
            };

            string[] insertStatements =
            {
                "INSERT INTO Countries (name) VALUES ('Bulgaria'), ('China'), ('USA'), ('Germany'), ('Sweden')",

                "INSERT INTO Towns (name, countryCode) VALUES ('Sofia', 1), ('Plovidv', 1), ('Beijing', 2), ('Hong Kong', 2), ('Brooklyn', 3), ('Berlin', 4), ('Stockholm', 5)",

                "INSERT INTO Minions (name, age, townId) VALUES ('Gosho', 20, 1), ('Maria',15, 4), ('Sergej',20, 5), ('Minchi',14,  6), ('Kevin',16, 7), ('Bob',12, 2), ('Krisi', 17, 3), ('Dichi', 18, 2)",

                "INSERT INTO EvilnessFactors (name) VALUES ('Super Good'), ('Good'), ('Mid'), ('Bad'), ('Real Bad')",

                "INSERT INTO Villains (name, evilnessFactorId) VALUES ('Kiki', 1), ('Misho', 2), ('Stoqn', 3), ('Simeon', 4), ('Kordi', 5), ('Valio', 3), ('Tedi', 1), ('Filip', 4)",

                "INSERT INTO MinionsVillains (minionId, villainId) VALUES (1,1), (2,2), (3,3), (4,4), (5,5), (6,6), (7,7), (8,8)"
            };

            using (connection)
            {
                foreach (var statement in insertStatements)
                {
                    using (SqlCommand command = new SqlCommand(statement, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}