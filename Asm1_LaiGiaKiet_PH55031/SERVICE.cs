using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1_LaiGiaKiet_PH55031
{
    internal class SERVICE 
    {
        List <Oto> lstoto;
        string input;
        public void Nhap()
        {
            do
            {
                Oto oto = new Oto();
                Console.WriteLine("Mời nhập ID ô tô: ");
                oto.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mời nhập Tên ô tô: ");
                oto.Ten = Console.ReadLine();
                Console.WriteLine("Mời nhập Hãng SX: ");
                oto.HangSX = Console.ReadLine();
            } while (input == "Y" || input == "y");
        }
        private bool CheckCount()
        {
            if (lstoto.Count == 0)
            {
                return true;
            }
            return false;
        }
        public void Xuat()
        {
            if(CheckCount())
            {
                Console.WriteLine("Không có danh sách nào");
                return;
            }
            foreach(var iteam in lstoto)
            {
                iteam.InThongTin();
            }
        }
        public void XuatOtoMazda()
        {
            if(CheckCount() )
            {
                Console.WriteLine("Không có danh sách nào");
                return;
            }
            bool isExist = false;
            foreach(var iteam in lstoto)
            {
                if(iteam.HangSX ==  Console.ReadLine())
                {
                    iteam.InThongTin();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Không có xe Mazda nào ");
            }
        }
        public void SapXepTheoIdGiam()
        {

        }
        public void KeThua()
        {
            foreach(var iteam in lstoto)
            {
                iteam.InThongTin();
            }
        }

    }
}
