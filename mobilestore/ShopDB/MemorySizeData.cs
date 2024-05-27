using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.ShopDB
{
    public static class MemorySizeData
    {
        [PrimaryKey, AutoIncrement]

        public static int MemorySizeData_Id { get; set; }

        public static int SelectedMemorySize { get; set; }
    }
}
