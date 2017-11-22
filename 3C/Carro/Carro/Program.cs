using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog= fernanda; Integrated Security=SSPI;");
            SqlCommand cmd = new SqlCommand();

            string marca, modelo, cor, placa;
            int pot;
            marca = Console.ReadLine();
            modelo = Console.ReadLine();
            cor = Console.ReadLine();
            placa = Console.ReadLine();
            pot = int.Parse(Console.ReadLine());

            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT
                              INTO infor(Marca, Modelo, Cor, Placa, [Potencia(CV)])
                              VALUES (@marca,@modelo,@cor,@placa,@potencia);";
                                                   
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            
        }
    }
}
