using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Kasir
{
    public partial class StokEtalase : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=aplikasikasir;UID=root;PASSWORD= ;");
        public StokEtalase()
        {
            InitializeComponent();
        }

        private void Cek_Produk_Tx_TextChanged(object sender, EventArgs e)
        {
            TextBox masukan = (TextBox)sender;
            try
            {
                if (long.TryParse(masukan.Text, out long nilai))
                {
                    if (masukan.Text.Length > 0 && masukan.Text.Length < 13)
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM stoketalase WHERE id LIKE '" + Cek_Produk_Tx.Text + "%'", conn);

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            informasi.Text = "Data tidak ditemukan";
                        }
                        else
                        {
                            dataGridView1.DataSource = ds.Tables[0];
                            informasi.Text = "";
                        }
                    }
                }
                else if (masukan.Text.Length == 13)
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM stoketalase WHERE id LIKE '" + Cek_Produk_Tx.Text + "%'", conn);

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        informasi.Text = "Data tidak ditemukan";
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        informasi.Text = "";
                    }
                    masukan.Text = "";
                }
                else if (Regex.IsMatch(masukan.Text, "^[A-Za-z]"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM stoketalase WHERE id LIKE '" + Cek_Produk_Tx.Text + "%'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        informasi.Text = "Data tidak ditemukan";
                    }
                    else
                    {
                        dataGridView1.DataSource = ds.Tables[0];
                        informasi.Text = "";
                    }
                }
                else
                {
                    masukan.Text = "";
                }
            }
            catch
            {

            }
        }
    }
}
