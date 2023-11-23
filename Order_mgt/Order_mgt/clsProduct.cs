using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_mgt
{
    class clsProduct
    {
        //propertues_of_products
        public int Code { get; set; }
        public string proName { get; set; }
        public int qty { get; set; }
        public double price { get; set; }


        //Create Methods GetData()

        public DataTable getData()
        {
            DataTable dt = new DataTable();
            sqlDataAdapter da = new sqlDataAdapter("select * from tblProduct", clsConnection.con);
            dt.Clear();
            da.Fill(dt);
            return dt;
        }


    }
}
