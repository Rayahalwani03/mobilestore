using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.StoreDB
{
    public static class SharedMonitorData
    {

        [PrimaryKey, AutoIncrement]
        public static int Monitor_ID { get; set; }

        public static int SelectedMonitor { get; set; }

    }
}
