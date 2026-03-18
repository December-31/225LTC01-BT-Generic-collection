using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<int> nums = new List<int>  ();
            Console.Write("Nhap so luong phan tu: ");
            int n= int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu thu {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                nums.Add(num);
            }
            var mostFrequent = nums.GroupBy(x => x)
                                   .OrderByDescending(g => g.Count())
                                   .First().Key;

            Console.WriteLine($"So xuat hien nhieu nhat: {mostFrequent}");
        }
    }
}
