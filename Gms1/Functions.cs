using System;
using System.Data;
using System.Data.SqlClient;

namespace Gms1
{
    internal class Functions
    {

        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private string Constr;
        private SqlDataAdapter sda;
        private SqlDataReader sdr;
        public Functions()
        {
            Constr = @"Data Source=DESKTOP-1G72T6C\NOYSQLEXPRESS;Initial Catalog=FMS;Integrated Security=True";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public int setData(String Query)
        {
            int cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);

            sda.Fill(dt);
            return dt;
        }
      

    }
}