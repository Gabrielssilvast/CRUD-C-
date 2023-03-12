using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoVersat
{
    static class ConexaoBanco
    {
        //4 variáveis do Banco de dados
        private const string servidor = "localhost";
        private const string bancoDados = "dbprojetoVersat1";
        private const string usuario = "root";
        private const string senha = "123@456789";

        //Declarando variavel para conectar ao Banco de dados
        //static public string banco1 = $"server={servidor};uid={usuario};database={bancoDados};password={senha}";

        //Vericando se ocorreu a conexão
        //lbl1.Text = $"A conexão com o banco {bancoDados} foi realizada com sucesso!";
    }
        //MessageBox.Show("Ocorreu um erro" + ex.Message);


}

