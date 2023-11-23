using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_mgt
{
    class clsConnection
    {
        public static SqlConnection con = new SqlConnection();
    }
}
