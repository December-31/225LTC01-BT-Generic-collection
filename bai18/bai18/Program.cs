using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ho ten: Truong Van Cuong   MaSV: 2415053122304");
            List<Student> list = new List<Student> {
            new Student { Name = "Cuong", Score = 9.5 },
            new Student { Name = "An", Score = 8.0 }
            };

            var topStudent = list.OrderByDescending(s => s.Score).FirstOrDefault();
            if (topStudent != null)
                Console.WriteLine($"SV điem cao nhat: {topStudent.Name} ({topStudent.Score})");
        }
    }
}
