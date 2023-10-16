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
    public class BUS_SanPham
    {
        DAL_SanPham dalsp = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dalsp.getSanPham();
        }
        public bool themSP(DTO_SanPham sp)
        {
            return dalsp.themSP(sp);
        }
        public int kiemtramatrung(string ma)
        {
            return dalsp.kiemtramatrung(ma);
        }
        public bool suaSP(DTO_SanPham sp)
        {
            return dalsp.suaSP(sp);
        }
        public bool XoaSP(string ma)
        {
            return dalsp.xoaSP(ma);
        }
        public DataTable getcbbSP()
        {
            return dalsp.loadcbbSP();
        }
        public DataTable getSPpkn(string sql)
        {
            return dalsp.getSPpkn(sql);
        }
    }
}
