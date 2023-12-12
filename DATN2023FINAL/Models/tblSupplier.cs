using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblSupplier
    {
        private string _supplierId;
        private string _supplierName;
        private string _supplierPhone;
        private string _supplierAddress;

        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string SupplierPhone { get => _supplierPhone; set => _supplierPhone = value; }
        public string SupplierAddress { get => _supplierAddress; set => _supplierAddress = value; }
        public tblSupplier()
        {

        }
        public tblSupplier(string id, string name, string phone, string address)
        {
            this.SupplierId = id;
            this.SupplierName = name;
            this.SupplierPhone = phone;
            this.SupplierAddress = address;
        }
    }
}
