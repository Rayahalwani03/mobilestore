using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.StoreDB
{
    public static class StoreInfo
    {

            [PrimaryKey, AutoIncrement]
            public static int StoreDBId { get; set; }

            public static int SelectedCpu { get; set; }
            public static int SelectedStorage { get; set; }
            public static int SelectedMonitor { get; set; }


        
    }
}
