using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqlite;

public class ProdutoRepository
{
    private readonly string ConnectionString = "Data Source=LojaBD.db";
    public void AdicionarProduto(string nome, double preco)
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            string comandInsert = @"INSERT INTO Produtos(Nome,Preco) 
                                    VALUES (@Nome,@Preco)";

            using (var command = new SQLiteCommand(comandInsert, connection))
            {
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Preco", preco);
                command.ExecuteNonQuery();
            }
        }
    }
    public void ListarProdutos()
    {
        using (var connection = new SQLiteConnection(ConnectionString))
        {
            connection.Open();
            var selectCommand = "SELECT Id, Nome, Preco FROM Produtos;";
            using (var command = new SQLiteCommand(selectCommand, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]} - Nome: {reader["Nome"]} - Preco: {reader["Preco"]}");
                    }
                }
            }
        }
    }
}
