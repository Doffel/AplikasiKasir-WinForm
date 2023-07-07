namespace Aplikasi_Kasir
{
    partial class Transaksi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            transaksi_btn = new Button();
            harga_btn = new Button();
            label1 = new Label();
            tableLayoutPanel13 = new TableLayoutPanel();
            gudang_btn = new Button();
            etalase_btn = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            Cek_Produk_Tx = new TextBox();
            Cek_Produk_Btn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanel5 = new TableLayoutPanel();
            ubah_btn = new Button();
            batal_btn = new Button();
            hapus_btn = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            button8 = new Button();
            button9 = new Button();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            panel2 = new Panel();
            label4 = new Label();
            tableLayoutPanel12 = new TableLayoutPanel();
            textBox2 = new TextBox();
            label3 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            tableLayoutPanel1.Size = new Size(1264, 681);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(transaksi_btn, 2, 0);
            tableLayoutPanel2.Controls.Add(harga_btn, 4, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel13, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1258, 96);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // transaksi_btn
            // 
            transaksi_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transaksi_btn.BackColor = Color.DodgerBlue;
            transaksi_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            transaksi_btn.ForeColor = SystemColors.ButtonHighlight;
            transaksi_btn.Location = new Point(505, 3);
            transaksi_btn.Name = "transaksi_btn";
            transaksi_btn.Size = new Size(245, 90);
            transaksi_btn.TabIndex = 0;
            transaksi_btn.Text = "TRANSAKSI";
            transaksi_btn.UseVisualStyleBackColor = false;
            transaksi_btn.Click += Transaksi_Click;
            // 
            // harga_btn
            // 
            harga_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            harga_btn.BackColor = Color.DodgerBlue;
            harga_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            harga_btn.ForeColor = SystemColors.ButtonHighlight;
            harga_btn.Location = new Point(1007, 3);
            harga_btn.Name = "harga_btn";
            harga_btn.Size = new Size(248, 90);
            harga_btn.TabIndex = 2;
            harga_btn.Text = "CEK HARGA";
            harga_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 18, 0, 0);
            label1.Size = new Size(371, 96);
            label1.TabIndex = 3;
            label1.Text = "TRANSAKSI";
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Controls.Add(gudang_btn, 0, 0);
            tableLayoutPanel13.Controls.Add(etalase_btn, 0, 1);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(756, 3);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 2;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel13.Size = new Size(245, 90);
            tableLayoutPanel13.TabIndex = 4;
            // 
            // gudang_btn
            // 
            gudang_btn.BackColor = Color.RoyalBlue;
            gudang_btn.Dock = DockStyle.Fill;
            gudang_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gudang_btn.ForeColor = SystemColors.ButtonHighlight;
            gudang_btn.Location = new Point(3, 3);
            gudang_btn.Name = "gudang_btn";
            gudang_btn.Size = new Size(239, 39);
            gudang_btn.TabIndex = 0;
            gudang_btn.Text = "STOK GUDANG";
            gudang_btn.UseVisualStyleBackColor = false;
            gudang_btn.Click += button2_Click;
            // 
            // etalase_btn
            // 
            etalase_btn.BackColor = Color.RoyalBlue;
            etalase_btn.Dock = DockStyle.Fill;
            etalase_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            etalase_btn.ForeColor = SystemColors.ButtonHighlight;
            etalase_btn.Location = new Point(3, 48);
            etalase_btn.Name = "etalase_btn";
            etalase_btn.Size = new Size(239, 39);
            etalase_btn.TabIndex = 1;
            etalase_btn.Text = "STOK ETALASE";
            etalase_btn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.Controls.Add(Cek_Produk_Tx, 0, 0);
            tableLayoutPanel3.Controls.Add(Cek_Produk_Btn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 139);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1258, 96);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // Cek_Produk_Tx
            // 
            Cek_Produk_Tx.BorderStyle = BorderStyle.FixedSingle;
            Cek_Produk_Tx.Dock = DockStyle.Fill;
            Cek_Produk_Tx.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            Cek_Produk_Tx.Location = new Point(3, 3);
            Cek_Produk_Tx.Name = "Cek_Produk_Tx";
            Cek_Produk_Tx.Size = new Size(1126, 87);
            Cek_Produk_Tx.TabIndex = 0;
            Cek_Produk_Tx.TextChanged += Cek_Produk_Tx_TextChanged;
            // 
            // Cek_Produk_Btn
            // 
            Cek_Produk_Btn.BackColor = Color.SteelBlue;
            Cek_Produk_Btn.Dock = DockStyle.Fill;
            Cek_Produk_Btn.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Cek_Produk_Btn.ForeColor = SystemColors.ButtonHighlight;
            Cek_Produk_Btn.Location = new Point(1135, 3);
            Cek_Produk_Btn.Name = "Cek_Produk_Btn";
            Cek_Produk_Btn.Size = new Size(120, 90);
            Cek_Produk_Btn.TabIndex = 1;
            Cek_Produk_Btn.Text = "TAMBAH";
            Cek_Produk_Btn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.6979332F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.3020668F));
            tableLayoutPanel4.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel7, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 241);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 83.9817F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0183067F));
            tableLayoutPanel4.Size = new Size(1258, 437);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(745, 361);
            dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel5.Controls.Add(ubah_btn, 1, 0);
            tableLayoutPanel5.Controls.Add(batal_btn, 2, 0);
            tableLayoutPanel5.Controls.Add(hapus_btn, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 370);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(745, 64);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // ubah_btn
            // 
            ubah_btn.BackColor = Color.DeepSkyBlue;
            ubah_btn.Dock = DockStyle.Fill;
            ubah_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ubah_btn.ForeColor = SystemColors.ButtonHighlight;
            ubah_btn.Location = new Point(251, 3);
            ubah_btn.Name = "ubah_btn";
            ubah_btn.Size = new Size(242, 58);
            ubah_btn.TabIndex = 1;
            ubah_btn.Text = "UBAH";
            ubah_btn.UseVisualStyleBackColor = false;
            // 
            // batal_btn
            // 
            batal_btn.BackColor = Color.DarkOrange;
            batal_btn.Dock = DockStyle.Fill;
            batal_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            batal_btn.Location = new Point(499, 3);
            batal_btn.Name = "batal_btn";
            batal_btn.Size = new Size(243, 58);
            batal_btn.TabIndex = 2;
            batal_btn.Text = "BATAL";
            batal_btn.UseVisualStyleBackColor = false;
            // 
            // hapus_btn
            // 
            hapus_btn.BackColor = Color.DarkRed;
            hapus_btn.Dock = DockStyle.Fill;
            hapus_btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            hapus_btn.ForeColor = SystemColors.ButtonHighlight;
            hapus_btn.Location = new Point(3, 3);
            hapus_btn.Name = "hapus_btn";
            hapus_btn.Size = new Size(242, 58);
            hapus_btn.TabIndex = 0;
            hapus_btn.Text = "HAPUS";
            hapus_btn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.333333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.6666679F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.33F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.67F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4F));
            tableLayoutPanel6.Controls.Add(button8, 1, 0);
            tableLayoutPanel6.Controls.Add(button9, 3, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(754, 370);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(501, 64);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.DimGray;
            button8.Dock = DockStyle.Fill;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(44, 3);
            button8.Name = "button8";
            button8.Size = new Size(202, 58);
            button8.TabIndex = 0;
            button8.Text = "RIWAYAT";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.ForestGreen;
            button9.Dock = DockStyle.Fill;
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(273, 3);
            button9.Name = "button9";
            button9.Size = new Size(202, 58);
            button9.TabIndex = 1;
            button9.Text = "SELESAI";
            button9.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel10, 0, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel12, 0, 2);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(754, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 5;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4117641F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tableLayoutPanel7.Size = new Size(501, 361);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(panel1, 0, 1);
            tableLayoutPanel8.Controls.Add(label2, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 24);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel8.Size = new Size(495, 100);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 69);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(489, 25);
            label2.TabIndex = 1;
            label2.Text = "TOTAL";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(panel2, 0, 1);
            tableLayoutPanel10.Controls.Add(label4, 0, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(3, 236);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel10.Size = new Size(495, 100);
            tableLayoutPanel10.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(489, 69);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(489, 25);
            label4.TabIndex = 1;
            label4.Text = "KEMBALIAN";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(textBox2, 0, 1);
            tableLayoutPanel12.Controls.Add(label3, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 130);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tableLayoutPanel12.Size = new Size(495, 100);
            tableLayoutPanel12.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 28);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(489, 71);
            textBox2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(489, 25);
            label3.TabIndex = 1;
            label3.Text = "BAYAR";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(0, 0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel9.Size = new Size(200, 100);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.Size = new Size(200, 100);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(tableLayoutPanel1);
            Name = "Transaksi";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            FormClosing += Transaksi_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button transaksi_btn;
        private Button harga_btn;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox Cek_Produk_Tx;
        private Button Cek_Produk_Btn;
        private TableLayoutPanel tableLayoutPanel4;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button ubah_btn;
        private Button batal_btn;
        private Button hapus_btn;
        private TableLayoutPanel tableLayoutPanel6;
        private Button button8;
        private Button button9;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel11;
        private Panel panel2;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel13;
        private Button gudang_btn;
        private Button etalase_btn;
    }
}