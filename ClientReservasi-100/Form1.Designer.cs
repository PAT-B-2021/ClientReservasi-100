
using System;

namespace ClientReservasi_100
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TB_IDlokasi = new System.Windows.Forms.TextBox();
            this.TB_jmlPesanan = new System.Windows.Forms.TextBox();
            this.TB_notlp = new System.Windows.Forms.TextBox();
            this.TB_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_IDreservasi = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.data_pemesanan = new System.Windows.Forms.DataGridView();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemesananBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_pemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.6F));
            this.tableLayoutPanel1.Controls.Add(this.TB_IDlokasi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TB_jmlPesanan, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TB_notlp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TB_nama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TB_IDreservasi, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 197);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // TB_IDlokasi
            // 
            this.TB_IDlokasi.Location = new System.Drawing.Point(165, 159);
            this.TB_IDlokasi.Name = "TB_IDlokasi";
            this.TB_IDlokasi.Size = new System.Drawing.Size(332, 22);
            this.TB_IDlokasi.TabIndex = 9;
            // 
            // TB_jmlPesanan
            // 
            this.TB_jmlPesanan.Location = new System.Drawing.Point(165, 120);
            this.TB_jmlPesanan.Name = "TB_jmlPesanan";
            this.TB_jmlPesanan.Size = new System.Drawing.Size(332, 22);
            this.TB_jmlPesanan.TabIndex = 8;
            // 
            // TB_notlp
            // 
            this.TB_notlp.Location = new System.Drawing.Point(165, 81);
            this.TB_notlp.Name = "TB_notlp";
            this.TB_notlp.Size = new System.Drawing.Size(332, 22);
            this.TB_notlp.TabIndex = 7;
            // 
            // TB_nama
            // 
            this.TB_nama.Location = new System.Drawing.Point(165, 42);
            this.TB_nama.Name = "TB_nama";
            this.TB_nama.Size = new System.Drawing.Size(332, 22);
            this.TB_nama.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID reservasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Telpon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Lokasi";
            // 
            // TB_IDreservasi
            // 
            this.TB_IDreservasi.Location = new System.Drawing.Point(165, 3);
            this.TB_IDreservasi.Name = "TB_IDreservasi";
            this.TB_IDreservasi.Size = new System.Drawing.Size(332, 22);
            this.TB_IDreservasi.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_update, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_delete, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_clear, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(518, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(247, 197);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(241, 43);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(3, 52);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(241, 42);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(3, 101);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(241, 41);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(3, 150);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(241, 44);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // data_pemesanan
            // 
            this.data_pemesanan.AutoGenerateColumns = false;
            this.data_pemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_pemesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPemesananDataGridViewTextBoxColumn,
            this.namaCustomerDataGridViewTextBoxColumn,
            this.noTelponDataGridViewTextBoxColumn,
            this.jumlahPemesananDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn});
            this.data_pemesanan.DataSource = this.pemesananBindingSource1;
            this.data_pemesanan.Location = new System.Drawing.Point(12, 215);
            this.data_pemesanan.Name = "data_pemesanan";
            this.data_pemesanan.RowHeadersWidth = 51;
            this.data_pemesanan.RowTemplate.Height = 24;
            this.data_pemesanan.Size = new System.Drawing.Size(753, 223);
            this.data_pemesanan.TabIndex = 2;
            this.data_pemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_pemesanan_CellClick);
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataSource = typeof(ServiceReservasi.Pemesanan);
            // 
            // pemesananResponseBindingSource
            // 
            this.pemesananResponseBindingSource.DataSource = typeof(ClientReservasi_044.ServiceReference1.PemesananResponse);
            // 
            // pemesananBindingSource1
            // 
            this.pemesananBindingSource1.DataSource = typeof(ServiceReservasi.Pemesanan);
            // 
            // iDPemesananDataGridViewTextBoxColumn
            // 
            this.iDPemesananDataGridViewTextBoxColumn.DataPropertyName = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.HeaderText = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPemesananDataGridViewTextBoxColumn.Name = "iDPemesananDataGridViewTextBoxColumn";
            this.iDPemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaCustomerDataGridViewTextBoxColumn
            // 
            this.namaCustomerDataGridViewTextBoxColumn.DataPropertyName = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.HeaderText = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaCustomerDataGridViewTextBoxColumn.Name = "namaCustomerDataGridViewTextBoxColumn";
            this.namaCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelponDataGridViewTextBoxColumn
            // 
            this.noTelponDataGridViewTextBoxColumn.DataPropertyName = "NoTelpon";
            this.noTelponDataGridViewTextBoxColumn.HeaderText = "NoTelpon";
            this.noTelponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelponDataGridViewTextBoxColumn.Name = "noTelponDataGridViewTextBoxColumn";
            this.noTelponDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahPemesananDataGridViewTextBoxColumn
            // 
            this.jumlahPemesananDataGridViewTextBoxColumn.DataPropertyName = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.HeaderText = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahPemesananDataGridViewTextBoxColumn.Name = "jumlahPemesananDataGridViewTextBoxColumn";
            this.jumlahPemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            this.lokasiDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.data_pemesanan);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_pemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TB_IDlokasi;
        private System.Windows.Forms.TextBox TB_jmlPesanan;
        private System.Windows.Forms.TextBox TB_notlp;
        private System.Windows.Forms.TextBox TB_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_IDreservasi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView data_pemesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pemesananBindingSource1;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private System.Windows.Forms.BindingSource pemesananResponseBindingSource;
    }
}

