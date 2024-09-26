using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_CRUD_Carros
{

    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public Carro(string marca, string modelo, int ano, decimal preco)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;

        }
        public override string ToString()
        {

            return $"{Marca} {Modelo}, Ano: {Ano}, Preço: R$ {Preco}";
        }
    }
   
    
}