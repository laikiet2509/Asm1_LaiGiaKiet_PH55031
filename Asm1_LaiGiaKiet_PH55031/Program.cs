using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1_LaiGiaKiet_PH55031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            int menu;
            SERVICE service = new SERVICE();
            do
            {
                Console.WriteLine("1.Nhập danh sách ô tô");
                Console.WriteLine("2.Xuất danh sách ô tô");
                Console.WriteLine("3.Xuất danh sách ô tô hãng Mazda");
                Console.WriteLine("4.Sắp xếp ô tô theo id giảm dần");
                Console.WriteLine("5.Thoát...");
                Console.WriteLine("Mời bạn chọn chức năng: ");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Nhập danh sách ô tô: ");
                        service.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Xuất danh sách ô tô: ");
                        service.Xuat();
                        break;
                    case 3:
                        Console.WriteLine("Xuất danh sách ô tô hãng Mazda: ");
                        service.XuatOtoMazda();
                        break;
                    case 4:
                        Console.WriteLine("Sắp xếp ô tô theo id giảm dần: ");
                        service.SapXepTheoIdGiam();
                        break;
                    case 5:
                        Console.WriteLine("Thoát...");
                        Environment.Exit(5);
                        break;
                    default:
                        Console.WriteLine("Chọn sai chương trình");
                        break;
                    
                }
            } while (menu != 5);

        }
    }
}
