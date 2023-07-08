namespace Aplikasi_Kasir
{
    partial class StokEtalase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            Cek_Produk_Tx = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            stoketalase_btn = new Button();
            stokgudang_btn = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            transaksi_btn = new Button();
            cekharga_btn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            informasi = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel6 = new TableLayoutPanel();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 102);
            label2.Name = "label2";
            label2.Size = new Size(1258, 34);
            label2.TabIndex = 4;
            label2.Text = "CARI";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Cek_Produk_Tx
            // 
            Cek_Produk_Tx.BorderStyle = BorderStyle.FixedSingle;
            Cek_Produk_Tx.Dock = DockStyle.Fill;
            Cek_Produk_Tx.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            Cek_Produk_Tx.Location = new Point(3, 3);
            Cek_Produk_Tx.Name = "Cek_Produk_Tx";
            Cek_Produk_Tx.Size = new Size(1252, 87);
            Cek_Produk_Tx.TabIndex = 1;
            Cek_Produk_Tx.TextChanged += Cek_Produk_Tx_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(Cek_Produk_Tx, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 139);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1258, 96);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // stoketalase_btn
            // 
            stoketalase_btn.BackColor = Color.RoyalBlue;
            stoketalase_btn.Dock = DockStyle.Fill;
            stoketalase_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stoketalase_btn.ForeColor = SystemColors.ButtonHighlight;
            stoketalase_btn.Location = new Point(3, 48);
            stoketalase_btn.Name = "stoketalase_btn";
            stoketalase_btn.Size = new Size(239, 39);
            stoketalase_btn.TabIndex = 2;
            stoketalase_btn.Text = "STOK ETALASE";
            stoketalase_btn.UseVisualStyleBackColor = false;
            // 
            // stokgudang_btn
            // 
            stokgudang_btn.BackColor = Color.RoyalBlue;
            stokgudang_btn.Dock = DockStyle.Fill;
            stokgudang_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stokgudang_btn.ForeColor = SystemColors.ButtonHighlight;
            stokgudang_btn.Location = new Point(3, 3);
            stokgudang_btn.Name = "stokgudang_btn";
            stokgudang_btn.Size = new Size(239, 39);
            stokgudang_btn.TabIndex = 1;
            stokgudang_btn.Text = "STOK GUDANG";
            stokgudang_btn.UseVisualStyleBackColor = false;
            stokgudang_btn.Click += stokgudang_btn_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(transaksi_btn, 2, 0);
            tableLayoutPanel2.Controls.Add(cekharga_btn, 4, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1258, 96);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 18, 0, 0);
            label1.Size = new Size(371, 96);
            label1.TabIndex = 4;
            label1.Text = "STOK ETALASE";
            // 
            // transaksi_btn
            // 
            transaksi_btn.BackColor = Color.DodgerBlue;
            transaksi_btn.Dock = DockStyle.Fill;
            transaksi_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            transaksi_btn.ForeColor = SystemColors.ButtonHighlight;
            transaksi_btn.Location = new Point(505, 3);
            transaksi_btn.Name = "transaksi_btn";
            transaksi_btn.Size = new Size(245, 90);
            transaksi_btn.TabIndex = 5;
            transaksi_btn.Text = "TRANSAKSI";
            transaksi_btn.UseVisualStyleBackColor = false;
            // 
            // cekharga_btn
            // 
            cekharga_btn.BackColor = Color.DodgerBlue;
            cekharga_btn.Dock = DockStyle.Fill;
            cekharga_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            cekharga_btn.ForeColor = SystemColors.ButtonHighlight;
            cekharga_btn.Location = new Point(1007, 3);
            cekharga_btn.Name = "cekharga_btn";
            cekharga_btn.Size = new Size(248, 90);
            cekharga_btn.TabIndex = 7;
            cekharga_btn.Text = "CEK HARGA";
            cekharga_btn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(stoketalase_btn, 0, 1);
            tableLayoutPanel4.Controls.Add(stokgudang_btn, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(756, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(245, 90);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // informasi
            // 
            informasi.AutoSize = true;
            informasi.Dock = DockStyle.Fill;
            informasi.Location = new Point(3, 238);
            informasi.Name = "informasi";
            informasi.Size = new Size(1258, 34);
            informasi.TabIndex = 3;
            informasi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(informasi, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.6979332F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.3020668F));
            tableLayoutPanel5.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 275);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(1258, 403);
            tableLayoutPanel5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 397);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "KODE BARANG";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAMA BARANG";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "STOK ETALASE";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "REKAM WAKTU";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(button1, 0, 1);
            tableLayoutPanel6.Controls.Add(dataGridView2, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(754, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 84.38287F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6171284F));
            tableLayoutPanel6.Size = new Size(501, 397);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(3, 338);
            button1.Name = "button1";
            button1.Size = new Size(495, 56);
            button1.TabIndex = 0;
            button1.Text = "AMBIL STOK";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(495, 329);
            dataGridView2.TabIndex = 1;
            // 
            // Column5
            // 
            Column5.HeaderText = "REKAM AKTIVITAS";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // StokEtalase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            Name = "StokEtalase";
            Text = "StokEtalase";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private TextBox Cek_Produk_Tx;
        private TableLayoutPanel tableLayoutPanel3;
        private Button stoketalase_btn;
        private Button stokgudang_btn;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Button transaksi_btn;
        private Button cekharga_btn;
        private TableLayoutPanel tableLayoutPanel4;
        private Label informasi;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column5;
    }
}