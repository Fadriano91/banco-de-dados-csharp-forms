using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tarefa_SalvarMySql
{
    internal class Cliente
    {
        private int id;
        private string nome;
        private string email;
        private int idade;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Idade { get => idade; set => idade = value; }

        public static string salvar(Cliente c)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO cliente VALUES (null, @nome, @email, @idade)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@nome", c.Nome);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@idade", c.Idade);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch (Exception ex)
            {
                return "erro: " + ex.Message ;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM cliente";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de clientes \n";
            if(res.HasRows)
            {
                while(res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Nome: " + res["nome"].ToString();
                    lista += " - Idade: " + res["idade"].ToString();
                    lista += " - Email: " + res["email"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

        public static Boolean pesquisar(Cliente c)
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT cli.* FROM cliente cli WHERE cli.id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", c.Id);
            MySqlDataReader res = cmd.ExecuteReader();
            Boolean verificar = false;
            if (res.HasRows)
            {
                if (res.Read())
                {
                    c.Id = Int32.Parse(res["id"].ToString());
                    c.Nome = res["nome"].ToString();
                    c.Email = res["email"].ToString();
                    c.Idade = Int32.Parse(res["idade"].ToString());
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
                string sql = "DELETE FROM cliente WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                return "Cliente excluído";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }
    }
}
