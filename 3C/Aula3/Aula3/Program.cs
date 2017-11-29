using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, cor, placa, resp;
            int pot, ano;

            Console.WriteLine("Digite o/a:\nModelo:");
            modelo = Console.ReadLine();
            Console.WriteLine("\nCor:");
            cor = Console.ReadLine();
            Console.WriteLine("\nPlaca:");
            placa = Console.ReadLine();
            Console.WriteLine("\nPotência (em horses):");
            pot = int.Parse(Console.ReadLine());
            Console.WriteLine("\nAno:");
            ano = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection("Data Source=localhost; Initial Catalog=Aula3; Integrated Security=SSPI;"),  
                CommandText = @"select id,modelo,cor
                               FROM carro;"
            };


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows())
                {
                    while (Reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string modelo = reader.GetString(1);
                        string cor = reader.GetString(2);
                        double placa = reader.GetString(3);
                        int pot = reader.GetString(4);
                        int ano = reader.GetString(5);

                       
                    }
                    Console.WriteLine("\nForam encontrados {0} registros.\n\n");
                }
                else
                {
                    Console.WriteLine("Não foram encontraodos registros de professores.");
                }
            
                cmd.Connection.Close();
     
         

        }
    }
}
