using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLNS_DTO;

namespace QLNS_DAL
{
	public class SachDAL : BaseDAL
	{
		public SachDAL()
		{
		}
		public List<SachDTO> GetAll()
		{
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetAllSach";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            var list = new List<SachDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd.Connection = connection;
                connection.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                SachDTO sach = new SachDTO();
                                sach.MaSach = reader["MaSach"].ToString();
                                sach.TenSach = reader["TenSach"].ToString();
                                sach.TheLoai = reader["TheLoai"].ToString();
                                sach.TacGia = reader["TacGia"].ToString();
                                sach.DonGia = Convert.ToInt32(reader["DonGia"]);
                                sach.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                                list.Add(sach);
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
            }
            return list;
        }

		public void Insert(SachDTO sach)
		{
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertSach";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@masach", sach.MaSach));
            cmd.Parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            cmd.Parameters.Add(new SqlParameter("@theloai", sach.TheLoai));
            cmd.Parameters.Add(new SqlParameter("@tacgia", sach.TacGia));
            cmd.Parameters.Add(new SqlParameter("@dongia", sach.DonGia));
            cmd.Parameters.Add(new SqlParameter("@soluong", sach.SoLuong));

            var list = new List<UserDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd.Connection = connection;
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
            }
        }

		public void Update(string id, SachDTO sach)
		{
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdateSach";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@masach", sach.MaSach));
            cmd.Parameters.Add(new SqlParameter("@tensach", sach.TenSach));
            cmd.Parameters.Add(new SqlParameter("@theloai", sach.TheLoai));
            cmd.Parameters.Add(new SqlParameter("@tacgia", sach.TacGia));
            cmd.Parameters.Add(new SqlParameter("@dongia", sach.DonGia));

            var list = new List<UserDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd.Connection = connection;
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
            }
        }

		public void Delete(string id)
		{
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DeleteSach";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@masach", id));

            var list = new List<UserDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                cmd.Connection = connection;
                connection.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
            }
        }
	}
}
