using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai14
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
            foreach (var s in students) Console.WriteLine($"ID: {s.Id}, Tên: {s.Name}");
            Console.Write("\nNhap ID can xoa: ");
            int idToRemove = int.Parse(Console.ReadLine());
            students.RemoveAll(s => s.Id == idToRemove);
            Console.WriteLine("Đa cap nhat danh sach.");
            foreach (var s in students) Console.WriteLine($"ID: {s.Id}, Tên: {s.Name}");
        }
    }
}
