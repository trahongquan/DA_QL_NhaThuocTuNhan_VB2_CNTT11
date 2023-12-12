using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblChitietSale
    {
        private string dsale_ID;
        private string m_ID;
        private string m_Name;
        private int saleQuantity;
        private string m_saleUnit;
        private float salePrice;
        private float total;

        public string Dsale_ID { get => dsale_ID; set => dsale_ID = value; }
        public string M_ID { get => m_ID; set => m_ID = value; }
        public string M_Name { get => m_Name; set => m_Name = value; }
        public int M_SaleQuantity { get => saleQuantity; set => saleQuantity = value; }
        public string M_SaleUnit { get => m_saleUnit; set => m_saleUnit = value; }
        public float M_SalePrice { get => salePrice; set => salePrice = value; }
        public float Total { get => total; set => total = value; }
        public tblChitietSale()
        {

        }
    }
}
