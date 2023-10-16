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
    public class BUS_NCC
    {
        DAL_NCC dalncc = new DAL_NCC();
        public DataTable getNCC()
        {
            return dalncc.getNCC();
        }
        public bool themNCC(DTO_NCC ncc)
        {
            return dalncc.thmNCC(ncc);
        }
        public int kiemtramatrung(string ma)
        {
            return dalncc.kiemtramatrung(ma);
        }
        public bool suaNCC(DTO_NCC ncc)
        {
            return dalncc.suaNCC(ncc);
        }
        public bool xoaNCC(string ma)
        {
            return dalncc.xoaNCC(ma);
        }
    }
}
