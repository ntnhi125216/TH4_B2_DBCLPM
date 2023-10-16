using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_HDN
    {
        DAL_HDN hdb = new DAL_HDN();
        public DataTable getHDN()
        {
            return hdb.getHDN();
        }

        public bool themHDN(DTO_HDN hd)
        {
            return hdb.themHDN(hd);
        }

        public int kiemtramatrung(string ma)
        {
            return hdb.kiemtramatrung(ma);
        }
        public bool suaDB(DTO_HDN hd)
        {
            return hdb.suaHDN(hd);
        }
        public bool suaChiTietDB(DTO_HDN hd)
        {
            return hdb.suaHDN(hd);
        }
        public bool xoaHDN(string ma)
        {
            return hdb.xoaHDN(ma);
        }
        public DataTable udSL(double sl, string maSP)
        {
            return hdb.udSl(sl, maSP);
        }
        public DataTable udTT(double Tongmoi, string maHD)
        {
            return hdb.udtt(Tongmoi, maHD);
        }
        public void thucthiSQL(string sql)
        {
        }


        public DataTable getChiTietHDN()
        {
            return hdb.getChiTietHDN();
        }
        public bool themChiTietHD(DTO_CTHDN hd)
        {
            return hdb.themCTHDN(hd);
        }
        public bool xoaCTHDN(string ma)
        {
            return hdb.xoaCTHDN(ma);
        }
        public DataTable getNV()
        {
            return hdb.getNhanVien();
        }
        public DataTable getSP()
        {
            return hdb.getSanPham();
        }
        public DataTable getKH()
        {
            return hdb.getNCC();
        }
        public string GetFieldValues(string sql)
        {
            return hdb.GetFieldValues(sql);
        }
    }
}
