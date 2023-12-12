using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblChitiettraNCC
    {
        private string rsID;
        private string mID;
        private string mName;
        private string dvTra;
        private int slTra;
        private float donGia;
        private float tTien;
        public string RsID { get => rsID; set => rsID = value; }
        public string MID { get => mID; set => mID = value; }
        public string MName { get => mName; set => mName = value; }
        public string DvTra { get => dvTra; set => dvTra = value; }
        public int SlTra { get => slTra; set => slTra = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float TTien { get => tTien; set => tTien = value; }
        public tblChitiettraNCC()
        {

        }
    }
}
