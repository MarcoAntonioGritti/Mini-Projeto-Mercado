using System;
using System.Diagnostics;

class ManipuladorProdutos{
     int id = 0;
    List<Produtos> listaprodutos = new List<Produtos>();

    public void setores(){
            Console.WriteLine("-----------SETOR-----------");
            Console.WriteLine("1 - AÇOUGUE");
            Console.WriteLine("2 - FRIOS");
            Console.WriteLine("3 - PADARIA");
            Console.WriteLine("4 - SECOS");
            Console.WriteLine("5 - FRUTARIA");
            Console.WriteLine("6 - HIGIENE PESSOAL");
            Console.WriteLine("7 - LIMPEZA");
            Console.WriteLine("---------------------------");
    }
     public void AddProdutos(List<Produtos> listaprodutos){
        
        bool cont = true;

        while(cont){
            Console.WriteLine("-----CADASTRO PRODUTOS-----");
            Console.WriteLine("ID DO PRODUTO: " + id);
            Console.WriteLine("Nome produto: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor produto: ");
            double valor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Descrição produto: ");
            string desc = Console.ReadLine();
            Console.WriteLine("Data de fabricação do produto: ");
            string dataFab = Console.ReadLine();
            Console.WriteLine("Data de validade do produto: ");
            string dataVal = Console.ReadLine();
            Console.WriteLine("Marca do produto: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Total produto: ");
            int tot = Convert.ToInt32(Console.ReadLine());
            setores();
            Console.Write("SETOR: ");
            string setorProd = Console.ReadLine();

            Produtos produtos = new Produtos(nome,valor, desc, tot, dataFab, dataVal, marca, setorProd);
            listaprodutos.Add(produtos);
            Console.WriteLine("");

            Console.WriteLine("Deseja cadastrar outro produto?  [S/N]");
            string resp = Console.ReadLine().ToLower();

            if(resp == "s"){
                cont = true;           
                 id++;
                 
            }else{
                cont = false;
                Console.Clear();
                Console.WriteLine("Produto(s) cadastrado(s)!");
                Console.WriteLine("--------------------------");
                Menu();
            }
        }
    }

    public void entrarSetor(List<Produtos> divSetores){
            setores();
            string resp = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("------SETOR "+resp+"-------");
            foreach(var i in divSetores){
                if(i.Setor.Equals(resp, StringComparison.OrdinalIgnoreCase) ){
                    Console.WriteLine("ID DO PRODUTO: "+ id +$"|Nome: {i.NomeProduto}| |Valor R${i.Valor}| |Descrição: {i.DescProduto}| |TotalProduto: {i.TotProdutos}| Marca:{i.Marca}| |Data Fabricação:{i.DataFabricacao}| |Data Validade:{i.DataValidade}| |Setor Produtos:{i.Setor}|");
                }
            }
            Console.WriteLine("---------------------------");
            Menu();
    }

    public void mostrarLista(List<Produtos> produtos){
        Console.Clear();
        Console.WriteLine("-----PRODUTOS JÁ CADASTRADOS-----");

        foreach(var i in produtos){
            Console.WriteLine("ID DO PRODUTO: "+ id +$"|Nome: {i.NomeProduto}| |Valor R${i.Valor}| |Descrição: {i.DescProduto}| |TotalProduto: {i.TotProdutos}| Marca:{i.Marca}| |Data Fabricação:{i.DataFabricacao}| |Data Validade:{i.DataValidade}| |Setor Produtos:{i.Setor}|");
        }

        Console.WriteLine("---------------------------------");
        Menu();
    }

    public void atualiarProduto(List<Produtos> produtos){
        Console.WriteLine("Qual ID do produto que voce deseja atualizar? ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Novo valor R$ ");
        double novVal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("");
        Console.Write("Nova quantidade em estoque: ");
        int novTot = Convert.ToInt32(Console.ReadLine());

        Produtos atualizacaoProduto = new Produtos(novTot);

        if (num >= 0 && num < produtos.Count)
        {
            produtos[num].TotProdutos = novTot;
            produtos[num].Valor = novVal;
            Console.WriteLine("Elementos atualizados com sucesso.");
        }
        else
        {
            Console.WriteLine("ID não existente! Não foi possível atualizar os elementos.");
        }
        Menu();

    }


    public void deletarProduto(List<Produtos> produtos){
        Console.WriteLine("Qual o ID do produto a se deletar? ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num >= 0 && num < produtos.Count)
        {
            produtos.RemoveAt(num);
            Console.WriteLine("Elemento deletado com sucesso.");
        }
        else
        {
            Console.WriteLine("ID não existente! Não foi possível deletar o elemento.");
        }
        Menu();

    }

    public void Menu(){
        Console.WriteLine("----------MENU------------");
        Console.WriteLine("1 - CADASTRAR PRODUTO(S)");
        Console.WriteLine("2 - VIZUALIZAR PRODUTO(S)");
        Console.WriteLine("3 - ATUALIZAR PRODUTO(S)");
        Console.WriteLine("4 - DELETAR PRODUTO(S)" );
        Console.WriteLine("5 - ENTRAR SETORES" );
        Console.WriteLine("6 - FINALIZAR PROGRAMA!" );
        Console.WriteLine("--------------------------");
    
        string op = Console.ReadLine();
        Console.Clear();

            switch(op){
                case "1":
                    Console.Clear();
                    AddProdutos(listaprodutos);
                
                    break;
                case "2":
                    Console.Clear();
                    mostrarLista(listaprodutos);
                    break;
                case "3":
                    atualiarProduto(listaprodutos);
                    break;
                case "4":
                    deletarProduto(listaprodutos);
                    break;
                case "5":
                    Console.Clear();
                    entrarSetor(listaprodutos);
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("======================");
                    Console.WriteLine(" PROGRAMA FINALIZADO!");
                    Console.WriteLine("======================");
                    break;   
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    break;    
            }
    }
}