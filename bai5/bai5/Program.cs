using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<string> { "An", "cuong", "huy", "minh", "hoa"};
            Console.WriteLine("Danh sach sinh vien: "+ String.Join(" ,",DS));
            Console.Write("Nhap ten sinh vien can xoa: ");
            string name = Console.ReadLine();
            if(DS.Contains(name))
            {
                DS.Remove(name);
                Console.WriteLine("Danh sach sinh vien sau khi xoa: " + String.Join(" ,", DS));
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien can xoa");
            }
        }
    }
}
