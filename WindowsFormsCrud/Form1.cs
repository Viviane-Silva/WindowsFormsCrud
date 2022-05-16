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
        string con = ("server=localhost;user=root;password=;database=crud-ibid");

        public Form1()
        {
            InitializeComponent();
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
               
                MySqlDataReader reader = comando.ExecuteReader();
                //loop para pegar todos os dados e mostrar na lista
                while (reader.Read())
                {
                    string[] linha =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                    };

                    var linha_lista = new ListViewItem(linha_lista);
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

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(con);

                string busca = "%" + campoPesquisa.Text + "%";

                string sql = "SELECT * FROM db_produto WHERE nome LIKE " +busca+ " OR quantidade "+ busca;

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                Conexao.Open();
                comando.ExecuteReader();

            }
            catch(Exception ex)
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
