using System;

namespace PRG2_20192_P1_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            float hipotenusa;

            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Hipotenusa");
            Console.WriteLine("3. Hitung Keliling");
            Console.WriteLine("4. Keluar");
            Console.Write("Menu Pilihan : ");
            int number = Convert.ToInt16(Console.ReadLine());
            switch(number)
            {
                case 1:
                    {
                        Console.WriteLine("Menghitung luas segitiga");
                        Console.Write("Masukkan alas segitiga : ");     float a = float.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi Segitiga : ");   float t = float.Parse(Console.ReadLine());
                        float luas = a * t / 2;
                        Console.WriteLine("Luas Segitiga dengan alas {0} dan tinggi {1} adalah {2} cm ", a, t, luas);
                        System.Console.ReadKey();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Hipotenusa segitiga");
                        Console.Write("Masukkan alas segitiga : ");
                        float a = float.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi Segitiga : ");
                        float t = float.Parse(Console.ReadLine());
                        hipotenusa = (float)Convert.ToDouble(Math.Sqrt((a * a) + (t * t)));
                        Console.WriteLine("Hipotenusa dari segitiga adalah : ");
                        System.Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Menghitung Keliling segitiga");
                        Console.Write("Masukkan Siku siku : ");         float a = float.Parse(Console.ReadLine());
                        Console.Write("Masukkan Tinggi Segitiga : ");   float t = float.Parse(Console.ReadLine());
                        float keliling = hipotenusa = (float)Convert.ToDouble(Math.Sqrt((a * a) + (t * t))) + a + t;
                        Console.WriteLine("Luas Segitiga dengan alas {0} dan tinggi {1} adalah {2} cm ", a, t, keliling);
                        System.Console.ReadKey();
                        break;
                    }
                case 4:
                    {
                        Environment.Exit(0);
                        break;
                    }
            }
        }
    }
}
