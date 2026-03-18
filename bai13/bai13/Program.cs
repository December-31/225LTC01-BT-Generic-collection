using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
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
            Console.WriteLine($"\nTong so sinh viên: {students.Count}");
        }
    }
}
