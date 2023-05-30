using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_SalvarMySql.Class
{
    internal class Produto
    {
        private int id;
        private string nome;
        private int quantidadeEstoque;
        private int id_categoria;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int QuantidadeEstoque { get => quantidadeEstoque; set => quantidadeEstoque = value; }
        public int Id_categoria { get => id_categoria; set => id_categoria = value; }

        public static string salvar( Produto prod )
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO produto VALUES (null, @nome, @quantidadeEstoque, @id_categoria)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", prod.nome);
                cmd.Parameters.AddWithValue("@quantidadeEstoque", prod.quantidadeEstoque);
                cmd.Parameters.AddWithValue("@id_categoria", prod.id_categoria);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch ( Exception e ) 
            {
                return "erro: " + e.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT  p.id, p.nome, p.quantidadeEstoque, c.nome as categoria FROM produto p INNER JOIN categoria c ON c.id = p.id_categoria";
            MySqlCommand cmd = new MySqlCommand( sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de produtos \n";
            if(res.HasRows)
            {
                while(res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Produto: " + res["nome"].ToString();
                    lista += " - Quantidade no Estoque: " + res["quantidadeEstoque"].ToString();
                    lista += " - Categoria: " + res["categoria"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

        public static Boolean pesquisar(Produto p)
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT prod.* FROM produto prod WHERE prod.id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", p.Id);
            MySqlDataReader res = cmd.ExecuteReader();
            Boolean verificar = false;
            if (res.HasRows)
            {
                if (res.Read())
                {
                    p.Id = Int32.Parse(res["id"].ToString());
                    p.Nome = res["nome"].ToString();
                    p.QuantidadeEstoque = Int32.Parse(res["quantidadeEstoque"].ToString());
                    verificar = true;
                }
            }
            return verificar;
        }

        public string excluir(string id)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "DELETE FROM produto WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Produto excluído";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }
    }
}
