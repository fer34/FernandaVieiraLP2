using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Produto
    {
        private int id;
        private int id { get { return id; } }

        private int quantidade;

        private int Quantidade { get { return quantidade; } }

        public double Preco { get; set; }

        private string nome;
        public string nome { get { return nome; } }

        public int Repor(int qtd)
        {
            this.quantidade += qtd;

            return this.quantidade;
        }

        public void Retirar(int qtd)
        {
            if(this.quantidade >= qtd)
            {
                this.quantidade -= qtd;
            }
        }

        else
    {
        thorw new expection
    }
        

    
}
