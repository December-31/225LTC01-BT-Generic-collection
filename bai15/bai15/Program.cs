using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            Dictionary<string, string> dict = new Dictionary<string, string> {
            { "hello", "xin chào" },
            { "student", "sinh viên" },
            { "computer", "máy tính" }
             };

            Console.Write("Nhap tu tieng Anh: ");
            string word = Console.ReadLine().ToLower();

            if (dict.ContainsKey(word))
                Console.WriteLine($"Nghia la: {dict[word]}");
            else
                Console.WriteLine("Tu nay chua co trong tu đien.");
        }
    }
}
