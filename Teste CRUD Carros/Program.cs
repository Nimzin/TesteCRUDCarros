using Teste_CRUD_Carros;

public class Program
{
    public static void Main(string[] args)
    {
        List<Carro> carros = new List<Carro>();

        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("1 - Adicionar Carro");
            Console.WriteLine("2 - Listar Carros");
            Console.WriteLine("3 - Atualizar Carro");
            Console.WriteLine("4 - Remover Carro");
            Console.WriteLine("5 - Sair");

            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:AdicionarCarro(carros);
                    break;
                case 2:
                    ListarCarros(carros);
                    break;
                case 3:AtualizarCarro(carros);
                    break;
                case 4: RemoverCarro(carros);
                    break;
                case 5:
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida");
                    break;
            }
        }
   
    }
    public static void AdicionarCarro(List<Carro> carros)
    {
        Console.WriteLine("Informe a Marca:");
        string marca = Console.ReadLine();

        Console.WriteLine("Informe o Modelo:");
        string modelo = Console.ReadLine();

        Console.WriteLine("Informe o Ano:");
        int ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o Preço:");
        decimal preco = decimal.Parse(Console.ReadLine());

        carros.Add(new Carro(marca, modelo, ano, preco));
    }
    public static void ListarCarros(List<Carro> carros)
    {
        if (carros.Count == 0)
        {
            Console.WriteLine("Nenhum carro cadastrado");
        }
        else
        {
            Console.WriteLine("Lista de Carros");
            for (int i = 0; i < carros.Count; i++)
            {
                Console.WriteLine($"{i +1}. {carros[i]}");
            }
        }
    }

    public static void AtualizarCarro(List<Carro> carros)
    {
        if (carros.Count == 0)
        {
            Console.WriteLine("Nenhum carro para ser atualizado");
            return;
        }
        Console.WriteLine("Escolha o carro para atualizar");
        for (int i = 0;i < carros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {carros[i]}");
        }

        int indice;
        while (true)
        {
            Console.WriteLine("Informe o número do carro que deseja atualizar:");
            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= carros.Count)
            {
                indice--;
                break;
            }
        Console.WriteLine("Número invalido, tente novamente");
        }
        
        Console.WriteLine("Informe a nova Marca (ou pressione Enter para manter a atual):");
        string novaMarca = Console.ReadLine();
        if (!string.IsNullOrEmpty(novaMarca))
        {
            carros[indice].Marca = novaMarca;
        }
        Console.WriteLine("Informe o novo Modelo (ou pressione Enter para manter o atual):");
        string novoModelo = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoModelo))
        {
            carros[indice].Modelo = novoModelo;
        }
        Console.WriteLine("Informe o novo Ano (ou pressione Enter para manter o atual):");
        string novoAno = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoAno) && int.TryParse(novoAno, out int anoAtualizado))
        {
            carros[indice].Ano = anoAtualizado;
        }

        Console.WriteLine("Informe o novo Preço (ou pressione Enter para manter o atual):");
        string novoPreco = Console.ReadLine();
        if (!string.IsNullOrEmpty(novoPreco) && decimal.TryParse(novoPreco, out decimal precoAtualizado))
        {
            carros[indice].Preco = precoAtualizado;
        }

        Console.WriteLine("Carro atualizado com sucesso!");
    }

    public static void RemoverCarro(List<Carro> carros)
    {
        if(carros.Count == 0)
        {
            Console.WriteLine("Nenhum carro a ser removido");
            return;
        }
        Console.WriteLine("Escolha o carro que deseja remover");
        for (int i = 0; i < carros.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {carros[i]}");
        }
        int indice;
        while (true)
        {
            Console.WriteLine("Informe o número do carro que deseja remover:");
            if (int.TryParse(Console.ReadLine(), out indice) && indice > 0 && indice <= carros.Count)
            {
                indice--;
                break;
            }
            Console.WriteLine("Número inválido, tente novamente.");
        }
        Console.WriteLine($"Tem certeza que deseja remover o carro{carros[indice]}? (S/N)");
        string confirmacao = Console.ReadLine().ToUpper();
        if (confirmacao == "S")
        {
            carros.RemoveAt(indice);
            Console.WriteLine("Carro removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Remoção cancelada.");
        }
    }
}
    
