using System;
using MVC.Controllers;

namespace MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController produtos = new ProdutoController();
            produtos.Buscar("600");
        }
    }
}
