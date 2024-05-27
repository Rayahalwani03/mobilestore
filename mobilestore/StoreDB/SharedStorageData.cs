using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.StoreDB
{
    public static class SharedStorageData
    {
        [PrimaryKey, AutoIncrement]
        public static int ID { get; set; }

        public static int SelectedStorage { get; set; }

        
    }
}
