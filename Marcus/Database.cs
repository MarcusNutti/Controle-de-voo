using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace Marcus
{
    class Database
    {
        public SQLiteConnection connection;

        public Database() {

            connection = new SQLiteConnection("Data Source=acme.sqlite");

            if (!File.Exists("./acme.sqlite")) {

                SQLiteConnection.CreateFile("acme.sqlite");
                System.Console.WriteLine("O arquivo acme.sqlite foi criado.");

                try
                {
                    connection.Open();

                    SQLiteCommand command = new SQLiteCommand();
                    command.Connection = connection;

                    command.CommandText = "CREATE TABLE TB_VOO (ID_VOO INT NOT NULL PRIMARY KEY, " +
                        "DATA_VOO DATETIME, CUSTO NUMERIC(10,2), DISTANCIA INT, " +
                        "CAPTURA CHAR(1), NIVEL_DOR INT)";
                    command.ExecuteNonQuery();

                    System.Console.WriteLine("Tabela TB_VOO criada com sucesso.");
                    command.Dispose();
                }

                catch
                {
                    System.Console.WriteLine("A conexão não foi aberta ou a tabela TB_VOO não foi criada.");
                }

                finally
                {
                    connection.Close();
                }
            }
            
        }
    }
}
