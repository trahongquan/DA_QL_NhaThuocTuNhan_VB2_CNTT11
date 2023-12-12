using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblHoadontraNCC
    {
        private string rsID;
        private string sID;
        private DateTime rsTime;
        private string eID;
        private float rsTotal;

        public string RsID { get => rsID; set => rsID = value; }
        public string SID { get => sID; set => sID = value; }
        public DateTime RsTime { get => rsTime; set => rsTime = value; }
        public string EID { get => eID; set => eID = value; }
        public float RsTotal { get => rsTotal; set => rsTotal = value; }
        public tblHoadontraNCC()
        {

        }
    }
}
