using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };
            Console.WriteLine("Danh sach "+string.Join(" ,",numbers));
            int minVal = numbers.Min();
            Console.WriteLine($"Phan tu nho nhat: {minVal}");
        }
    }
}
