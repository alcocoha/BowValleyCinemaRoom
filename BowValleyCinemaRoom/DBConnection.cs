using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BowValleyCinemaRoom
{
    internal class DBConnection
    {
        private const string connectionString = "Data Source=WSAMZN-1IFU9CTT;Initial Catalog=BowValleyCinemaRoom;"
        + "Integrated Security=true";

        public string GetConnectionString() {
            return connectionString;
        }
    }
}
