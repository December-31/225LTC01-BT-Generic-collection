using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
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
            Console.WriteLine("Danh sach ban dau: " + string.Join(", ", DS));
            for (int i = 0; i < DS.Count; i++)
            {
                for (int j = i+1;j < DS.Count ; j++)
                {
                    if (DS[i] > DS[j])
                    {
                        int temp = DS[j];
                        DS[j] = DS[i];
                        DS[i ] = temp;
                    }
                }
            }
            Console.WriteLine("Danh sach sau sap xep: " + string.Join(", ", DS));
        }
    }
}
