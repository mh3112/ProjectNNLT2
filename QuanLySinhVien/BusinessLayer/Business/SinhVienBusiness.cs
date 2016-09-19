using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SinhVienBusiness
    {
        /*public List<SinhVien> GetAllSinhVien()
        {
            FileAccess fa = new FileAccess();
            fa.URL = "danhsach.txt";
            SinhVien sv;
            List<SinhVien> res = new List<SinhVien>();
            List<string[]> lstSv = fa.ReadAllFile();
            foreach (string[] props in lstSv)
            {
                sv = new SinhVien();
                sv.maSV = int.Parse(props[0]);
                sv.hoTen = props[1];
                sv.lop = props[2];
                sv.ngaySinh = Convert.ToDateTime(props[3]);
                if (props[4] == "Nam")
                    sv.gioiTinh = true;
                else
                    sv.gioiTinh = false;
                sv.queQuan = props[5];
                if (props[6] == "Co")
                    sv.nguoiYeu = true;
                else
                    sv.nguoiYeu = false;
                res.Add(sv);
            }
            return res;
        }
        */
        


      
    }
}
