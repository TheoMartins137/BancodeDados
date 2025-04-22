using MySql.Data.MySqlClient;

namespace Arthur
{
    public partial class Form1 : Form
    {
        public int? id_contato_selecionado = null;

        MySqlConnection Conex�o;
        private string data_source = "datasource=localhost;username=root;password=;database=aulas_arthur";

        public Form1()
        {
            InitializeComponent();

            // configura��es
            ltvMostrar.View = View.Details;
            ltvMostrar.LabelEdit = true;
            ltvMostrar.AllowColumnReorder = true;
            ltvMostrar.FullRowSelect = true;
            ltvMostrar.GridLines = true;


            // Posi��o dos Cabe�alhos a serem exibidos na tela
            ltvMostrar.Columns.Add("ID", 30, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Email", 150, HorizontalAlignment.Left);
            ltvMostrar.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                Conex�o = new MySqlConnection(data_source); // abre a conex�o do banco de dados
                Conex�o.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conex�o;

                cmd.CommandText = "INSERT INTO contato(nome, email, telefone)" +
                                  "VALUES(@nome, @email, @telefone)";

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados inseridos com sucesso!");


                //string de conex�o para acessar o banco
                //insere os valores do formal�rio para dentro do banco de dados
                //string sql = "INSERT INTO contato (nome, email, telefone)" + "VALUES" + "(' " + txtNome.Text + " ' , ' " + txtEmail.Text + " ' , ' " + txtTelefone.Text + " ')";

                //MySqlCommand insert = new MySqlCommand(sql, Conex�o);

                //insert.ExecuteReader();

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
                Conex�o.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                Conex�o = new MySqlConnection(data_source);
                Conex�o.Open();
                string q = "%" + txtProcurar.Text + "%";
                // q = nome referente ao textbox

                string sql = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";


                // Buscar as informa��es
                MySqlCommand buscar = new MySqlCommand(sql, Conex�o);
                buscar.Parameters.AddWithValue("@q", q);

                // armazenar as informa��es para mostrar na tela
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
                Conex�o.Close();
            }

        }

        private void ltvMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = ltvMostrar.SelectedItems;

            foreach(ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;

            }
        }
    }
}
