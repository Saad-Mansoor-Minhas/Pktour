using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibraryDAL
{
    public class DBHelper
    {

        public static SqlConnection GetConnection()
        {
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-S3FM756;Initial Catalog=pktrip;Integrated Security=True");
            
            //ibtehaj db
            SqlConnection con = new SqlConnection(@"Data Source = IBTEHAJ-PC\SQLEXPRESS; Initial Catalog=trip; Integrated Security=True");
            //online
            //SqlConnection con = new SqlConnection("Data Source = pktour.database.windows.net; Initial Catalog = Trip; Persist Security Info = True; User ID = pkadmin;Password=SAAD@aashir");
            return con;
        }
    }
}
