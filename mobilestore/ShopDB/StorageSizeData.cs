using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.ShopDB
{
    public static class StorageSizeData
    {

        [PrimaryKey, AutoIncrement]

        public static int StorageSizeData_Id { get; set; }

        public static int SelectedStorageSize { get; set; }
    }
}
