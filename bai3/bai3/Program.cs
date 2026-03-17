using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"nhap phan tu {i + 1}:");
                int gt = int.Parse(Console.ReadLine());
                DS.Add(gt);
            }
            int max=DS.Max();
            Console.WriteLine("So lon nhat: "+max);
        }
    }
}
