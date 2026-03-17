using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<int> { 4,6,6,9,8};
            int tong = DS.Sum();
            Console.WriteLine("Tong: " + tong);

        }
    }
}
