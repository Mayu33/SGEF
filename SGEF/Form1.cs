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

namespace SGEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                tb_id.Text = dataGridView1.Rows[e.RowIndex].Cells["col_id"].FormattedValue.ToString();
                tb_qtd.Text = dataGridView1.Rows[e.RowIndex].Cells["col_qtd"].FormattedValue.ToString();
                tb_nome.Text = dataGridView1.Rows[e.RowIndex].Cells["col_nome"].FormattedValue.ToString();
                tb_laboratorio.Text = dataGridView1.Rows[e.RowIndex].Cells["col_laboratorio"].FormattedValue.ToString();
                tb_lote.Text = dataGridView1.Rows[e.RowIndex].Cells["col_lote"].FormattedValue.ToString();
                tb_validade.Text = dataGridView1.Rows[e.RowIndex].Cells["col_validade"].FormattedValue.ToString();
                tb_codigoDeBarras.Text = dataGridView1.Rows[e.RowIndex].Cells["col_codigodebarras"].FormattedValue.ToString();
            }

            btn_novo.Enabled = false;
            btn_editar.Enabled = true;
            btn_excluir.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = true;
            btn_pesquisar.Enabled = true;

            desabilitarCampos();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "sgef";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());


            try
            {
                connectionString.Open();
                //MessageBox.Show("Connection open");
                MySqlCommand cmd = connectionString.CreateCommand();

                if (string.IsNullOrWhiteSpace(tb_id.Text)) { 
                
                cmd.CommandText = "INSERT INTO produtos (produto_qtd, produto_nome, produto_laboratorio, produto_lote, produto_validade, produto_codigodebarras) " +
                    "VALUES ('" + tb_qtd.Text + "','" + tb_nome.Text + "','" + tb_laboratorio.Text + "','" + tb_lote.Text + "','" + tb_validade.Text + "','"
                    + tb_codigoDeBarras.Text + "')";
                    cmd.ExecuteNonQuery();
                    connectionString.Close();
                    MessageBox.Show("Salvo com sucesso");


                } else {
                    cmd.CommandText = "UPDATE produtos SET produto_qtd = '" + tb_qtd.Text + "', " + "produto_nome = '"
                            + tb_nome.Text + "', " + "produto_labotario = '" + tb_laboratorio.Text + "', " + "produto_lote = '"
                            + tb_lote.Text + "', " + "produto_validade = '" + tb_validade.Text + "', " + " produto_codigodebarras = '"
                            + tb_codigoDeBarras + "' WHERE produto_id = " + tb_id.Text + "";
                    cmd.ExecuteNonQuery();
                    connectionString.Close();
                    MessageBox.Show("Atualizado com sucesso");
                }
 
                atualizarGrid();
                limparCampos();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("can not open the connection");
                Console.WriteLine(ex.Message);
            }

            btn_novo.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
            btn_novo.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
            desabilitarCampos();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "sgef";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());

            try
            {
                connectionString.Open();
                //MessageBox.Show("Connection open");

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "SELECT * FROM produtos WHERE produto_ativo = 0";
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read()){
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone(); //Cria uma linha do data grid e clona
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[1].Value = reader.GetInt32(1); //QTD
                    row.Cells[2].Value = reader.GetString(2); //NOME
                    row.Cells[3].Value = reader.GetString(3); //LABORATÓRIO
                    row.Cells[4].Value = reader.GetString(4); //LOTE
                    row.Cells[5].Value = reader.GetString(5); //VALIDADE
                    row.Cells[6].Value = reader.GetInt32(6); //CÓDIGO DE BARRAS
                    dataGridView1.Rows.Add(row); //Adiciona nova linha abaixo

                }

                cmd.ExecuteNonQuery();
                connectionString.Close();
                atualizarGrid();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("can not open the connection");
                Console.WriteLine(ex.Message);
            }

        }

        private void atualizarGridPesquisar()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "sgef";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());

            try
            {
                connectionString.Open();
                //MessageBox.Show("Connection open");

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "SELECT * FROM produtos WHERE produto_nome LIKE '%" + tb_pesquisar.Text + "%' AND produto_ativo = 0";
                MySqlDataReader reader = cmd.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone(); //Cria uma linha do data grid e clona
                    row.Cells[0].Value = reader.GetInt32(0); //ID
                    row.Cells[1].Value = reader.GetInt32(1); //QTD
                    row.Cells[2].Value = reader.GetString(2); //NOME
                    row.Cells[3].Value = reader.GetString(3); //LABORATÓRIO
                    row.Cells[4].Value = reader.GetString(4); //LOTE
                    row.Cells[5].Value = reader.GetString(5); //VALIDADE
                    row.Cells[6].Value = reader.GetInt32(6); //CÓDIGO DE BARRAS
                    dataGridView1.Rows.Add(row); //Adiciona nova linha abaixo

                }

                cmd.ExecuteNonQuery();
                connectionString.Close();
                atualizarGrid();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("can not open the connection");
                Console.WriteLine(ex.Message);
            }

        }

        private void limparCampos()
        {
            tb_id.Text = "";
            tb_qtd.Text = "";
            tb_nome.Text = "";
            tb_laboratorio.Text = "";
            tb_lote.Text = "";
            tb_validade.Text = "";
            tb_codigoDeBarras.Text = "";
            tb_pesquisar.Text = "";
        }

        private void desabilitarCampos()
        {
            tb_id.Enabled = false;
            tb_qtd.Enabled = false;
            tb_nome.Enabled = false;
            tb_laboratorio.Enabled = false;
            tb_lote.Enabled = false;
            tb_validade.Enabled = false;
            tb_codigoDeBarras.Enabled = false;

        }

        private void habilitarCampos()
        {
            tb_id.Enabled = false;
            tb_qtd.Enabled = true;
            tb_nome.Enabled = true;
            tb_laboratorio.Enabled = true;
            tb_lote.Enabled = true;
            tb_validade.Enabled = true;
            tb_codigoDeBarras.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            btn_novo.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
            atualizarGrid();
            desabilitarCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_pesquisar.Enabled = true;
            habilitarCampos();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_pesquisar.Enabled = true;

            habilitarCampos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "sgef";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());


            try
            {
                connectionString.Open();
                //MessageBox.Show("Connection open");
                MySqlCommand cmd = connectionString.CreateCommand();
                
                cmd.CommandText = "UPDATE produtos SET produto_ativo = 1 WHERE produto_id = " + tb_id.Text + "";
                    cmd.ExecuteNonQuery();
                    connectionString.Close();
                    MessageBox.Show("Excluído com sucesso");

                atualizarGrid();
                limparCampos();
            }

            catch (Exception ex)
            {
                //MessageBox.Show("can not open the connection");
                Console.WriteLine(ex.Message);
            }

            btn_novo.Enabled = true;
            btn_cancelar.Enabled = false;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            atualizarGridPesquisar();
            btn_novo.Enabled = true;
            btn_cancelar.Enabled = true;
            btn_salvar.Enabled = false;
            btn_editar.Enabled = false;
            btn_excluir.Enabled = false;
            btn_pesquisar.Enabled = true;
        }
    }
}
