using System;

class ManipuladorProdutos{
     public static void AddProdutos(List<Produtos> listaprodutos){
        
        bool cont = true;

        while(cont){
            Console.WriteLine("Nome produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Descrição produto: ");
            string desc = Console.ReadLine();
            Console.WriteLine("Total produto: ");
            int tot = Convert.ToInt32(Console.ReadLine());

            Produtos produtos = new Produtos(nome,desc,tot);
            listaprodutos.Add(produtos);

            Console.WriteLine("Deseja cadastrar outro produto?  [S/N]");
            string resp = Console.ReadLine();

            if(resp == "s" || resp == "S"){
                cont = true;
            }else{
                cont = false;
            }
        }
        Console.WriteLine("Produto(s) cadastrado(s)!");
    }

    public static void mostrarLista(List<Produtos> produtos){
        Console.WriteLine("-----PRODUTOS JÁ CADASTRADOS-----");

        foreach(var i in produtos){
            Console.WriteLine($"|Nome: {i.NomeProduto}| |Descrição: {i.DescProduto}| |TotalProduto: {i.TotProdutos}|");
        }
    
        Console.WriteLine("-------------------------------");
    }

    public static void atualiarEstoque(List<Produtos> produtos){
        Console.WriteLine("Qual a numeração do produto a se atualizar? ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nova quantidade em estoque: ");
        int novTot = Convert.ToInt32(Console.ReadLine());

        Produtos atualizacaoProduto = new Produtos(novTot);

        if (num >= 0 && num < produtos.Count)
        {
            produtos[num].TotProdutos = novTot;
            Console.WriteLine("Elemento atualizado com sucesso.");
        }
        else
        {
            Console.WriteLine("Índice fora do intervalo. Não foi possível atualizar o elemento.");
        }

    }

    public static void deletarProduto(List<Produtos> produtos){
        Console.WriteLine("Qual a numeração do produto a se deletar? ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0 && num < produtos.Count)
        {
            produtos.RemoveAt(num);
            Console.WriteLine("Elemento deletado com sucesso.");
        }
        else
        {
            Console.WriteLine("Índice fora do intervalo. Não foi possível deletar o elemento.");
        }

    }

}