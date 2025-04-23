using MySql.Data.MySqlClient;

namespace Arthur
{
    public partial class Form1 : Form
    {
        public int ?id_contato_selecionado = null;

        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=aulas_arthur";

        public Form1()
        {
            InitializeComponent();

            // configurações
            ltvMostrar.View = View.Details;
            ltvMostrar.LabelEdit = true;
            ltvMostrar.AllowColumnReorder = true;
            ltvMostrar.FullRowSelect = true;
            ltvMostrar.GridLines = true;


            // Posição dos Cabeçalhos a serem exibidos na tela
            ltvMostrar.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Email", 150, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            carregar_contatos();
        }

        private void carregar_contatos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT * FROM contato ORDER BY id ASC";

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = buscar.ExecuteReader();

                ltvMostrar.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    var linha_list_view = new ListViewItem(row);
                    ltvMostrar.Items.Add(linha_list_view);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                // Criar a Conexao com o MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // Habilitando o Update para o meu botão salvar

                if (id_contato_selecionado == null)
                {
                    // insert
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "INSERT INTO contato " +
                        "(nome, email, telefone) " +
                        "VALUES " +
                        "(@nome, @email, @telefone)";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Inserido com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "UPDATE contato " +
                        "SET nome = @nome, email = @email, telefone = @telefone " +
                        "WHERE id = @id";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", id_contato_selecionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Atualizado com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }



                /* string sql = "INSERT INTO contato (nome, email, telefone) VALUES ('" + txtNome.Text + "','" + txtEmail.Text + "','" + txtTelefone.Text + "')";

                // Executar Comando Insert
                MySqlCommand insert = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                insert.ExecuteReader(); */


                // Mostrando a Mensagem para o Usuário
                //MessageBox.Show("Dados Inseridos com Sucesso!!!");
                // apagando o formulario após a inserção dos dados
                id_contato_selecionado = null;
                txtNome.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtTelefone.Text = String.Empty;

                carregar_contatos();

            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Error " + "has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                string q = "%" + txtProcurar.Text + "%";
                // q = nome referente ao textbox

                string sql = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";


                // Buscar as informações
                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                buscar.Parameters.AddWithValue("@q", q);

                // armazenar as informações para mostrar na tela
                MySqlDataReader reader = buscar.ExecuteReader();

                ltvMostrar.Items.Clear();

                while (reader.Read())
                {
                    string[] linha =
                    {
                        //obter os dados do banco
                        reader.GetInt32(0).ToString(),  //id
                        reader.GetString(1),            //nome
                        reader.GetString(2),            //email 
                        reader.GetString(3)             //telefone
                    };
                    var linha_list_view = new ListViewItem(linha);
                    ltvMostrar.Items.Add(linha_list_view);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

        }

        private void ltvMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*ListView.SelectedListViewItemCollection itens_selecionados = ltvMostrar.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;

            }*/
        }

        private void ltvMostrar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = ltvMostrar.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
        }
    }
}
