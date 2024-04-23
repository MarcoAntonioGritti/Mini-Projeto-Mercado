using System;

class Produtos{


    public string NomeProduto {get;set;}
    public double Valor{get;set;}
    public string DescProduto {get;set;}
    public int TotProdutos{get;set;}
    public string DataValidade {get;set;}
    public string DataFabricacao{get;set;}
    public string Marca{get;set;}
    public string Setor {get;set;}


    public Produtos(string nome,double valor,string desc,int totProd,string dataFab,string dataVal,string marca,string setorProd){
        this.NomeProduto = nome;
        this.Valor = valor;
        this.DescProduto = desc;
        this.TotProdutos = totProd;
        this.DataFabricacao = dataFab;
        this.DataValidade = dataVal;
        this.Marca = marca;
        this.Setor = setorProd;
    }

    public Produtos(int totProde){
        this.TotProdutos = totProde;
    }
    
}