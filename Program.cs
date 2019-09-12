using System;

namespace QUIZ09092019
{
    class Program
    {
        public static void Main(string[] args)
        {
           BangunDatar obj=new BangunDatar();

            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("...........................");

            int s;
            Console.WriteLine("Masukkan Nilai Sisi");
            s=Convert.ToInt32(Console.ReadLine());

           obj.luas_persegi(s); 

           Console.WriteLine("Menghitung Luas Segitiga");
           Console.WriteLine("..........................");

           int a1,a2;

           Console.WriteLine("Masukkan Nilai Tinggi");
           a1=Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Masukkan Nilai Alas");
           a2=Convert.ToInt32(Console.ReadLine());

          Console.WriteLine("Nilai Luas Segitiga adalah "+ obj.luas_segitiga(a1,a2)); 

          Console.WriteLine("Menghitung Luas Lingkaran");
          Console.WriteLine(".......................");

          int r1;

          Console.WriteLine("Masukkan Nilai Jari-jari");
          r1=Convert.ToInt32(Console.ReadLine());

          obj.luas_lingkaran(r1);


          BangunRuang ruang=new BangunRuang();

          Console.WriteLine("Menghitung Volume Balok");
          Console.WriteLine("========================");
        int p , l ,t ;
        Console.WriteLine("Masukkan Nilai panjang ");
        p=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan Nilai lebar ");
        l=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Masukkan Nilai tinggi");
        t=Convert.ToInt32(Console.ReadLine());

        ruang.Volume_balok(p,l,t);
        
        Console.WriteLine("Menghitung Volume Balok");
        Console.WriteLine(".........................");

        int s1;
        Console.WriteLine("Masukkan sisi ");
        s1=Convert.ToInt32(Console.ReadLine());

        ruang.volume_kubus(s1);
        
        }
    }
}
