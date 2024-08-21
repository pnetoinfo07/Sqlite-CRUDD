using Sqlite;

InicializadorBd.Inicializar();
ProdutoRepository _repository = new ProdutoRepository();
int opcao = -1;

while (opcao != 0)
{
    Console.WriteLine("====     MENU DE PRODUTOS    ===");
    Console.WriteLine("1 - Adiconar Produto");
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
        case 0:
            Console.WriteLine("Saindo . . . ");
            break;
    }
}
