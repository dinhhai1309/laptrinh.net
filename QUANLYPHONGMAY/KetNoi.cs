using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QUANLYPHONGMAY
{
    class KetNoi
    {
        string constr = @"Data Source=DINHHAI13092003;Initial Catalog=QuanLyPhongmay;Integrated Security=True";
        SqlConnection conn;

        public KetNoi()
        {
            conn = new SqlConnection(constr);
        }

        // lay du lieu
        public DataTable LayDuLieu(string truy_van)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(truy_van,conn);
                DataTable tb = new DataTable();
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }
        // thuc thi du lieu
        public bool ThucThi(string truy_van)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truy_van, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }

    }
}
