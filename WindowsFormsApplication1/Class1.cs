using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConn
{
    class Sql
    {
        public static SqlConnection makeConn()
        {
            string connetionString;
            connetionString = @"Data Source=ALPHADAWG-PC\sqlexpress;Initial Catalog=MIS;Integrated Security=True";
            return new SqlConnection(connetionString);
        }
    }
}
