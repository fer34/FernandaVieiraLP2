using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Livroteca_ProjetoFinalLP2
{
    class Livro
    {
        private string Titulo;
        public string titulo { get { return Titulo; } }
        private string Editora;
        public string editora { get { return Editora; } }
        private string Quantidade;
        public string quantidade { get { return Quantidade; } }
        public bool adicionarok;

        public void EnviarParaBD(string titulo, string editora, string quantidade)
        {
            this.Titulo = titulo;
            this.Editora = editora;
            this.Quantidade = quantidade;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=DESKTOP-6SPO3I6;Initial Catalog=Livroteca;Integrated Security=SSPI;")

            };

            try
            {

                cmd.Connection.Open();

                cmd.CommandText = String.Format(@"INSERT
                                                INTO Livro (titulo, editora, quantidade)
                                                VALUES (@titulo, @editora, @quantidade);");

                cmd.Parameters.AddWithValue("titulo", titulo);
                cmd.Parameters.AddWithValue("editora", editora);
                cmd.Parameters.AddWithValue("quantidade", quantidade);

                SqlDataReader reader = cmd.ExecuteReader();
                adicionarok = true;
                cmd.Connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocorreu um erro ao enviar seus dados para o servidor, por favor verificar os dados inseridos. ", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}