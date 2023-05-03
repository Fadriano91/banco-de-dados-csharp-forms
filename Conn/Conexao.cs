using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Tarefa_SalvarMySql
{
    class Conexao
    {

    private static MySqlConnection conn = null;

    public static MySqlConnection obterConexao()
    {
        conn = new MySqlConnection("Server=localhost;Database=bdaula;Uid=root;Pwd=;");
        
        try
        {
            conn.Open();
        }
        catch(Exception ex) 
        {
            conn = null;
            MessageBox.Show(ex.Message);
        }
            return conn;
    }
    }
}
