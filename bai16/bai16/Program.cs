using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            Console.Write("Nhap chuoi: ");
            string input = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (counts.ContainsKey(c)) counts[c]++;
                else counts[c] = 1;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
