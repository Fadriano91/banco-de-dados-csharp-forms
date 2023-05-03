﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_SalvarMySql.Class
{
    internal class Fornecedor
    {
        private int id;
        private string razaoSocial;
        private string email;
        private float cnpj;

        public int Id { get => id; set => id = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Email { get => email; set => email = value; }
        public float Cnpj { get => cnpj; set => cnpj = value; }

        public static string salvar(Fornecedor forn)
        {
            try
            {
                MySqlConnection conn = Conexao.obterConexao();
                string sql = "INSERT INTO fornecedor VALUES (null, @razaoSocial, @email, @cnpj)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@razaoSocial", forn.razaoSocial);
                cmd.Parameters.AddWithValue("@email", forn.email);
                cmd.Parameters.AddWithValue("@cnpj", forn.cnpj);
                cmd.ExecuteNonQuery();
                return "salvo com sucesso";
            }
            catch (Exception e)
            {
                return "erro: " + e.Message;
            }
        }

        public static string listar()
        {
            MySqlConnection conn = Conexao.obterConexao();
            string sql = "SELECT * FROM fornecedor";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader res = cmd.ExecuteReader();
            string lista = "Lista de fornecedores \n";
            if (res.HasRows)
            {
                while (res.Read())
                {
                    lista += "ID: " + res["id"].ToString();
                    lista += " - Razão Social: " + res["razaoSocial"].ToString();
                    lista += " - Email: " + res["email"].ToString();
                    lista += " - CNPJ: " + res["cnpj"].ToString();
                    lista += "\n";
                }
            }
            return lista;
        }

    }
}
