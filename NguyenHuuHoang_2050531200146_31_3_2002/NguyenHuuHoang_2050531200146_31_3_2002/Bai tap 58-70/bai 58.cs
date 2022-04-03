using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_31_3_2002.Bai_tap_58_70
{
    internal class bai_58
    {
        static void Main(string[] agrs) {
            int n_146, i_146, j_146;
            Console.Write("Moi ban nhap so luong phan tu cho mang: ");
            n_146 = int.Parse(Console.ReadLine());
            Boolean[] a_146 = new Boolean[n_146 + 1];

            for (i_146 = 2; i_146 <= n_146; i_146++)
            {
                a_146[i_146] = true;
            }

            for (i_146 = 2; i_146 <= n_146; i_146++)
            {
                if (a_146[i_146] == true)
                {
                    for (j_146 = 2 * i_146; j_146 <= n_146; j_146 += i_146)
                    {
                        a_146[j_146] = false;
                    }
                }
            }

            for (i_146 = 2; i_146 <= n_146; i_146++)
            {
                if (a_146[i_146] == true)
                {
                    Console.Write(" {0} ", i_146);
                }
            }
            Console.ReadKey();

        }
    }
}
