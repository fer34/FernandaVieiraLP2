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
    class DadosClientes
    {
        private string Usu;
        public string usu { get { return Usu; } }
        private string Nasc;
        public string nasc { get { return Nasc; } }
        private string Nome;
        public string nome { get { return Nome; } }
        private string CPF;
        public string cpf { get { return CPF; } }
        private string Mail;
        public string mail { get { return Mail; } }
        private string Senha;
        public string senha { get { return Senha; } }
        private string Endereco;
        public string endereco { get { return Endereco; } }
        private string RG;
        public string rg { get {return RG; } }
        public bool cadastrook;
        public void EnviarParaBD(string usu, string nasc, string nome, string rg, string mail, string senha, string endereco, string cpf)
        {
            this.Usu = usu;
            this.Nasc = nasc;
            this.Nome = nome;
            this.CPF = cpf;
            this.Mail = mail;
            this.Senha = senha;
            this.Endereco = endereco;
            this.RG = rg;

            SqlCommand cmd = new SqlCommand()
            {
                Connection = new SqlConnection(@"Data Source=DESKTOP-6SPO3I6;Initial Catalog=Livroteca;Integrated Security=SSPI;")

            };

            try
            {
                // Simplemente insere no BD os valores do telaRegistro. AddWithValue faz essa inserção com mais segurança que inserir diretamente. A gente aprendeu isso no código do Carro.
                cmd.Connection.Open();

                cmd.CommandText = String.Format(@"INSERT
                                                INTO Cliente (usu, nasc, nome, rg, mail, senha, endereco, cpf)
                                                VALUES (@usu, @nasc, @nome, @rg, @mail, @senha, @endereco, @cpf);");

                cmd.Parameters.AddWithValue("usu", usu);
                cmd.Parameters.AddWithValue("nasc", nasc);
                cmd.Parameters.AddWithValue("nome", nome);
                cmd.Parameters.AddWithValue("rg", rg);
                cmd.Parameters.AddWithValue("mail", mail);
                cmd.Parameters.AddWithValue("senha", senha);
                cmd.Parameters.AddWithValue("endereco", endereco);
                cmd.Parameters.AddWithValue("cpf", cpf);

                SqlDataReader reader = cmd.ExecuteReader();
                cadastrook = true;
                cmd.Connection.Close();               
            }
            catch (SqlException)
            {
                MessageBox.Show("Ocorreu um erro ao enviar seus dados para o servidor, por favor verificar os dados inseridos. ", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }        
        }
    }
}