using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class Form1 : Form
    {

        public string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";

        public Form1()
        {
            InitializeComponent();
            start_table();
        }

        //
        // START TABLE
        //

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

        // 
        // TO SALVE [ btn_save_Click ]
        //

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

        //
        // SEARCH [ btn_search_Click ]
        //

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_id.Text))
            {
                dataGridView1.Rows.Clear();

                DataTable dt = new DataTable();
                string query = $"SELECT * FROM TB_CLIENTES WHERE CLIENTE_NOME = '{tbx_name_search.Text}';";

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, strconnection);
                mySqlDataAdapter.Fill(dt);

                foreach (DataRow data in dt.Rows)
                {
                    dataGridView1.Rows.Add(data.ItemArray);
                }
            }

            if(!string.IsNullOrEmpty(tbx_id.Text))
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

                GetDataString();

            }

        }

        //
        // DELETE [ btn_delete_Click ]
        //

        private void btn_delete_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(strconnection);
            string query = $"DELETE FROM TB_CLIENTES WHERE ID_CLIENTE = {tbx_id.Text}";

            #region Delete

            try
            {
                conn.Open();

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
                start_table();
            }

            #endregion

            
        }

        //
        // EDITAR [ btn_update_Click ]
        //

        private void btn_update_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(strconnection);

            try
            {
                conn.Open();

                #region Query

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

                #endregion

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                start_table();
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
        }

        //
        // UPDATE [ button1_Click ]
        //

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string query = $"SELECT * FROM TB_CLIENTES;";
            DataTable dt = new DataTable();

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, strconnection);
            mySqlDataAdapter.Fill(dt);

            foreach (DataRow data in dt.Rows)
            {
                dataGridView1.Rows.Add(data.ItemArray);
            }

        }

        //
        // GetDataString
        //

        private void GetDataString()
        {
            string query = $"SELECT * FROM TB_CLIENTES WHERE ID_CLIENTE = {tbx_id.Text};";
            MySqlConnection conn = new MySqlConnection(strconnection);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                dr.Read();

                tbx_nome.Text = dr.GetString(1);
                mkx_data_nacimento.Text = dr.GetString(2);
                tbx_email.Text = dr.GetString(3);
                tbx_cpf_cnpf.Text = dr.GetString(4);
                tbx_contato.Text = dr.GetString(5);
                cbx_sexo.Text = dr.GetString(6);
                label11.Text = dr.GetString(7);
                cbx_tipo.Text = dr.GetString(8);
                cbx_ativo.Text = dr.GetString(9);
                tbx_cidade.Text = dr.GetString(10);
                tbx_bairro.Text = dr.GetString(11);
                tbx_rua.Text = dr.GetString(12);
                tbx_numero.Text = dr.GetString(13);
                cbx_uf.Text = dr.GetString(14);
                mkx_cep.Text = dr.GetString(15);
                txt_descricao.Text = dr.GetString(16);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //
        // DESCRIÇÃO [ cbx_tipo_TextChanged ]
        //

        private void cbx_tipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
