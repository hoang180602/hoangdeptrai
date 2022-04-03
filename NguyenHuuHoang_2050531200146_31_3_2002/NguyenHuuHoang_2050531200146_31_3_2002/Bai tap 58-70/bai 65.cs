using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_31_3_2002.Bai_tap_58_70
{
    internal class bai_65
    {
        static void Main(string[] agrs) {
            int n_146;
            Console.Write("Moi ban nhap so luong phan tu cua mang: ");
            n_146 = int.Parse(Console.ReadLine());
            int[] a_146 = new int[n_146 + 1];
            Nhap(a_146, n_146);
            Console.Write("Mang cua ban la a_146[]: ");
            Xuat(a_146, n_146);
            Console.WriteLine("\nTrung binh cac so nguyen am le S = {0}", TBLe(a_146, n_146));
            XoaTrung(ref a_146, ref n_146);
            Console.Write("Mang cua ban sau khi xoa trung la a_146[]: ");
            Xuat(a_146, n_146);
            Console.ReadKey();
        }
        static void Nhap(int[] a_146, int n_146) {
            for (int i = 1; i <= n_146; i++) {
                Console.Write("a_146[{0}]: ", i);
                a_146[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a_146, int n_146)
        {
            for (int i = 1; i <= n_146; i++)
            {
                Console.Write(" {0} ", a_146[i]);
            }
        }
        static float TBLe(int[] a_146, int n_146) {
            int tong = 0, dem = 0;
            for (int i = 1; i <= n_146; i++)
            {
                if (a_146[i] < 0 && a_146[i] % 2 != 0) { 
                    tong = tong + a_146[i];
                    dem = dem + 1;
                }
            }
            return (float)tong / dem; 
        }
        static void XoaTrung(ref int[] a_146, ref int n_146) {
            for (int i = 1; i < n_146; i++) {
                for (int j = i + 1; j <= n_146; j++) {
                    if (Math.Abs(a_146[i]) == Math.Abs(a_146[j])) {
                        for (int k = j; k < n_146; k++) {
                            a_146[k] = a_146[k + 1];
                        }
                        n_146 = n_146 - 1;
                    }
                }
            }
        }
    }
}
