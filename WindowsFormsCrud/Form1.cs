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

                
                Conexao = new MySqlConnection("server=localhost;user=root;password=;database=crud-ibid");

               
                string sql = "INSERT INTO db_produto(nome_produto,quantidade,preco) VALUES ('" + campoNomeProd + "' ,'" + campoQuantidade + "' ,'" + campoNomeProd +"')";

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
    }
}
