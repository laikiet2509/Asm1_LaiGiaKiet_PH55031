using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm1_LaiGiaKiet_PH55031
{
    internal class Oto
    {
        int id;
        string ten;
        string hangSX;
        public Oto()
        {
            
        }
        public Oto(int id, string ten, string hangSX)
        {
            this.id = id;
            this.ten = ten;
            this.hangSX = hangSX;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string HangSX { get => hangSX; set => hangSX = value; }

        public void InThongTin()
        {
            Console.WriteLine($"ID: {id} Tên: {ten} Hãng SX: {hangSX}");
        }
    }
}
