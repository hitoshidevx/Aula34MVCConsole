using System.Collections.Generic;
using System;
using MVC.Models;

namespace MVC.Views
{
    public class ProdutoView
    {
        public void MostrarNoConsole(List<Produto> lista){

            foreach(Produto item in lista)
            {
                Console.WriteLine($"{item.Nome} - {item.Preco}");
            }

        }
    }
}