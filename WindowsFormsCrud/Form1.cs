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


        private int ?id_produto = null;


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



        //botão salvar
        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                
                Conexao = new MySqlConnection(con);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if(id_produto == null)
                {
                    //insere novo produto
                    cmd.CommandText = "INSERT INTO db_produto (nomeproduto,quantidade,preco) VALUES (@nomeproduto,@quantidade,@preco)";
                    //cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nomeproduto", campoNomeProd.Text);
                    cmd.Parameters.AddWithValue("@quantidade", campoQuantidade.Text);
                    cmd.Parameters.AddWithValue("@preco", campoPreco.Text);
 
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Inserido com SUCESSO! ");
                    
                    campoNomeProd.Clear();
                    campoQuantidade.Clear();
                    campoPreco.Clear();


               }
               else
                {
                    //atualiza produto 
                    cmd.CommandText = "UPDATE db_produto SET nomeproduto=@nomeproduto, quantidade=@quantidade, preco=@preco WHERE id=@id";
                    //cmd.Prepare();
                    cmd.Parameters.AddWithValue("@nomeproduto", campoNomeProd.Text);
                    cmd.Parameters.AddWithValue("@quantidade", campoQuantidade.Text);
                    cmd.Parameters.AddWithValue("@preco", campoPreco.Text);
                    cmd.Parameters.AddWithValue("@id", id_produto);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Inserido com SUCESSO! ");
                   // carregar_listagem();

                    campoNomeProd.Clear();
                    campoQuantidade.Clear();
                    campoPreco.Clear();

                }

                //limpar tela e atualizar listagem
                campoListagem.Items.Clear();
                carregar_listagem();

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



        //campo listagem, pega informações do item selecionado
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = campoListagem.SelectedItems;

            //loop para pegar os dados do item selecionado
            foreach(ListViewItem itens in itens_selecionados)
            {
                id_produto = Convert.ToInt32(itens.SubItems[0].Text); 
                campoNomeProd.Text = itens.SubItems[1].Text;
                campoQuantidade.Text = itens.SubItems[2].Text;
                campoPreco.Text = itens.SubItems[3].Text;
            }
        }


        //botão busca(pesquisar)
        private void botaoPesquisa_Click_1(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(con);

                string busca = "'%" + campoPesquisa.Text + "%'";

                string sql = "SELECT * FROM db_produto WHERE nomeproduto LIKE " + busca ;

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



        //campo listagem, tela carregada com as informações da base
        private void carregar_listagem()
        {
            try
            {
                Conexao = new MySqlConnection(con);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM db_produto ORDER BY id DESC ";
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

                    campoListagem.Items.Add(new ListViewItem(linha));
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

    }
}
