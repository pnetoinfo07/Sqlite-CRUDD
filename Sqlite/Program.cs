using Sqlite;

InicializadorBd.Inicializar();
ProdutoRepository _repository = new ProdutoRepository();
int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine("====     MENU DE PRODUTOS    ===");
    Console.WriteLine("1 - Adiconar Produto");
    Console.WriteLine("2 - Listar Produtos");
    Console.WriteLine("3 - Editar Produto");
    Console.WriteLine("4 - Excluir Produto");
    Console.WriteLine("5 - Buscar Produto por Id");
    Console.WriteLine("0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Nome do Produto");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            double preco = double.Parse(Console.ReadLine());
            _repository.AdicionarProduto(nome, preco);
            Console.WriteLine("Produto adicionado com sucesso.");
            break;
        case 2:
            _repository.ListarProdutos();
            break;
        case 3:
            Console.WriteLine("Qual Id do produto que deseja editar");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nome do Produto");
            nome = Console.ReadLine();
            Console.WriteLine("Preço do Produto");
            preco = double.Parse(Console.ReadLine());
            _repository.EditarProduto(id,nome,preco);
            break;
        case 4:
            Console.WriteLine("Qual Id do produto que deseja editar");
            id = int.Parse(Console.ReadLine());
            _repository.ExcluirProduto(id);
            break;
        case 5:
            Console.WriteLine("Qual Id do produto que deseja editar");
            id = int.Parse(Console.ReadLine());
            _repository.BuscarProdutoPorId(id);
            break;
        case 0:
            Console.WriteLine("Saindo . . . ");
            break;
    }
}
