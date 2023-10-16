using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_Khachhang
    {
        DAL_Khachhang dalkh = new DAL_Khachhang();
        public DataTable getKhachhang()
        {
            return dalkh.getKhachhang();
        }
        public bool themKH(DTO_Khachang kh)
        {
            return dalkh.themKH(kh);
        }
        public int kiemtramatrung(string ma)
        {
            return dalkh.kiemtramatrung(ma);
        }
        public bool suaKH(DTO_Khachang kh)
        {
            return dalkh.suaKH(kh);
        }
        public bool xoaKH(string ma)
        {
            return dalkh.xoaKH(ma);
        }
    }
}
