using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblCustomer
    {
        private string c_id;
        private string c_name;
        private int c_age;
        private string c_gender;
        private string c_phone;
        private string c_address;      

        public string C_id { get => c_id; set => c_id = value; }
        public string C_name { get => c_name; set => c_name = value; }
        public int C_age { get => c_age; set => c_age = value; }
        public string C_gender { get => c_gender; set => c_gender = value; }
        public string C_phone { get => c_phone; set => c_phone = value; }
        public string C_address { get => c_address; set => c_address = value; }

        public tblCustomer()
        {

        }
        public tblCustomer(string _cid, string _cname, int _cage, string _cgender, string _cphone, string _caddress)
        {
            this.C_id = _cid;
            this.C_name = _cname;
            this.C_age = _cage;
            this.C_gender = _cgender;
            this.C_phone = _cphone;
            this.C_address = _caddress;
        }
    }
}
