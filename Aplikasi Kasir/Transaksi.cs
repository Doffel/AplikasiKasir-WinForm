using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Kasir
{
    public partial class Transaksi : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=localhost ;DATABASE=aplikasikasir ; UID=root ; PASSWORD= ;");


        public Transaksi()
        {
            InitializeComponent();

            // Atur ukuran form menjadi maksimum saat aplikasi dimulai
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size; // Set ukuran minimal sama dengan ukuran saat ini
            this.MaximumSize = new Size(int.MaxValue, int.MaxValue);
            this.Resize += Form1_Resize; // Tambahkan event handler Resize saat inisialisasi form
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void Form1_Resize(object? sender, EventArgs e)
        {
            // Periksa apakah ukuran form saat ini adalah 1280x720
            if (this.Width == 1280 && this.Height == 720)
            {
                // Set ukuran font pada label sesuai dengan kebutuhan
                label1.Font = new Font(label1.Font.FontFamily, 32, FontStyle.Bold);
                transaksi_btn.Font = new Font(transaksi_btn.Font.FontFamily, 18);
                harga_btn.Font = new Font(transaksi_btn.Font.FontFamily, 18);
                Cek_Produk_Btn.Font = new Font(transaksi_btn.Font.FontFamily, 15);
                Cek_Produk_Tx.Font = new Font(Cek_Produk_Tx.Font.FontFamily, 45);
            }
            else
            {
                // Set ukuran font kembali ke ukuran default jika tidak sesuai ukuran form 1280x720
                label1.Font = new Font(label1.Font.FontFamily, 50, FontStyle.Bold);
                transaksi_btn.Font = new Font(transaksi_btn.Font.FontFamily, 24);
                harga_btn.Font = new Font(transaksi_btn.Font.FontFamily, 24);
                Cek_Produk_Btn.Font = new Font(transaksi_btn.Font.FontFamily, 24);
                Cek_Produk_Tx.Font = new Font(Cek_Produk_Tx.Font.FontFamily, 74);
                label1.Padding = new Padding(5, 20, 0, 0);
            }
        }
        private void Transaksi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void Cek_Produk_Tx_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                if (textBox.Text.Length == 13)
                {

                    MySqlDataAdapter da = new MySqlDataAdapter("select * from dataproduk where id = " + Cek_Produk_Tx.Text, conn);

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "");
                Console.WriteLine(x);
            }

        }
        void tambahdata()
        {
            conn.Open();
            string id = Cek_Produk_Tx.Text; // Mengambil nilai ID dari TextBox

            string query = "SELECT * FROM produk WHERE id = " + id; // Membuat query SQL dengan menggunakan nilai ID

            MySqlCommand cmd = new MySqlCommand(query, conn); // Membuat MySqlCommand dengan query SQL

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string namabarang = reader.GetString("namabarang"); // Mengambil nilai kolom "nama_produk" dari reader dan menyimpannya dalam variabel
                    int hargabarang = reader.GetInt32("hargajual"); // Mengambil nilai kolom "harga_produk" dari reader dan menyimpannya dalam variabel
                    int kuantitas = 1;
                    int totalharga = hargabarang * kuantitas;
                    // Lakukan tindakan yang diperlukan dengan data yang telah diimpor ke variabel

                }
            }
            conn.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StokGudang stokgudang = new StokGudang();
            stokgudang.Show();
            this.Hide();
        }

        private void Transaksi_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void etalase_btn_Click(object sender, EventArgs e)
        {
            StokEtalase st = new StokEtalase();
            st.Show();
            this.Hide();
        }
    }
}
