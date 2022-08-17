using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Cadastro_de_Clientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            start_table();
        }

        // SALVAR
        private void btn_save_Click(object sender, EventArgs e)
        {
            #region string Connection

            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            #endregion

            #region Insert

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO TB_CLIENTES VALUES (NULL, '{tbx_nome.Text}', '{mkx_data_nacimento.Text}', '{tbx_email.Text}', '{tbx_cpf_cnpf.Text}', '{tbx_contato.Text}', '{cbx_sexo.Text}', CURRENT_TIMESTAMP(), '{cbx_tipo.Text}', '{cbx_ativo.Text}', '{tbx_cidade.Text}', '{tbx_bairro.Text}', '{tbx_rua.Text}', '{tbx_numero.Text}', '{cbx_uf.Text}', '{mkx_cep.Text}', '{txt_descricao.Text}');", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("cadastrado com Súcesso!");


            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conn.Close();
            }

            #endregion

            start_table();

        }

        private void start_table()
        {
            dataGridView1.Rows.Clear();

            #region String Connection

            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            #endregion

            #region SELECT
            try
            {
                string query = "SELECT * FROM TB_CLIENTES;";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, strconnection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                foreach (DataRow data in dt.Rows)
                {
                    dataGridView1.Rows.Add(data.ItemArray);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            #endregion

        }

        // PESQUISAR
        private void btn_search_Click(object sender, EventArgs e)
        {

            if (tbx_id.Text == null)
            {

                dataGridView1.Rows.Clear();
                #region String Connection

                string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
                MySqlConnection conn = new MySqlConnection(strconnection);

                #endregion

                string query = $"SELECT * FROM TB_CLIENTES where CLIENTE_NOME = '{tbx_name_search.Text}';";

                DataTable dt = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, strconnection);
                mySqlDataAdapter.Fill(dt);

                foreach (DataRow data in dt.Rows)
                {
                    dataGridView1.Rows.Add(data.ItemArray);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                #region String Connection

                string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
                MySqlConnection conn = new MySqlConnection(strconnection);

                #endregion

                string query = $"SELECT * FROM TB_CLIENTES where ID_CLIENTE = '{tbx_id.Text}';";

                DataTable dt = new DataTable();
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, strconnection);
                mySqlDataAdapter.Fill(dt);

                foreach (DataRow data in dt.Rows)
                {
                    dataGridView1.Rows.Add(data.ItemArray);
                }
            }


        }

        // DELETAR
        private void btn_delete_Click(object sender, EventArgs e)
        {
            #region String Connection

            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            #endregion

            #region Delete

            try
            {
                conn.Open();
                string query = $"DELETE FROM TB_CLIENTES WHERE ID_CLIENTE = {tbx_id.Text}";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deletado com Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            #endregion

            start_table();
        }

        // ATUALIZAR
        private void btn_update_Click(object sender, EventArgs e)
        {
            #region String Connection

            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            #endregion

            #region Update

            try
            {
                conn.Open();
                string query = $"UPDATE TB_CLIENTES SET " +
                    $"CLIENTE_NOME = '{tbx_nome.Text}', " +
                    $"CLIENTE_IDADE = '{mkx_data_nacimento.Text}'," +
                    $" CLIENTE_EMAIL = '{tbx_email.Text}', " +
                    $" CLIENTE_CPF_CNPJ = '{tbx_cpf_cnpf.Text}', " +
                    $" CLIENTE_CONTATO = '{tbx_contato.Text}', " +
                    $" CLIENTE_SEXO = '{cbx_sexo.Text}', " +
                    $" CLIENTE_TIPO ='{cbx_tipo.Text}', " +
                    $" CLIENTE_ATIVO = '{cbx_ativo.Text}', " +
                    $" CLIENTE_CIDADE = '{tbx_cidade.Text}'," +
                    $" CLIENTE_BAIRRO = '{tbx_bairro.Text}', " +
                    $" CLIENTE_RUA = '{tbx_rua.Text}'," +
                    $" CLIENTE_NUMERO = '{tbx_numero.Text}', " +
                    $" CLIENTE_UF = '{cbx_uf.Text}'," +
                    $" CLIENTE_CEP = '{mkx_cep.Text}', " +
                    $" CLIENTE_DESCRICAO = '{txt_descricao.Text}'" +
                    $"WHERE ID_CLIENTE = {tbx_id.Text};";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            #endregion


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            #region String Connection

            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            #endregion

            string query = $"SELECT * FROM TB_CLIENTES;";

            DataTable dt = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, strconnection);
            mySqlDataAdapter.Fill(dt);

            foreach (DataRow data in dt.Rows)
            {
                dataGridView1.Rows.Add(data.ItemArray);
            }

        }

        private void cbx_tipo_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
