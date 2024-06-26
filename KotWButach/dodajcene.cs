﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KotWButach
{
    public partial class dodajcene : Form
    {
        private string connstring;

        public dodajcene()
        {
            InitializeComponent();
            connstring = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            PopulateCategoryCombo();
            PopulateModelCombo();
        }

        private void save_button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(connstring))
                {
                    sqlcon.Open();
                    using (SqlCommand cmd = new SqlCommand("DodajCene", sqlcon))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@KategoriaProduktuID", Convert.ToInt32(Wybor_Kategorii1.SelectedValue));
                        cmd.Parameters.AddWithValue("@NazwaModelu", Wybor_Modelu.Text);
                        cmd.Parameters.AddWithValue("@CenaNetto", Convert.ToDecimal(cenanetto_textbox.Text));

                        SqlParameter returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        cmd.ExecuteNonQuery();

                        int returnValue = (int)returnParameter.Value;

                        if (returnValue == 1)
                        {
                            MessageBox.Show("Cena została dodana.");
                        }
                        else if (returnValue == 2)
                        {
                            MessageBox.Show("Nie znaleziono modelu o podanej kategorii i nazwie modelu.");
                        }
                        else if (returnValue == 0)
                        {
                            MessageBox.Show("Nie znaleziono produktu o podanej kategorii i nazwie modelu.");
                        }
                        else
                        {
                            MessageBox.Show("Wystąpił błąd");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void PopulateCategoryCombo()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand("WybierzKategorieProduktu", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                }
                Wybor_Kategorii1.DataSource = dt;
                Wybor_Kategorii1.DisplayMember = "NazwaKategorii";
                Wybor_Kategorii1.ValueMember = "KategoriaProduktuID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void PopulateModelCombo()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand("WybierzModelProduktu", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        dt.Load(reader);
                    }
                }
                Wybor_Modelu.DataSource = dt;
                Wybor_Modelu.DisplayMember = "NazwaModelu";
                Wybor_Modelu.ValueMember = "ModelID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private void dodajcene_Load(object sender, EventArgs e)
        {
            // Możesz dodać kod inicjalizacji tutaj, jeśli jest taka potrzeba
        }

        private void Wybor_Kategorii1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Możesz dodać kod obsługi zmiany wyboru kategorii tutaj, jeśli jest taka potrzeba
        }

        private void close_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sprawdzprodukty_button_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = GetDataFromsprawdzcenyProcedure();
                sprawdzceny formSprawdzceny = new sprawdzceny();
                formSprawdzceny.produktybezcenGrid.DataSource = dataTable;
                formSprawdzceny.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }
        }

        private DataTable GetDataFromsprawdzcenyProcedure()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection con = new SqlConnection(connstring))
                {
                    using (SqlCommand cmd = new SqlCommand("sprawdzceny", con))
                    {
                        con.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader reader = cmd.ExecuteReader();
                        dataTable.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex.Message);
            }

            return dataTable;
        }
    }
}
