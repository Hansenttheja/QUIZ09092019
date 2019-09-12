using System;

namespace QUIZ09092019{
    class BangunDatar
    {
        public void luas_persegi(int sisi)
        {

            Console.WriteLine("luas Persegi adalah : " + sisi*sisi);

        }
        public int luas_segitiga(int alas, int tinggi){
            return alas * tinggi / 2;
        }

        public void luas_lingkaran(int r){
            Console.WriteLine("LUas Lingkaran Adalah " + 3.14 * r * r);
        }
    }
}