using System;
using System.Drawing;
using System.Text.Encodings.Web;
using static System.Net.Mime.MediaTypeNames;

namespace DUANMAUTEST
{
    public partial class Form1 : Form
    {
        
        Services1 sv = new Services1();
        public Form1()
        {
            InitializeComponent();
        }

        public void LoadData(List<CuaHang> list)
        {
            int stt = 1;
            dtgv.Rows.Clear();
            dtgv.ColumnCount = 5;
            dtgv.Columns[0].HeaderText = "Số thứ tự";
            dtgv.Columns[1].HeaderText = "Tên";
            dtgv.Columns[2].HeaderText = "Mô tả";
            dtgv.Columns[3].HeaderText = "Loại hàng";
            dtgv.Columns[4].HeaderText = "Ngày đăng kí";
            foreach(CuaHang hang in list)
            {
                dtgv.Rows.Add(stt++, hang.TEN, hang.MOTA, hang.LOAIHANG, hang.NGAYDANGKY);
            }
            dtgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void butHienThi_Click(object sender, EventArgs e)
        {
            List<CuaHang> ch = sv.GetAll();
            LoadData(ch);
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            string ten = texTen14.Text;
            string mota = texMo14.Text;
            string loaihang = texLoai14.Text;
            int ngaydangky = Convert.ToInt32(texNgay14.Text);
            sv.Them(ten,mota,loaihang,ngaydangky);
            LoadData(sv.GetAll());
        }

        private void butSua_Click(object sender, EventArgs e)
        {
            string ten = texTen14.Text;
            string mota = texMo14.Text;
            string loaihang = texLoai14.Text;
            int ngaydangky = Convert.ToInt32(texNgay14.Text);
            sv.Sua(ten,mota,loaihang,ngaydangky);
            LoadData(sv.GetAll());
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            sv.Xoa(texTen14.Text);
            LoadData(sv.GetAll());
        }

        private void butClear_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];
                texTen14.Text = row.Cells[1].Value.ToString();
                texMo14.Text = row.Cells[2].Value.ToString();
                texLoai14.Text = row.Cells[3].Value.ToString();
                texNgay14.Text = row.Cells[4].Value.ToString();
            }
        }

        private void texTim_TextChanged(object sender, EventArgs e)
        {
            var data = sv.SearchByName(texTim.Text);
            LoadData(data);
        }
    }
}
