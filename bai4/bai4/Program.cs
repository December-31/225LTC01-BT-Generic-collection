using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            var DS = new List<int> { 3,56,2,6,1 };
            int count = 0;
            foreach (int i in DS) 
            { 
                if(i % 2 == 0)
                    count++;
            }
            Console.WriteLine("So luong so chan trong DS: " + count);
        }
    }
}
