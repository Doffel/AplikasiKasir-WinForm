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
        string iddata = "";
        int kuantitas = 0;
        long harga = 0;
        MySqlConnection conn = new MySqlConnection("SERVER=localhost ;DATABASE=aplikasikasir ; UID=root ; PASSWORD= ;");
        public StokGudang()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            informasi.Text = "";
            tabelutama();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Transaksi transaksi = new Transaksi();
            transaksi.Show();
            this.Hide();
        }

        private void StokGudang_Resize(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, this.Width / 40, FontStyle.Bold);
            label2.Font = new Font(label2.Font.FontFamily, this.Width / 71, FontStyle.Bold);
            label3.Font = new Font(label3.Font.FontFamily, this.Width / 53, FontStyle.Bold);
            label4.Font = new Font(label4.Font.FontFamily, this.Width / 71, FontStyle.Bold);
            label5.Font = new Font(label5.Font.FontFamily, this.Width / 80, FontStyle.Bold);
            label6.Font = new Font(label6.Font.FontFamily, this.Width / 80, FontStyle.Bold);
            Status_lbl.Font = new Font(label6.Font.FontFamily, this.Width / 142, FontStyle.Bold);
            transaksi_btn.Font = new Font(transaksi_btn.Font.FontFamily, this.Width / 71, FontStyle.Bold);
            cekharga_btn.Font = new Font(transaksi_btn.Font.FontFamily, this.Width / 71, FontStyle.Bold);
            stokgudang_btn.Font = new Font(transaksi_btn.Font.FontFamily, this.Width / 106, FontStyle.Bold);
            stoketalase_btn.Font = new Font(transaksi_btn.Font.FontFamily, this.Width / 106, FontStyle.Bold);
            Cek_Produk_Tx.Font = new Font(Cek_Produk_Tx.Font.FontFamily, this.Width / 28, FontStyle.Bold);
            label1.Padding = new Padding(5, 20, 0, 0);
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
                            iddata = dr["id"].ToString();
                            harga = Int64.Parse(dr["hargabarang"].ToString());
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
            dataGridView1.CurrentCell = null;
            Cek_Produk_Tx.Focus();
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
                    iddata = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    namabarang_lbl.Text = data;
                    namadata = data;
                    harga = Int64.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                }
                else if (targetbarang == true)
                {
                    string data = namadata;
                    namabarang_lbl.Text = data;
                    targetbarang = false;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
            }

        }

        private void tambaheta_btn_Click(object sender, EventArgs e)
        {
            try
            {
                kuantitas = (int)numericUpDown1.Value;
                MySqlDataAdapter da = new MySqlDataAdapter("select * from stoketalase where id = '" + iddata + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                conn.Open();
                if (ds.Tables[0].Rows.Count == 0)
                {
                    string query = "INSERT INTO stoketalase (id, namabarang, hargabarang , stoketalase, rekamwaktu) VALUES (@iddata, @namadata, @harga, @kuantitas, CURDATE());";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@iddata", iddata);
                        cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                        cmd.Parameters.AddWithValue("@namadata", namadata);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produk Ditambahkan Ke ETALASE");
                    }
                }
                else
                {
                    string query = "UPDATE stoketalase SET namabarang = @namadata, hargabarang = @harga ,stoketalase = stoketalase + @kuantitas, rekamwaktu = CURDATE() where id = @iddata";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@iddata", iddata);
                        cmd.Parameters.AddWithValue("@kuantitas", kuantitas);
                        cmd.Parameters.AddWithValue("@namadata", namadata);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Stok Produk Etalase Berhasil Diperbaharui");
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
                tabelutama();
                numericUpDown1.Value = 0;
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            tabelutama();
            Cek_Produk_Tx.Text = string.Empty;
            informasi.Text = string.Empty;
            namabarang_lbl.Text = string.Empty;

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stoketalase_btn_Click(object sender, EventArgs e)
        {
            StokEtalase se = new StokEtalase();
            se.Show();
            this.Hide();
        }

        private void stokgudang_btn_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
