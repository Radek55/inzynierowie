using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaInzynierka.Badanie.Zapisywanie
{
    internal class ZapisDanych
    {
        private readonly string server = "sql11.freemysqlhosting.net";
        private readonly string database = "sql11524713";
        private readonly string username = "sql11524713";
        private readonly string password = "6IZVvZWxtU";

        public ZapisDanych(Dictionary<int, string> dane)
        {
            try
            {
                ZapisLokalny(dane);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message + "zapis lokalny failed"); 
            }
            try 
            { 
                ZapisDoBazyDanych(dane); 
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message+ "zapis do bazy danych failed");
            }
        }

        private void ZapisLokalny(Dictionary<int, string> dane)
        {
            //rozpakuj dane

            string test = "xd";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            File.WriteAllTextAsync(projectDirectory + "\\WriteText.txt", test);
        }
        
        private void ZapisDoBazyDanych(Dictionary<int, string> dane)
        {
            //rozpakuj dane

            string constring = "SERVER=" + server + ";"
                + "DATABASE=" + database + ";"
                + "UID=" + username + ";"
                + "PASSWORD=" + password + ";";
            var conn = new MySqlConnection(constring);
            conn.Open();
            string query = "INSERT INTO BadaniaWynikiTest(KodOsoby, Probka1, Probka2) VALUES(37, \'F\', \'F\');";
            var cmd = new MySqlCommand(query, conn);
            cmd.ExecuteReader();
        }

        //zbedna metoda
        /*public void OdczytBazyDanych()
        {
            string server = "sql11.freemysqlhosting.net";
            string database = "sql11524713";
            string username = "sql11524713";
            string password = "6IZVvZWxtU";
            string constring = "SERVER=" + server + ";"
                + "DATABASE=" + database + ";"
                + "UID=" + username + ";"
                + "PASSWORD=" + password + ";";
            var conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from BadaniaWynikiTest";
            var cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["KodOsoby"]);
                Console.WriteLine(reader["Probka1"]);
                Console.WriteLine(reader["Probka2"]);
            }
        }*/
    }
}
