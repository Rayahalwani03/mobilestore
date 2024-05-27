using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mobilestore.StoreDB
{
    public static class SharedCpuData
    {
        [PrimaryKey, AutoIncrement]

        public static int Id { get; set; }

        public static int SelectedCpu { get; set; }

    }
}
