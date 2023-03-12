using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Con = MySql.Data.MySqlClient;

namespace projetoVersat
{
    internal class CadastroClientes
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }

        }

        //Metodo para cadastrar funcionário no banco de dados.
        public bool CadastrarClientes()
        {
            try
            {
                Con.MySqlConnection conexao = new Con.MySqlConnection("server=localhost;uid=root;pwd=123@456789;database=dbprojetoVersat1");
                conexao.Open();
                string query = $"INSERT INTO clientes (nome,email,cpf,endereco) VALUES ('{Nome}','{Email}','{Cpf}','{Endereco}')";

                Con.MySqlCommand comandoSql = conexao.CreateCommand();
                comandoSql.CommandText = query;

                comandoSql.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                //Mensagem de erro do banco de dados
                MessageBox.Show("Erro no banco de dados: método cadastrarClientes" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarCliente()
        {
            try
            {
                Con.MySqlConnection conexao = new Con.MySqlConnection("server=localhost;uid=root;pwd=123@456789;database=dbprojetoVersat1");
                conexao.Open();

                string select = $"select id, nome, email, cpf, endereco from clientes where cpf = '{Cpf}';";
                Con.MySqlCommand comandoSql = conexao.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados Método: localizarCliente " + ex.Message);
                return null;
            }

        }

        public bool atualizarCliente()
        {
            try
            {
                Con.MySqlConnection conexao = new Con.MySqlConnection("server=localhost;uid=root;pwd=123@456789;database=dbprojetoVersat1");
                conexao.Open();

                string update = $"update clientes set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";
                Con.MySqlCommand comandoSql = conexao.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método: atualizarCliente " + ex.Message);
                return false;
            }
        }

        public bool deletarCliente()
        {
            try
            {
                Con.MySqlConnection conexao = new Con.MySqlConnection("server=localhost;uid=root;pwd=123@456789;database=dbprojetoVersat1");
                conexao.Open();

                string delete = $"delete from clientes where id = '{Id}';";
                Con.MySqlCommand comandoSql = conexao.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - Método deletarCliente " + ex.Message);
                return false;
            }
        }
    }
}
