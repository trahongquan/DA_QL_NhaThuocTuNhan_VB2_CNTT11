using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblDonvitinh
    {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public tblDonvitinh()
        {

        }
        public tblDonvitinh(int _id, string _name)
        {
            this.ID = _id;
            this.Name = _name;
        }
    }
}
