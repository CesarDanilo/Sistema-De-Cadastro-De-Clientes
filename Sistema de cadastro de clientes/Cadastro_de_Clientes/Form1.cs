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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string strconnection = "Database=CLIENTES_DB;Server=127.0.0.1;Uid=root;Pwd=root;";
            MySqlConnection conn = new MySqlConnection(strconnection);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand($"INSERT INTO TB_CLIENTES VALUES (NULL, '{tbx_nome.Text}', '{mkx_data_nacimento.Text}', '{tbx_email.Text}', '{tbx_cpf_cnpf.Text}', '{tbx_contato.Text}', '{cbx_sexo.Text}', CURRENT_TIMESTAMP(), '{txt_descricao.Text}', '{cbx_ativo.Text}', '{tbx_cidade.Text}', '{tbx_bairro.Text}', '{tbx_rua.Text}', '{tbx_numero.Text}', '{cbx_uf.Text}', '{mkx_cep.Text}', '{txt_descricao.Text}');", conn);
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
        }

        private void cbx_tipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
