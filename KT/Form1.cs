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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSTenNhom();
            NapDSTenGoi();
        }

        public TenNhomViewModel selectedTenNhom
        {
            get
            {
                return tenNhomViewModelBindingSource.Current as TenNhomViewModel;
            }
        }
        public TenGoiViewModel selectedTenGoi
        {
            get
            {
                return tenGoiViewModelBindingSource.Current as TenGoiViewModel;
            }
        }

        void NapDSTenNhom()
        {
            var ls = TenNhomViewModel.GetList();
            tenNhomViewModelBindingSource.DataSource = ls;
            dataGridView1.DataSource = tenNhomViewModelBindingSource;
        }

        void NapDSTenGoi()
        {
            if (selectedTenNhom != null)
            {
                var ls = TenGoiService.GetList(selectedTenNhom.ID);
                tenGoiViewModelBindingSource.DataSource = ls;
                dataGridView2.DataSource = tenGoiViewModelBindingSource;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDSTenGoi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var a = new frmNhom();
            var rs = a.ShowDialog();
            if (rs == DialogResult.OK)
            {
                NapDSTenNhom();
            }
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (selectedTenNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    TenNhomService.RemoveNhom(selectedTenNhom);
                    NapDSTenNhom();
                }
            }
        }
    }
}
