using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = Carro ; Integrated Security = SSPI;");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao;
            cmd.CommandText = @"INSERT 
                                INTO CARRO(id,
                                           marca,
                                           modelo,
                                           cor,
                                           placa,
                                           potencia) Values('BMW','x5','preto','SQL-SERV', '258')";
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
