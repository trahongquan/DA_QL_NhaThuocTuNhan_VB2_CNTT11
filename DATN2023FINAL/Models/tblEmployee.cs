using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblEmployee
    {
        private string e_ID;
        private string fullname;
        private DateTime birthday;
        private string gender;
        private string phoneNumber;
        private string addres;

        public string E_ID { get => e_ID; set => e_ID = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Addres { get => addres; set => addres = value; }
        public tblEmployee()
        {

        }
        public tblEmployee(string a, string d, DateTime e, string f, string g, string h)
        {
            this.E_ID = a;
            this.Fullname = d;
            this.Birthday = e;
            this.Gender = f;
            this.PhoneNumber = g;
            this.Addres = h;
        }
    }
}
