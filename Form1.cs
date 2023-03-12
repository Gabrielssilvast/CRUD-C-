
using MySql.Data.MySqlClient;

namespace projetoVersat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validando se os campos estão preenchidos
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCpf.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    //Instanciando e passando as informações para o banco de dados
                    CadastroClientes cadClientes = new CadastroClientes();
                    cadClientes.Nome = txtNome.Text;
                    cadClientes.Email = txtEmail.Text;
                    cadClientes.Cpf = txtCpf.Text;
                    cadClientes.Endereco = txtEndereco.Text;
                    if (cadClientes.CadastrarClientes())
                    {
                        MessageBox.Show($"O Cliente: {cadClientes.Nome} foi cadastrado com sucesso!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar o Cliente!");
                    }
                }
                else
                {
                    //Validando o preenchimento dos campos
                    MessageBox.Show("Favor preencher todos os campos corretamente!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals(""))
                {
                    CadastroClientes cadClientes = new CadastroClientes();
                    cadClientes.Cpf = txtCpf.Text;

                    MySqlDataReader reader = cadClientes.localizarCliente();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblid.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado!");
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtCpf.Clear();
                            txtEndereco.Clear();
                            txtNome.Focus();
                            lblid.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                        lblid.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher o campo CPF para realziar a pesquisa!");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                    lblid.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar cliente: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtEndereco.Clear();
            lblid.Text = "";

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroClientes cadClientes = new CadastroClientes();
                    cadClientes.Id = int.Parse(lblid.Text);
                    cadClientes.Email = txtEmail.Text;
                    cadClientes.Endereco = txtEndereco.Text;

                    if (cadClientes.atualizarCliente())
                    {
                        MessageBox.Show("Os dados do Cliente foram atualizadas! ");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblid.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar os dados do Cliente! ");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        txtCpf.Focus();
                        lblid.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Favor localizar o cliente que deseja atualizar ");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblid.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do Cliente: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCpf.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    CadastroClientes cadClientes = new CadastroClientes();
                    cadClientes.Id = int.Parse(lblid.Text);
                    if (cadClientes.deletarCliente())
                    {
                        MessageBox.Show("O cliente foi deletado com sucesso! ");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        lblid.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível deletar o Cliente ");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCpf.Clear();
                        txtEndereco.Clear();
                        lblid.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar o cliente que deseja deletar ");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCpf.Clear();
                    txtEndereco.Clear();
                    txtCpf.Focus();
                    lblid.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Cliente! " + ex.Message);

            }
        }
    }
}