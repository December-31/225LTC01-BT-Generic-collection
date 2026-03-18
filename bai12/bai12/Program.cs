using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<Student> students = new List<Student> {
            new Student(1, "Cuong"),
            new Student(2, "Lan"),
            new Student(3, "Minh")
            };
            Console.Write("\nNhap ten can tim: ");
            string searchName = Console.ReadLine();
            var found = students.Where(s => s.Name.ToLower().Contains(searchName.ToLower())).ToList();
            Console.WriteLine(found.Count > 0 ? $"Tim thay {found.Count} SV." : "Khong tim thay.");
        }
    }
}
