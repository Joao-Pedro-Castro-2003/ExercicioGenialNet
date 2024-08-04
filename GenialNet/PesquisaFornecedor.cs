using GenialNet.DbConnection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenialNet
{
    public partial class PesquisaFornecedor : Form
    {
        public PesquisaFornecedor()
        {
            InitializeComponent();
        }
        private void PesquisaFornecedor_Load(object sender, EventArgs e)
        {
            CarregarFornecedores();
        }
        private void CarregarFornecedores()
        {
            string connectionString = DatabaseConfig.GetConnectionString();
            string query = "SELECT * FROM Fornecedores";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable fornecedores = new DataTable();
                    adapter.Fill(fornecedores);
                    dataGridViewFornecedores.DataSource = fornecedores;
                }
            }
        }
        private void dataGridViewFornecedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada não seja o cabeçalho
            {
                DataGridViewRow row = dataGridViewFornecedores.Rows[e.RowIndex];

                int id = Convert.ToInt32(row.Cells["fornecedor_id"].Value);
                string nome = row.Cells["nome"].Value.ToString();

                this.Hide();
                CadastroProduto cadastroProduto = new CadastroProduto(id, nome);
                cadastroProduto.ShowDialog();
                this.Show();
            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
