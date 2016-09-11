using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SinhVienBusiness
    {
        List<SinhVien> GetAllSinhVien()
        {
            FileAccess fa = new FileAccess();
            fa.URL = "";
            SinhVien sv;
            List<SinhVien> res = new List<SinhVien>();
            List<string[]> lstSv = fa.ReadAllFile();
            foreach (string[] props in lstSv)
            {
                sv = new SinhVien();
                sv.MaSV = int.Parse(props[0]);

                res.Add(sv);
            }
            return res;
        }

        SinhVien GetByMaSV(string maSV)
        {
            //DataAccess da = new DataAccess();
            //DataTable dt = da.ExecuteQuery("Select * from SinhVien where maSV = '"+maSV+"'");
            FileAccess fa = new FileAccess();
            fa.URL = "";
            SinhVien sv = new SinhVien();
            List<string[]> lstSv = fa.ReadAllFile();
            foreach (string[] props in lstSv)
            {
                sv = new SinhVien();
                sv.MaSV = int.Parse(props[0]);
            }
            return sv;
        }
    }
}
