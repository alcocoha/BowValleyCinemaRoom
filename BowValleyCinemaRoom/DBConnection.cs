using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
