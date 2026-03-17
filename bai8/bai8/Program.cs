using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<int> { 5,9,3,85,4};
            Console.WriteLine("Danh sach ban dau: "+string.Join(" ,",DS));
            int b = 4;
            for (int i = 0; i< 2; i++)
            {
                int a = DS[i];
                DS[i] = DS[b];
                DS[b] = a;
                b--; 
            }
            Console.WriteLine("Danh sach sau khi hoan doi: " + string.Join(" ,", DS));
        }
    }
}
