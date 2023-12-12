using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblChitietnhap
    {
        private string idHD;
        private string idM;
        private string mName;
        private string mBatch;
        private DateTime mDat;
        private int mQuantity;
        private string mImUnit;
        private int mGTQD;
        private float mPrice;
        private float mImPrice;
        private float total;
       
        public string IdHD { get => idHD; set => idHD = value; }     
        public string IdM { get => idM; set => idM = value; }
        public string MName { get => mName; set => mName = value; }       
        public string MBatch { get => mBatch; set => mBatch = value; }
        public DateTime MDat { get => mDat; set => mDat = value; }
        public int MQuantity { get => mQuantity; set => mQuantity = value; }
        public string MImUnit { get => mImUnit; set => mImUnit = value; }
        public int MGTQD { get => mGTQD; set => mGTQD = value; }
        public float MPrice { get => mPrice; set => mPrice = value; }
        public float MImPrice { get => mImPrice; set => mImPrice = value; }
        public float Total { get => total; set => total = value; }
        public tblChitietnhap()
        {

        }

    }
}
