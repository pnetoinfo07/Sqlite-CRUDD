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
}
