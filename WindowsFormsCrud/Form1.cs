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
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;
        //cria conexao com o banco de dados
        //https://mysqlconnector.net/connection-options/
        string con = ("server=localhost;user=root;password=;database=crud-ibid");

        public Form1()
        {
            InitializeComponent();

            campoListagem.Columns.Add("ID", 30, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Nome Produto", 130, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Quatidade", 50, HorizontalAlignment.Left);
            campoListagem.Columns.Add("Preço", 50, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Conexao = new MySqlConnection(con);

                string sql = "INSERT INTO db_produto(nome_produto,quantidade,preco) VALUES ('" + campoNomeProd + "' ,'" + campoQuantidade + "' ,'" + campoPreco + "')";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show(" Inserido com SUCESSO! ");


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

        private void label1_Click_1(object sender, EventArgs e)
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

                    campoListagem.Items.Add(linhaListagem.Text);
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

        private void textoPreco_Click(object sender, EventArgs e)
        {

        }
    }
}
