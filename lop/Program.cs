using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace lop
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int soluong  ;
            Console.WriteLine("nhap so luong sv:");        
            soluong = Convert.ToInt16(Console.ReadLine());
            sinhvien [] L = new sinhvien[soluong];
            //nhap vao thong tin sv
            for (int i = 0;i<soluong;i++)
            {
                 L[i] = new sinhvien();
              
                Console.WriteLine("thong tin sinh vien thu :"+(i +1));
                L[i].nhapSV();
                
               
            }


            // hien thi theo doi tuong truyen vao

            /*foreach ( sinhvien sv in L )
            {
                sv.xuatSV();
                sv.diemTB();
               
            }*/
            for (int i = 0; i < soluong; i++)
            {
                Console.WriteLine(" sinh vien thu :" + (i + 1));
                L[i].xuatSV();
            }
            Console.ReadKey();
        }
    }
}
