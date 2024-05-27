using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.ShopDB
{
    public static class MonitorSizeData
    {

        [PrimaryKey, AutoIncrement]

        public static int MonitorSizeData_Id { get; set; }

        public static int SelectedMonitorSize { get; set; }
    }
}
