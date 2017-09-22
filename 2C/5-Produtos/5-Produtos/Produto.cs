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
        public int Id { get { return id; } }

        private string nome;
        public string Nome { get { return Nome; } }

        private double preco;
        public double Preco { get { return Preco; } }

        private int qtd;
        public int Qtd  { get { return qtd; } }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }

        public void reposi(int qtd)
        {
            this.qtd += qtd;
        }
        public void reti(int quant)
        {
            if (this.Qtd >= qtd) { this.qtd -= quant; }
            else
                throw new Exception();
        }
        public string Imprimir()
        {
            return string.Format("{0}, {1}, {2:00.00}", id, nome, preco);
        }


    }
}
