using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLNS_DTO;

namespace QLNS_DAL
{
	public abstract class BaseDAL
	{
		private SqlConnection sqlConnection;
		protected string databaseName;
		protected string connectionString;

		public BaseDAL()
		{
			connectionString = Convert.ToString(System.Configuration.ConfigurationManager.ConnectionStrings["QLNHASACH"].ConnectionString);
			sqlConnection = new SqlConnection(connectionString);
		}
	}
}
