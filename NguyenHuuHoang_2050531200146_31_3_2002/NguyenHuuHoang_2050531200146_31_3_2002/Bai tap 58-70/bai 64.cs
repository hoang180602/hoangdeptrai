using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuHoang_2050531200146_31_3_2002.Bai_tap_58_70
{
    internal class bai_64
    {
        static void Main(string[] agrs) {
            int n_146, X_146;
            Console.Write("Nhap so luong phan tu cua mang: ");
            n_146 = int.Parse(Console.ReadLine());
            int[] a_146 = new int[n_146 + 1];
            Nhap(a_146, n_146);
            Xuat(a_146, n_146);
            Console.WriteLine("\nSo luy thuy cua 2 co trong mang: {0}", DemLuyThua(a_146, n_146));
            Console.Write("Nhap so X can xoa: ");
            X_146 = int.Parse(Console.ReadLine());
            XoaX(ref a_146, ref n_146, X_146);
            Xuat( a_146,  n_146);
            Console.ReadKey();
        }
        static void Nhap(int[] a_146, int n_146) {
            for (int i = 1; i <= n_146; i++) {
                Console.Write(" a_146[{0}] ", i);
                a_146[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuat(int[] a_146, int n_146) {
            Console.Write("Mang a_146[]: ");
            for (int i = 1; i <= n_146; i++)
            {
                Console.Write(" {0} ", a_146[i]);
            }
        }
        static int DemLuyThua(int[] a_146, int n_146) {
            int dem = 0;
            for (int i = 1; i <= n_146; i++)
            {
                int j = 2;
                while (Math.Pow(2, j) <= a_146[i]) {
                    if (a_146[i] == Math.Pow(2, j)) {
                        dem++;
                    }
                    j++;
                }
            }
            return dem;
        }
        static void XoaX(ref int[] a_146, ref int n_146, int X_146) {
            for (int i = 1; i <= n_146; i++)
            {
                if (a_146[i] == X_146) {
                    for (int j = i; j < n_146; j++) { 
                        a_146[j] = a_146[j + 1];
                    }
                    n_146 = n_146 - 1;
                }
            }
        }
    }
}
