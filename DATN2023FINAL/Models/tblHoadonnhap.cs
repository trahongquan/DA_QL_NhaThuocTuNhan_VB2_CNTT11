using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN2023FINAL.Models
{
    public class tblHoadonnhap
    {
        private string idHD;
        private DateTime ngayNhap;
        private string idNV;
        private string idNCC;
        private string note;
        private float total;

        public string IdHD { get => idHD; set => idHD = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string IdNV { get => idNV; set => idNV = value; }
        public string IdNCC { get => idNCC; set => idNCC = value; }
        public string Note { get => note; set => note = value; }
        public float Total { get => total; set => total = value; }
        public tblHoadonnhap()
        {

        }
        public tblHoadonnhap(string _idHD, DateTime _ngayNhap, string _idNV, string _idNCC, string _note, float _total)
        {
            this.IdHD = _idHD;
            this.NgayNhap = _ngayNhap;
            this.IdNV = _idNV;
            this.IdNCC = _idNCC;
            this.Note = _note;
            this.Total = _total;
        }
    }
}
