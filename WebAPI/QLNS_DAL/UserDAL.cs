using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLNS_DTO;

namespace QLNS_DAL
{
    public class UserDAL : BaseDAL
    {
        public UserDAL()
        {
        }

        public List<UserDTO> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "GetAllUser";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            var list = new List<UserDTO>();
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
                                UserDTO user = new UserDTO();
                                user.Id = reader["Id"].ToString();
                                user.Username = reader["Username"].ToString();
                                user.Password = reader["Password"].ToString();
                                user.MaChucVu = reader["MaChucVu"].ToString();
                                list.Add(user);
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
                return list;
            }

        }

        public void Insert(UserDTO user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "InsertUser";       
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userid", user.Id));
            cmd.Parameters.Add(new SqlParameter("@username", user.Username));
            cmd.Parameters.Add(new SqlParameter("@password", user.Password));
            cmd.Parameters.Add(new SqlParameter("@machucvu", user.MaChucVu));

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
        public void Update(string userid, UserDTO user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UpdatetUser";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userid", userid));
            cmd.Parameters.Add(new SqlParameter("@password", user.Password));
            cmd.Parameters.Add(new SqlParameter("@machucvu", user.MaChucVu));

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

        public void Delete(string userid)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DeleteUser";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userid", userid));

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
