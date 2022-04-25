using System;
using System.Data.SqlClient;

namespace AdoNetIntro
{
    class Program
    {
        private const string connectionStr = "Server=DESKTOP-4L8DU14;Database=STUDENTS;Integrated Security=true;";
        static void Main(string[] args)
        {
            //Insert();
            //SelectAll();
            //Delete();
            UPDATE();  //SWITCH-CASE ILE DE YAZMAQ OLAR.
        }
        public static void SelectAll()
        {
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string query = "SELECT * FROM UCHENIKI";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader result = command.ExecuteReader();

                while (result.Read())
                {
                    Console.WriteLine(result["name"]);
                }
            }
            connection.Close();
        }
        public static void Insert()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string query = $"INSERT INTO UCHENIKI VALUES('{name}')";
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            if (result < 1)
            {
                Console.WriteLine("Problem");
            }
            Console.WriteLine(result);
            connection.Close();

        }

        public static void Delete()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string query = $"Delete from UCHENIKI ";
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            if (result < 1)
            {
                Console.WriteLine("Problem");
            }
            Console.WriteLine(result);
            connection.Close();

        }
        public static void UPDATE()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter ID:");
            int id = int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string query = $"UPDATE  UCHENIKI SET UCHENIKI.Name='{name}' where id={id}";
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            if (result < 1)
            {
                Console.WriteLine("Problem");
            }
            Console.WriteLine(result);
            connection.Close();

        }

    }
}
