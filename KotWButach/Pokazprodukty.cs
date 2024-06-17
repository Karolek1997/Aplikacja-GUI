using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KotWButach
{
    public partial class Pokazprodukty : Form
    {
        private string connstring;

        public Pokazprodukty()
        {
            InitializeComponent();
            connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;

            ExecuteQuery();
        }

        private void ExecuteQuery()
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM WidokProdukty\r\nORDER BY [Cena brutto] desc", sqlcon))
                    {
                        cmd.CommandType = CommandType.Text;

                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd" + ex.Message);
            }
        }
    }
}
