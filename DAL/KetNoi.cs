using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KetNoi
    {
        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-3913IU8\PHUONG2003;Initial Catalog=QUANLYNHANVIEN;Integrated Security=True;");
        public void CheckConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
    }
}
