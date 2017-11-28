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


               /* CommandText = string.Format(@"INSERT
                                              INTO CARRO
                                              VALUES ('{0}','{1}','{2}',{3},{4});", modelo, cor, placa, pot, ano)*/

                CommandText = @"select id,modelo,cor
                               FROM carro;"
                                              
            };

            try
            {
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.Connection.Close();
            }
            catch(Exception e)
            {
                Console.Write("not");
            }
         

        }
    }
}
