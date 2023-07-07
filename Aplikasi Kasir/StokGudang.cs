using MySql.Data.MySqlClient;
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

namespace Aplikasi_Kasir
{
    public partial class StokGudang : Form
    {
        bool targetbarang = false;
        string namadata = "";
        MySqlConnection conn = new MySqlConnection("SERVER=localhost ;DATABASE=aplikasikasir ; UID=root ; PASSWORD= ;");
        public StokGudang()
        {
            InitializeComponent();

            // Atur ukuran form menjadi maksimum saat aplikasi dimulai
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size; // Set ukuran minimal sama dengan ukuran saat ini
            this.MaximumSize = new Size(int.MaxValue, int.MaxValue);
            this.Resize += Form2_Resize; // Tambahkan event handler Resize saat inisialisasi form
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            informasi.Text = "";
            tabelutama();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            this.Hide();
            transaksi.Show();


        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (this.Width == 1280 && this.Height == 720)
            {
                // Set ukuran font pada label sesuai dengan kebutuhan
                label1.Font = new Font(label1.Font.FontFamily, 32, FontStyle.Bold);
                transaksi_btn.Font = new Font(transaksi_btn.Font.FontFamily, 18);
                cekharga_btn.Font = new Font(transaksi_btn.Font.FontFamily, 18);
                Cek_Produk_Tx.Font = new Font(Cek_Produk_Tx.Font.FontFamily, 45);
            }
            else
            {
                // Set ukuran font kembali ke ukuran default jika tidak sesuai ukuran form 1280x720
                label1.Font = new Font(label1.Font.FontFamily, 50, FontStyle.Bold);
                transaksi_btn.Font = new Font(transaksi_btn.Font.FontFamily, 24);
                cekharga_btn.Font = new Font(transaksi_btn.Font.FontFamily, 24);
                Cek_Produk_Tx.Font = new Font(Cek_Produk_Tx.Font.FontFamily, 74);
                label1.Padding = new Padding(5, 20, 0, 0);
            }
        }

        private void Cek_Produk_Tx_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (long.TryParse(textBox.Text, out long value))
                {
                    if (textBox.Text.Length > 0 && textBox.Text.Length < 13)
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter("select * from stokgudang where id LIKE '" + Cek_Produk_Tx.Text + "%'", conn);

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            // Tidak ada data yang ditemukan
                            informasi.Text = "Data tidak ditemukan";
                        }
                        else
                        {
                            // Data ditemukan, tampilkan dalam DataGridView
                            dataGridView1.DataSource = ds.Tables[0];
                            informasi.Text = "";
                        }
                    }
                    else if (textBox.Text.Length == 13)
                    {

                        MySqlDataAdapter da = new MySqlDataAdapter("select * from stokgudang where id = " + Cek_Produk_Tx.Text, conn);

                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            // Tidak ada data yang ditemukan
                            informasi.Text = "Data tidak ditemukan";
                            targetbarang = false;
                        }
                        else
                        {
                            // Data ditemukan, tampilkan dalam DataGridView
                            dataGridView1.DataSource = ds.Tables[0];
                            informasi.Text = "";
                            targetbarang = true;
                            DataRow dr = ds.Tables[0].Rows[0];
                            namadata = dr["namabarang"].ToString();
                        }
                        textBox.Text = "";
                    }
                }
                else if (Regex.IsMatch(textBox.Text, "^[A-Za-z]"))
                {
                    MySqlDataAdapter da = new MySqlDataAdapter("select * from stokgudang where namabarang LIKE '%" + Cek_Produk_Tx.Text + "%'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        // Tidak ada data yang ditemukan
                        informasi.Text = "Data tidak ditemukan";
                    }
                    else
                    {
                        // Data ditemukan, tampilkan dalam DataGridView
                        dataGridView1.DataSource = ds.Tables[0];
                        informasi.Text = "";
                    }

                }
                else
                {
                    textBox.Text = "";
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
                Console.WriteLine(x);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        void tabelutama()
        {
            MySqlDataAdapter da = new MySqlDataAdapter("select * from stokgudang", conn);

            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void StokGudang_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            Cek_Produk_Tx.Focus();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    string data = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    namabarang_lbl.Text = data;
                }
                else if (targetbarang == true)
                {
                    string data = namadata;
                    namabarang_lbl.Text = data;
                    targetbarang = false;
                    namadata = "";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }


    }
}
