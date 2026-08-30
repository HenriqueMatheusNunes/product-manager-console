using System.Collections.Generic;

namespace CadastrodeProdutos 
{
    internal class Program 

{
        enum Opcao { Adicionar = 1, Listar = 2, Buscar = 3, Editar = 4, Remover = 5, Sair = 6 }

        static void Main(string[] args)
        {

            List<Produto> Lista = new List<Produto>();
         ///   List<string> Nome = new List<string>();
           // List<decimal> Preco = new List<decimal>();
         //   List<int> Qtn = new List<int>();
            bool rodarMenu = true;

            while (rodarMenu ==true) {

                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1-Adicionar\n2-Listar\n3-Buscar\n4-Editar\n5-Remover\n6-Sair");

                int index = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)index;

                switch (opcaoSelecionada) {

                    case Opcao.Adicionar:
                        Produto produto = new Produto();
                        Console.WriteLine("Voce quer adicionar um produto? Digite o nome dele: ");
                        string nome = Console.ReadLine();
                        produto.Nome = nome;
                        
                       Console.WriteLine("Digite  o preco do produto: ");
                       decimal preco = decimal.Parse( Console.ReadLine());
                       produto.Preco = preco;

                        Console.WriteLine("Digite  a quantidade do produto ");
                        int qnt = int.Parse(Console.ReadLine());
                        produto.Quantidade = qnt;

                        Lista.Add(produto);
                        Console.WriteLine($"Produto cadastrado: {produto.Nome} | Preço: {produto.Preco} | Quantidade: {produto.Quantidade}");
                       

                      

                     /*   for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine(i + " - " + Lista[i].Nome );
                        }

                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine(i + " - " + Lista[i].Preco );
                        }
                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine(i + " - " + Lista[i].Quantidade);
                        } */





                        break;

                    case Opcao.Listar:
                        Console.WriteLine("Vamos listar os produtos ja cadastrados");
                        
                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine($"{i} - Nome: {Lista[i].Nome} | Preço: R$ {Lista[i].Preco} | Quantidade: {Lista[i].Quantidade}");
                        }
                        break;


                    case Opcao.Buscar:
                        Console.WriteLine("Digite o produto que voce quer buscar: ");
                        string termoBusca = Console.ReadLine();

                        bool encontrado = false;


                        for (int i = 0; i < Lista.Count; i++)
                        {
                            
                            if (termoBusca == Lista[i].Nome)
                            {
                                Console.WriteLine($"{i} - Nome: {Lista[i].Nome} | Preço: R$ {Lista[i].Preco} | Quantidade: {Lista[i].Quantidade}");
                                encontrado = true;

                                break;
                            }
                           

                        } if (encontrado == false)
                        {
                            Console.WriteLine("Produto nao encontrado");
                        }

                        break;


                    case Opcao.Editar:
                        Console.Write("\nDigite o número (índice) do item que deseja alterar: ");


                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine($"{i} - Nome: {Lista[i].Nome} | Preço: R$ {Lista[i].Preco} | Quantidade: {Lista[i].Quantidade}");
                        }
                        




                        if (int.TryParse(Console.ReadLine(), out int indiceEscolhido))
                        {
                            // Validação: Garante que o usuário digitou um índice que realmente existe no array
                            if (indiceEscolhido >= 0 && indiceEscolhido < Lista.Count)
                            {
                                // 3. Pedimos o novo valor para substituir o antigo
                                Console.Write($"Você escolheu alterar '{Lista[indiceEscolhido].Nome}'. Digite o novo nome: ");
                                string novoValor = Console.ReadLine();

                                // 4. Aqui acontece a "substituição" (apaga o antigo e coloca o novo)
                               
                                Lista[indiceEscolhido].Nome = novoValor;

                                // 3. Pedimos o novo valor para substituir o antigo
                                Console.WriteLine("Quer alterar o preco tmb? ");
                                string res = Console.ReadLine();
                                if (res == "Sim")
                                {
                                    Console.Write($"Você escolheu alterar '{Lista[indiceEscolhido].Preco}'. Digite  preco novo: ");
                                    decimal novValor = decimal.Parse(Console.ReadLine());
                                    Lista[indiceEscolhido].Preco = novValor;

                                }

                                


                                Console.WriteLine("Quer alterar a quantidade?");
                                string qnsim = Console.ReadLine();
                                if (qnsim == "Sim")
                                {
                                    Console.Write($"Você escolheu alterar '{Lista[indiceEscolhido].Quantidade}'. Digite  a quantidade nova: ");
                                    int noValor = int.Parse(Console.ReadLine());
                                    Lista[indiceEscolhido].Quantidade = noValor;
                                }



                               ;






                                // 5. Exibe a lista atualizada
                                Console.WriteLine("\nLista atualizada com sucesso:" + novoValor + res + novoValor);
                                Console.WriteLine($"Índice {indiceEscolhido}: {Lista[indiceEscolhido]}");

                                for (int i = 0; i < Lista.Count; i++)
                                {
                                    Console.WriteLine($"{i} - Nome: {Lista[i].Nome} | Preço: R$ {Lista[i].Preco} | Quantidade: {Lista[i].Quantidade}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Erro: Índice inválido! O número digitado não existe na lista.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
                        }







                        break;

                    case Opcao.Remover:
                        Console.Write("\nDigite o número (índice) do item que deseja remover: ");


                        for (int i = 0; i < Lista.Count; i++)
                        {
                            Console.WriteLine($"{i} - Nome: {Lista[i].Nome} | Preço: R$ {Lista[i].Preco} | Quantidade: {Lista[i].Quantidade}");
                        }





                        if (int.TryParse(Console.ReadLine(), out int iEscolhido))
                        {
                            // Validação: Garante que o usuário digitou um índice que realmente existe no array
                            if (iEscolhido >= 0 && iEscolhido < Lista.Count)
                            {
                                Console.WriteLine("Produto removido com sucesso!");
                                Lista.RemoveAt(iEscolhido);


                            }
                            else
                            {
                                Console.WriteLine("Índice inválido!");
                            } 
                        }
                        else
                        {
                            Console.WriteLine("Digite um número válido!");
                        }



                        break;





































                    case Opcao.Sair:
                        rodarMenu = false;
                        break;


                 






















                }


















            }





        }
    }
}
