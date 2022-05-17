using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsCrud
{
    public partial class Sistema : Form
    {
        MySqlConnection Conexao;
        //cria conexao com o banco de dados
        //https://mysqlconnector.net/connection-options/
        string con = ("server=localhost;user=root;password=;database=crud-ibid");

        public Sistema()
        {
            InitializeComponent();

            //contrução colunas campo listagem
            campoListagem.View = View.Details;
            campoListagem.GridLines = true;
            campoListagem.LabelEdit = true;
            campoListagem.FullRowSelect = true;
            //campoListagem.AllowColumnReorder = true;

            campoListagem.Columns.Add("ID", 50, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Nome Produto", 230, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Quatidade", 100, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Preço", 50, HorizontalAlignment.Left);

            //chamada para listagem
            carregar_listagem();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(con);

                string sql = "INSERT INTO db_produto(nome_produto,quantidade,preco) VALUES ('" + campoNomeProd + "' ,'" + campoQuantidade + "' ,'" + campoPreco + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show(" Inserido com SUCESSO! ");
                campoNomeProd.Clear();
                campoQuantidade.Clear();
                campoPreco.Clear();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
            finally
            {
                Conexao.Close();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botaoPesquisa_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(con);

                string busca = "'%" + campoPesquisa.Text + "%'";

                string sql = "SELECT * FROM db_produto WHERE nome_produto LIKE " + busca ;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                MySqlDataReader leitor = comando.ExecuteReader();
                campoListagem.Items.Clear();

                //loop para buscar os dados
                while (leitor.Read())
                {
                    string[] linha =
                    {
                        leitor.GetString(0),
                        leitor.GetString(1),
                        leitor.GetString(2),
                        leitor.GetString(3),
                    };

                    var linhaListagem = new ListViewItem(linha);

                    campoListagem.Items.Add(linhaListagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void carregar_listagem()
        {
            try
            {
                Conexao = new MySqlConnection(con);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM db_produto ORDER BY id DESC ";
                cmd.Parameters.AddWithValue("@busca", "%" + campoPesquisa.Text + "%");
                cmd.Prepare();
     
                MySqlDataReader reader = cmd.ExecuteReader();
                //campoListagem.Items.Clear();

                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };
                }

            }
            catch
            {

            }
        }

    }
}
