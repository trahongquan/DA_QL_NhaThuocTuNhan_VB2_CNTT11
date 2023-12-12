using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblSale
    {
        private string sale_ID;
        private string e_ID;
        private string c_ID;
        private DateTime sale_Time;
        private float sale_Total;

        public string Sale_ID { get => sale_ID; set => sale_ID = value; }
        public string E_ID { get => e_ID; set => e_ID = value; }
        public string C_ID { get => c_ID; set => c_ID = value; }
        public DateTime Sale_Time { get => sale_Time; set => sale_Time = value; }
        public float Sale_Total { get => sale_Total; set => sale_Total = value; }
        public tblSale()
        {

        }
    }
}
