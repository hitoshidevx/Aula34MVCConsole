using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;

namespace MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            
            string[] linhas = File.ReadAllLines(PATH);

            foreach(string linha in linhas)
            {
                string[] dado = linha.Split(";");
                
                Produto p   = new Produto();
                p.Codigo    = Int32.Parse( Separar(dado[0]) );
                p.Nome      = Separar(dado[1]);
                p.Preco     = float.Parse( Separar(dado[2]) );

                produtos.Add(p);
            }
            produtos = produtos.OrderBy(y => y.Nome).ToList();
            return produtos; 
        }
        private string Separar(string _coluna)
        {
            return _coluna.Split("=")[1];
        }
    }
}