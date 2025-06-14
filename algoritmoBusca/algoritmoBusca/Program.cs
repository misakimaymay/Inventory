namespace algoritmoBusca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> lista = new List<int>();
            int opcao;

            do
            {
                Console.WriteLine("========Algoritmo de busca========");
                Console.WriteLine("1 - Adicionar elemento");
                Console.WriteLine("2 - Remover elemento");
                Console.WriteLine("3 - Buscar elemento");
                Console.WriteLine("4 - Exibir lista");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine()); // Lê a opção do usuário

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o elemento que será adicionado: ");
                        int valorAdicionado = int.Parse(Console.ReadLine());
                        lista.Add(valorAdicionado);
                        break;
                    case 2:
                        Console.WriteLine("Digite o elemento que será removido: ");
                        int valorRemovido = int.Parse(Console.ReadLine());
                        lista.Remove(valorRemovido);
                        if (lista.Contains(valorRemovido))
                            Console.WriteLine("Elemento removido com sucesso.");
                        else
                            Console.WriteLine("Elemento não encontrado na lista.");
                        break;
                    case 3:
                        Console.WriteLine("Digite o elemento que deseja buscar: ");
                        int valorBuscado = int.Parse(Console.ReadLine());
                        int indice = lista.IndexOf(valorBuscado); // Procura o valorBuscado dentro da lista.
                        if (indice != -1)
                            Console.WriteLine($"Elemento {valorBuscado} encontrado no índice {indice}.");
                        else
                            Console.WriteLine("Elemento não encontrado na lista.");
                        break;
                    case 4:
                        if (lista.Count == 0)
                            Console.WriteLine("A lista está vazia.");
                        else
                        {
                            Console.WriteLine("Elementos da lista: ");
                            foreach (var item in lista)
                            {
                                Console.Write(item + " ");
                            }
                            Console.WriteLine(); // Para nova linha após exibir a lista
                        }
                            break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);
        }
    }
}
