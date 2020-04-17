using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper2OOP
{
    class NhanVien
    {
        private String ten;
        private double hsl;
        public NhanVien()
        {

        }
        public NhanVien(String ten,double hsl)
        {
            this.ten = ten;
            this.hsl = hsl;
        }
        public void NhapTT()
        {
            Console.WriteLine("Nhap ten =");
            this.ten = Console.ReadLine();
            Console.WriteLine("Nhap he so luong=");
            this.hsl = Double.Parse(Console.ReadLine());
        }
        public double TinhLuong()
        {
            return (this.hsl * 1490000);
        }
        public void InTT()
        {
            Console.WriteLine("Ten nhan vien {0} co so luong la {1}", this.ten, this.TinhLuong());
        }
    }
}
