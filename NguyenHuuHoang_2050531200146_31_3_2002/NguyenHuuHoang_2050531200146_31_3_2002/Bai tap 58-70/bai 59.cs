using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_31_3_2002.Bai_tap_58_70
{
    internal class bai_59
    {
        static void Main(string[] agrs)
        {
            string[] Can_146 = {"Canh", "Tan", "Nham", "Quy", "Giap", "At", "Binh", "Dinh", "Mau", "Ky"};
            string[] Chi_146 = {"Than", "Dau", "Tuat", "Hoi", "Ty", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui" };
            int nam_146;
            Console.Write("Moi ban nhap nam duong: ");
            nam_146 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} - {1} {2}", nam_146, Can_146[nam_146 % 10], Chi_146[nam_146 % 12 ]);
            Console.WriteLine("{0} - {1} {2}", nam_146 + 60, Can_146[nam_146 % 10 ], Chi_146[nam_146 % 12 ]);
            Console.ReadKey();
        }
    }
}
