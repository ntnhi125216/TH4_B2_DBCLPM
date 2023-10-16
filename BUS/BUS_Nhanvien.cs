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
    public class BUS_Nhanvien
    {
        DAL_Nhanvien dalnv = new DAL_Nhanvien();
        public DataTable getNhanvien()
        {
            return dalnv.getNhanvien();
        }
        public bool themNV(DTO_Nhanvien nv)
        {
            return dalnv.themNV(nv);
        }
        public int kiemtramatrung(string ma)
        {
            return dalnv.kiemtramatrung(ma);
        }
        public bool suaNV(DTO_Nhanvien nv)
        {
            return dalnv.suaNV(nv);
        }
        public bool xoaNV(string ma)
        {
            return dalnv.xoaNV(ma);
        }
    }
    
}
