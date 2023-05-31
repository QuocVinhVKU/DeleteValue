using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteValue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program program = new Program();

            int[] array = program.nhapMang();

            Console.Write("Nhap gia tri can xoa: ");
            int X = int.Parse(Console.ReadLine());

            int index_del = FindIndex(array, X);
            if (index_del != -1)
            {
                DeleteElement(array, index_del);
                Console.WriteLine("Mang sau khi xoa: ");
                PrintArray(array);
            }
            else
            {
                Console.WriteLine("Khong tim thay gia tri can xoa");
            }

            Console.ReadKey();
        }
        private int[] nhapMang()
        {
            Console.WriteLine("Nhap so phan tu cua mang");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap cac gia tri cua mang");
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static int FindIndex(int[] array, int X)
        {
            return Array.IndexOf(array, X);
        }

        static void DeleteElement(int[] array, int index)
        {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
        }

        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
    }
}
