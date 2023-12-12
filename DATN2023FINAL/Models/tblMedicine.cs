using System;

namespace DATN2023FINAL.Models
{
    public class tblMedicine
    {
        private int m_IDG;
        private string m_ID;
        private string m_Name;
        private string m_SDK;
        private string m_TPC;
        private string m_HL;
        private string m_Package;
        private string m_NuocSX;
        private string m_BasicUnit;
        private string m_Batch;
        private DateTime m_Dat;
        private int m_Quantity;
        private string m_ImUnit;
        private int m_GTQD;
        private float m_Price;
        private float m_ImPrice;
        private int m_DMT;

        public int IDG { get => m_IDG; set => m_IDG = value; }
        public string ID { get => m_ID; set => m_ID = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string SDK { get => m_SDK; set => m_SDK = value; }
        public string TPC { get => m_TPC; set => m_TPC = value; }
        public string HL { get => m_HL; set => m_HL = value; }
        public string Package { get => m_Package; set => m_Package = value; }
        public string NuocSX { get => m_NuocSX; set => m_NuocSX = value; }
        public string BasicUnit { get => m_BasicUnit; set => m_BasicUnit = value; }
        public string Batch { get => m_Batch; set => m_Batch = value; }
        public DateTime Dat { get => m_Dat; set => m_Dat = value; }
        public int Quantity { get => m_Quantity; set => m_Quantity = value; }
        public string ImUnit { get => m_ImUnit; set => m_ImUnit = value; }
        public int GTQD { get => m_GTQD; set => m_GTQD = value; }
        public float Price { get => m_Price; set => m_Price = value; }
        public float ImPrice { get => m_ImPrice; set => m_ImPrice = value; }
        public int DMT { get => m_DMT; set => m_DMT = value; }
        public tblMedicine()
        {

        }
        public tblMedicine(int a, string b, string c, string d, string e, string f, string g, 
            string h, string i, string k, DateTime l, int m, string n, int o, float p, float q, int s)
        {
            this.IDG = a;
            this.ID = b;
            this.Name = c;
            this.SDK = d;
            this.TPC = e;
            this.HL = f;
            this.Package = g;
            this.NuocSX = h;
            this.BasicUnit = i;
            this.Batch = k;
            this.Dat = l;
            this.Quantity = m;
            this.ImUnit = n;
            this.GTQD = o;
            this.Price = p;
            this.ImPrice = q;
            this.DMT = s;
        }
    }
}
