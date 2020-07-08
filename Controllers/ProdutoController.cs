using System.Collections.Generic;
using MVC.Models;
using MVC.Views;

namespace MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel    = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar(){

            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);

        }

        public void Buscar(string _termo){

            List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(_termo));
            produtoView.MostrarNoConsole(lista);

        }
    }
}