using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Ex_23_04
{
    public partial class CadastroPessoa : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=Ex23Abril";

        public int? pessoa_selecionada = null;

        public CadastroPessoa()
        {
            InitializeComponent();

            lstLista.View = View.Details;
            lstLista.LabelEdit = true;
            lstLista.AllowColumnReorder = true;
            lstLista.FullRowSelect = true;
            lstLista.GridLines = true;


            // Posição dos Cabeçalhos a serem exibidos na tela
            lstLista.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstLista.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstLista.Columns.Add("CPF", 75, HorizontalAlignment.Left);
            lstLista.Columns.Add("Telefone", 100, HorizontalAlignment.Left);

            MostrarPessoas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (pessoa_selecionada == null)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO pessoa (nome, cpf, telefone)" +
                                      "VALUES (@nome, @cpf, @telefone)";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pessoa inserida com Sucesso");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = 
                        "UPDATE pessoa " +
                        "SET nome = @nome, cpf = @cpf, telefone = @telefone " +
                        "WHERE id = @id";

                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", pessoa_selecionada);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pessoa Atualizado com Sucesso");
                }

                pessoa_selecionada = null;
                txtNome.Clear();
                txtCPF.Clear();
                txtTelefone.Clear();
                MostrarPessoas();
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

        private void MostrarPessoas()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT * FROM pessoa ORDER BY id ASC";
                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = buscar.ExecuteReader();

                lstLista.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3)
                    };

                    var linha_lis_view = new ListViewItem(row);
                    lstLista.Items.Add(linha_lis_view);

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

        private void lstLista_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionado = lstLista.SelectedItems;

            foreach(ListViewItem item in itens_selecionado)
            {
                pessoa_selecionada = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtCPF.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
        }
    }
}
