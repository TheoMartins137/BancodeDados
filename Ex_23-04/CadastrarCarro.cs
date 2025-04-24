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
    public partial class CadastrarCarro : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=Ex23Abril";
        public int? id_carro = null;


        public CadastrarCarro()
        {
            InitializeComponent();

            lstLista.View = View.Details;
            lstLista.LabelEdit = true;
            lstLista.AllowColumnReorder = true;
            lstLista.FullRowSelect = true;
            lstLista.GridLines = true;


            lstLista.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lstLista.Columns.Add("Marca", 150, HorizontalAlignment.Left);
            lstLista.Columns.Add("Modelo", 75, HorizontalAlignment.Left);
            lstLista.Columns.Add("Id do Proprietário", 100, HorizontalAlignment.Left);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (id_carro == null)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO carro(marca, modelo, id_proprietario)" +
                                      "VALUES (@marca, @modelo, @id_proprietario)";

                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    cmd.Parameters.AddWithValue("@id_proprietario", txtID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Carro cadastrado com Sucesso");
                }
                else
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "UPDATE carro " +
                                      "SET marca = @marca, modelo = @modelo, id_proprietario = @id_proprietario " +
                                      "WHERE id = @id";

                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
                    cmd.Parameters.AddWithValue("@id_proprietario", txtID.Text);
                    cmd.Parameters.AddWithValue("@id", id_carro.ToString());
                }

                id_carro = null;
                txtID.Clear();
                txtMarca.Clear();
                txtModelo.Clear();
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



        private void lstLista_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionado = lstLista.SelectedItems;

            foreach(ListViewItem item in itens_selecionado)
            {
                id_carro = Convert.ToInt32(item.SubItems[0].Text);
                txtMarca.Text = item.SubItems[1].Text;
                txtModelo.Text = item.SubItems[2].Text;
                txtID.Text = item.SubItems[3].Text;

            }
        }

        private void MostrarCarro()
        {

        }
    }
}
