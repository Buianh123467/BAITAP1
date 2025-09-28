using System;
using PersonalLifeNumberLib;

namespace ConsoleLifeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Đoán nghề nghiệp (Life Number) ===");
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            try
            {
                DateTime birth = DateTime.ParseExact(input, "dd/MM/yyyy", null);
                LifeNumber ln = new LifeNumber { BirthDate = birth };

                Console.WriteLine("So chu dao: " + ln.GetLifePathNumber());
                Console.WriteLine("Y nghia: " + ln.GetMeaning());
            }
            catch
            {
                Console.WriteLine("Ngay sinh khong hop le!");
            }
            Console.WriteLine("\nNhan phim bat ky de thoat...");
            Console.ReadKey();
        }
    }
}