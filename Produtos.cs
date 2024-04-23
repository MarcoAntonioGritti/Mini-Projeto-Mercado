using System;

class Produtos{

    public string NomeProduto {get;set;}
    public string DescProduto {get;set;}

    public int TotProdutos{get;set;}

    public Produtos(string nome,string desc,int totProd){
        NomeProduto = nome;
        DescProduto = desc;
        TotProdutos = totProd;
    }

    public Produtos(int totProde){
        TotProdutos = totProde;
    }
    
}