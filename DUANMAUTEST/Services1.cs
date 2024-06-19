using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace DUANMAUTEST
{
    internal class Services1
    {

        string connectionString;
        public Services1()
        {
            connectionString = @"Data Source=DUONGNHATMINH;Initial Catalog=SOF205_final149;Integrated Security=True;";
        }

        public List<CuaHang> GetAll()
        {
            List<CuaHang> list = new List<CuaHang>();
            SqlConnection con = new SqlConnection(connectionString);
            DataTable data = new DataTable();
            try
            {
                con.Open();
                string query = "Select * from CuaHang";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(data);
            }
            catch { }
            finally { con.Close(); }
            foreach (DataRow row in data.Rows)
            {
                CuaHang ch = new CuaHang
                {
                    TEN = row["Ten"].ToString(),
                    MOTA = row["Mota"].ToString(),
                    LOAIHANG = row["LoaiHang"].ToString(),
                    NGAYDANGKY = Convert.ToInt32(row["Ngaydangky"]),
                }; list.Add(ch);
            }
            return list;
        }

        public void Them(string ten, string mota, string loaihang, int ngaydangki)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"Insert into CuaHang values (N'{ten}',N'{mota}',N'{loaihang}',{ngaydangki})";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Thêm thành công");
            }
            catch { }
            finally { con.Close(); }
        }

        public void Sua(string ten, string mota, string loaihang, int ngaydangki)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"Update CuaHang set Mota=N'{mota}',LoaiHang=N'{loaihang}',Ngaydangki={ngaydangki} where Ten=N'{ten}'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Sửa thành công");
            }
            catch { }
            finally { con.Close(); }
        }

        public void Xoa(string ten)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = $"Delete CuaHang where Ten=N'{ten}'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
            }
            catch { }
            finally { con.Close(); }
        }

        public List<CuaHang> SearchByName(string name)
        {
            var allData = GetAll();
            List<CuaHang> search = new List<CuaHang>();
            foreach (var item in allData)
            {
                if (item.TEN.Contains(name))
                {
                    search.Add(item);
                }
            }
            return search;
        }
    }
}


