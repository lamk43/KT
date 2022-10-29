using KT.Services;
using KT.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT

{
    public partial class LienLac : Form
    {
        public LienLac()
        {
            InitializeComponent();
        }

        private void LienLac_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public TenNhomViewModel selectedNhom
        {
            get
            {
                return cbbNhom.SelectedItem as TenNhomViewModel;
            }
        }

        public string HoTen { get; private set; }
        public string DiaChi { get; private set; }
        public string Email { get; private set; }
        public string MaSinhVien { get; private set; }
        public int IDNhom { get; private set; }
        public string SoDienThoai { get; private set; }

        void NapDSNhom()
        {
            var ls = TenNhomViewModel.GetList();
            cbbNhom.DataSource = ls;
            cbbNhom.DisplayMember = "TenNhom";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var LienLac = new LienLac
            {
                HoTen = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                Email = txtEmail.Text,
                MaSinhVien = txtMSV.Text,
                IDNhom = selectedNhom.ID,
                SoDienThoai = txtSoDienThoai.Text,
            };
            if (TenGoiService.LienLac() == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                txtMSV.Focus();
            }
            
        }
    }
}
