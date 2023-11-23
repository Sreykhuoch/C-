using System;
using System.Data;
using System.Data.SqlClient;

namespace Order_mgt
{
    internal class sqlDataAdapter
    {
        private string v;
        private SqlConnection con;

        public sqlDataAdapter(string v, SqlConnection con)
        {
            this.v = v;
            this.con = con;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}