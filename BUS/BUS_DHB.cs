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
    public class BUS_DHB
    {
        DAL_HDB hdb = new DAL_HDB();
        public DataTable getHD()
        {
            return hdb.getHD();
        }

        public bool themHD(DTO_HDB hd)
        {
            return hdb.themHD(hd);
        }

        public int kiemtramatrung(string ma)
        {
            return hdb.kiemtramatrung(ma);
        }
        public bool suaDB(DTO_HDB hd)
        {
            return hdb.suaHD(hd);
        }
        public bool suaChiTietDB(DTO_HDB hd)
        {
            return hdb.suaHD(hd);
        }
        public bool xoaHD(string ma)
        {
            return hdb.xoaHD(ma);
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
        public class KetNoi{
        }

    }
}
