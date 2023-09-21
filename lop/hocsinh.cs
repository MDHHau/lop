using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lop
{

    internal class sinhvien : nguoi
    {
        //khai bao thuoc tinh
        int maSV;
        string tenSV;
        int namsinh;
        string diachi;
        int diemtoan, diemvan, diemanh;
        // xay dung ham constructor 2
        public sinhvien()
        {}
          public sinhvien(int ma, string ten, int ns, string dc, int Diemtoan,int Diemvan, int Diemanh)
            
        {
            maSV= ma;
            tenSV= ten;
            namsinh= ns;
            diachi= dc;
            diemtoan = Diemtoan;
            diemvan= Diemvan;
            diemanh = Diemanh;
            
        }
       
        public void nhapSV()
        {
            
            Console.WriteLine("nhap ma Sv: ");
            maSV = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap ten Sv: ");
            tenSV = Console.ReadLine();
            Console.WriteLine("nhap nam sinh Sv: ");
            namsinh = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap dia chi Sv: ");
            diachi = Console.ReadLine();
            Console.WriteLine("nhap gioi tinh Sv: ");
            gt = Console.ReadLine();
            Console.WriteLine("nhap diem toan Sv: ");
            diemtoan = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap diem van Sv: ");
            diemvan = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap diem anh Sv: ");
            diemanh = Convert.ToInt16(Console.ReadLine());
           

        }
        public void xuatSV()
        {
           
            Console.WriteLine("ma SV : "+maSV);
            Console.WriteLine("ten SV : " + tenSV);
            Console.WriteLine("nam sinh SV : " + namsinh);
            Console.WriteLine("dia chi SV : " + diachi);
            Console.WriteLine("gioi tinh SV: "+gt);
            Console.WriteLine("diem toan : " + diemtoan);
            Console.WriteLine("diem van : " + diemvan);
            Console.WriteLine("diem anh : " + diemanh);
        }
        public void diemTB()
        {
            double diemtb = 0,tong=0;
            tong = diemtoan + diemvan + diemanh ;
            diemtb = tong / 3;
            Console.WriteLine("diem trung binh cong :");
            String doikieu = diemtb.ToString("F2");
            Console.WriteLine(doikieu);
        }
    }
}
