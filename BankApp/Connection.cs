using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Connection
    {
        public static SqlConnection conn = new SqlConnection
            ("Server=DESKTOP-99CL9OI\\SQLEXPRESS;Database=BankaUygulamasi;Trusted_Connection=True;");

    }
}
