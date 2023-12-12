using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblMedicineGroup
    {
        private int mGID;
        private string mGName;

        public int MGID { get => mGID; set => mGID = value; }
        public string MGName { get => mGName; set => mGName = value; }
        public tblMedicineGroup()
        {

        }
        public tblMedicineGroup(int id, string name)
        {
            this.MGID = id;
            this.MGName = name;
        }
    }
}
