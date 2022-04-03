using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_31_3_2002.Bai_tap_58_70
{
    internal class bai_63
    {
        static void Main(string[] agrs)
        {
            Random rd_146 = new Random();
            int n_146;
            Console.Write("Moi ban nhap so luong phan tu cua mang: ");
            n_146 = int.Parse(Console.ReadLine());
            int[] a_146 = new int[n_146 + 1];
            for (int i = 1; i <= n_146; i++)
            {
                a_146[i] = rd_146.Next(-100, 100);
            }
            Xuat(a_146, n_146);
            Console.WriteLine("\nSo phan tu chia het cho 4 va tan cung la 6: {0}", Dem(a_146, n_146));
            ThayDoiGT(ref a_146, n_146);
            Console.WriteLine("Thay phan tu le bang 2 lan gia tri cua no: ");
            Xuat(a_146, n_146);
        }
        
        static void Xuat(int[] a_146, int n_146) {

            for (int i = 1; i <= n_146; i++)
            {
                Console.Write(" {0} ", a_146[i]);
            }
        }
        static int Dem(int[] a_146, int n_146) {
            int dem_146 = 0;
            for (int i = 1; i <= n_146; i++) {
                if (a_146[i] % 4 == 0 && a_146[i] % 10 == 6) {
                    dem_146++;
                }
            }
            return dem_146;
        }
        static void ThayDoiGT(ref int[] a_146, int n_146) {
            for (int i = 1; i <= n_146; i++)
            {
                if(a_146[i] % 2 != 0)
                {
                   a_146[i] = 2 * a_146[i];
                }
            }
        }
    }
}
