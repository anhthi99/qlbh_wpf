using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_WPF.Models
{
    public class DataProvider
    {
        private static DataProvider _ins = new DataProvider();
        public static DataProvider Instance
        {
            get => _ins;
            set => _ins = new DataProvider();
        }
        public QLBH_WPFEntities Data { get; set; }

        public DataProvider()
        {
            Data = new QLBH_WPFEntities();
        }
    }
}
