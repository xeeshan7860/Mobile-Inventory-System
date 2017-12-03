using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.Sql;
using System.Data.SqlClient;
//using System.Data.SqlTypes;
namespace Professional
{
    public class ICSCONN
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Mohammad_Xeeshan\documents\visual studio 2012\Projects\Professional\Professional\ICS.mdf;Integrated Security=True;Connect Timeout=30");
    }
}