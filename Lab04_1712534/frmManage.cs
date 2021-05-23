using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_1712534
{
    public partial class frmManage : Form
    {
        NhanVienController nvController = new NhanVienController();
        public frmManage()
        {
            InitializeComponent();
        }

        private bool createDto(NhanVien nv)
        {
            bool valid = true;
            if (nv.MaNV == "") valid = false;
            if (nv.Email == "") valid = false;
            if (nv.TenDN == "") valid = false;
            if (nv.HoTen == "") valid = false;
            if (nv.Luong <0) valid = false;
            if (nv.MatKhau == "") valid = false;
            return valid; 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = textBoxMaNV.Text;
            nv.Email = textBoxEmail.Text;
            nv.TenDN = textBoxTenDN.Text;
            nv.HoTen = textBoxHoTen.Text;
            nv.Luong = float.Parse(textBoxLuong.Text, CultureInfo.InvariantCulture);
            nv.MatKhau = textBoxMatKhau.Text;
            if(createDto(nv))
            {
                nvController.insert();
            } else MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại.", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void textBoxLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
            if (e.Handled)
            {
                MessageBox.Show("Vui lòng nhập số", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMaNV.Text = "";
            textBoxEmail.Text = "";
            textBoxTenDN.Text = "";
            textBoxHoTen.Text = "";
            textBoxLuong.Text = "";
            textBoxMatKhau.Text = "";
        }
    }
}
