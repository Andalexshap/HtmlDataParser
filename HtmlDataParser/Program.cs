using HtmlDataParser.Services;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram start = new StartProgram();

            start.Start();
            /*
            string connectionString = "Data Source=(local);Initial Catalog=HtmlDataParser;Persist Security Info=True;TrustServerCertificate=True;User ID=virto;Password=virto;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT * FROM MyTable";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            Console.ReadLine();*/
        }
    }
}