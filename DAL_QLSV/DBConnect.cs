using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL_QLSV
{
 public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=SNOW;initial catalog=QLSV_OU;User ID=sa;Password=123;");
    }
}
