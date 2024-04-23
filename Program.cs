using System;

class Program{
    static void Main(String[] args){

        List<Produtos> listaprodutos = new List<Produtos>();
        ManipuladorProdutos.AddProdutos(listaprodutos);
        ManipuladorProdutos.mostrarLista(listaprodutos);
        ManipuladorProdutos.atualiarEstoque(listaprodutos);
        ManipuladorProdutos.deletarProduto(listaprodutos);
        ManipuladorProdutos.mostrarLista(listaprodutos);


    }
}