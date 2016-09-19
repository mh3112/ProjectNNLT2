using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SinhVien
    {
        private string maSV;

        public string MaSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string ngaySinh;

        public string NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        private string queQuan;

        public string QueQuan
        {
            get { return queQuan; }
            set { queQuan = value; }
        }
        private string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        private string diemTB;

        public string DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }
        private string nguoiYeu;

        public string NguoiYeu
        {
            get { return nguoiYeu; }
            set { nguoiYeu = value; }
        }

        public SinhVien(string MaSV, string HoTen, string Lop, string NgaySinh, string GioiTinh, string QueQuan, string DiemTB, string NguoiYeu)
        {
            maSV = MaSV;
            hoTen = HoTen;
            lop = Lop;
            ngaySinh = NgaySinh;
            gioiTinh = GioiTinh;
            queQuan = QueQuan;
            diemTB = DiemTB;
            nguoiYeu = NguoiYeu;
        }
        public SinhVien()
        {

        }
    }
}
