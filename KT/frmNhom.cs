using KT.Model;
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
    public partial class frmNhom : Form
    {
        public frmNhom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var n = new TenNhom
            {
                TenNhom1 = txtNhom.Text,
            };
            if (TenNhomService.AddNhom(n) == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Mã sinh viên trùng", "Thông báo");
                txtNhom.Focus();
            }
        }
    }
}
