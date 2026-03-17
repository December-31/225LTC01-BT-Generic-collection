using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<string> { "An", "cuong", "huy", "minh", "hoa" };
            Console.WriteLine("Danh sach chuoi: " + String.Join(" ,", DS));
            Console.Write("Nhap chuoi can tim: ");
            string name = Console.ReadLine();
            if (DS.Contains(name))
            {          
                Console.WriteLine($"Co chuoi {name} trong danh sach");
            }
            else
            {
                Console.WriteLine($"Khong co chuoi {name} trong danh sach");
            }
        }
    }
}
