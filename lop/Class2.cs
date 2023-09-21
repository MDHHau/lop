using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop
{
    internal class nguoi
    {
       public string gt { get; set; }
    
    public nguoi()
    { }

    public nguoi(string gt)
    {
        gt = gt;
    }
    public void nhapTT()
    {
        Console.WriteLine("nhap gioi tinh Sv: ");
        gt = Console.ReadLine();
    }
    public void xuatTT()
        {
            Console.WriteLine("gioi tinh SV :" + gt);
        }
}
}
    

