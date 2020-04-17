using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper2OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //tao danh sach cac nhan vien
            int n;
            Console.WriteLine("Nhap so nhan vien");
            n = Int32.Parse(Console.ReadLine());
            NhanVien[] nv = new NhanVien[100];//tao mang nhan vien
            for(int i = 0; i < n; i++)
            {
                nv[i] = new NhanVien();
                nv[i].NhapTT();
                nv[i].InTT();
            }
            Console.ReadLine();
            
        }
    }
}
