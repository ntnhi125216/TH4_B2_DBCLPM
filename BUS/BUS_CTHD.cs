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
    public class BUS_CTHD
    {
        DAL_CTHD cthd = new DAL_CTHD();
        public DataTable getChiTietHD()
        {
            return cthd.getChiTietHD();
        }
        public bool themChiTietHD(DTO_CTHDB hd)
        {
            return cthd.themCTHD(hd);
        }
        public bool xoaCTHD(string ma)
        {
            return cthd.xoaCTHD(ma);
        }
        public DataTable getNV()
        {
            return cthd.getNhanVien();
        }
        public DataTable getSP()
        {
            return cthd.getSanPham();
        }
        public DataTable getKH()
        {
            return cthd.getKhachHang();
        }
        public string GetFieldValues(string sql)
        {
            return cthd.GetFieldValues(sql);
        }
        public void ThucThiSql(string sql)
        {
        }
    }
}
