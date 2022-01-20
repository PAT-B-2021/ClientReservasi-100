using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_100
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        private object btn_update;
        private object btn_delete;
        private object data_pemesanan;
        private object btn_save;

        public object TB_IDreservasi { get; private set; }
        public object TB_nama { get; private set; }
        public object TB_notlp { get; private set; }
        public object TB_jmlPesanan { get; private set; }
        public object TB_IDlokasi { get; private set; }

        public Form1()
        {
            InitializeComponent();

            TampilData();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TB_IDreservasi.Text;
            string NamaCustomer = TB_nama.Text;
            string NoTelpon = TB_notlp.Text;
            int JumlahPemesanan = int.Parse(TB_jmlPesanan.Text);
            string IDlokasi = TB_IDlokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDlokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TB_IDreservasi.Text;
            string NamaCustomer = TB_nama.Text;
            string NoTelpon = TB_notlp.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string IDPemesanan = TB_IDreservasi.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }
        public void TampilData()
        {
            var List = service.Pemesanan1();
            data_pemesanan.DataSource = List;
        }
        public void Clear()
        {
            TB_IDreservasi.Clear();
            TB_nama.Clear();
            TB_notlp.Clear();
            TB_jmlPesanan.Clear();
            TB_IDlokasi.Clear();

            TB_jmlPesanan.Enabled = true;
            TB_IDlokasi.Enabled = true;

            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            TB_IDreservasi.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void data_pemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TB_IDreservasi.Text = Convert.ToString(data_pemesanan.Rows[e.RowIndex].Cells[0].Value);
            TB_nama.Text = Convert.ToString(data_pemesanan.Rows[e.RowIndex].Cells[1].Value);
            TB_notlp.Text = Convert.ToString(data_pemesanan.Rows[e.RowIndex].Cells[2].Value);
            TB_jmlPesanan.Text = Convert.ToString(data_pemesanan.Rows[e.RowIndex].Cells[3].Value);
            TB_IDlokasi.Text = Convert.ToString(data_pemesanan.Rows[e.RowIndex].Cells[4].Value);

            TB_jmlPesanan.Enabled = false;
            TB_IDlokasi.Enabled = false;

            btn_update.Enabled = true;
            btn_delete.Enabled = true;

            btn_save.Enabled = false;
            TB_IDreservasi.Enabled = false;
        }
    }
}
