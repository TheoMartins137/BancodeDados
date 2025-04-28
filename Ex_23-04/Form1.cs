using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Ex_23_04
{
    public partial class Main : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=Ex23Abril";

        public Main()
        {
            InitializeComponent();

            lstJoin.View = View.Details;
            lstJoin.LabelEdit = true;
            lstJoin.AllowColumnReorder = true;
            lstJoin.FullRowSelect = true;
            lstJoin.GridLines = true;


            // Posição dos Cabeçalhos a serem exibidos na tela
            lstJoin.Columns.Add("Proprietário", 130, HorizontalAlignment.Left);
            lstJoin.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            lstJoin.Columns.Add("Modelo do carro", 75, HorizontalAlignment.Left);


            MetodoJoin();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuPessoa_Click(object sender, EventArgs e)
        {
            CadastroPessoa form = new CadastroPessoa();
            form.ShowDialog();
        }

        private void mnuCarro_Click(object sender, EventArgs e)
        {
            CadastrarCarro form = new CadastrarCarro();
            form.ShowDialog();
        }

        private void MetodoJoin()
        {

            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT p.nome, p.telefone, c.modelo " +
                             "FROM pessoa p " +
                             "JOIN carro c ON p.id = c.id_proprietario ";

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = buscar.ExecuteReader();

                lstJoin.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                };

                    var linha_lis_view = new ListViewItem(row);
                    lstJoin.Items.Add(linha_lis_view);

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
    }
}
