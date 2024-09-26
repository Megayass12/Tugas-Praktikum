using System;
using TugasPr;

namespace TugasPr
{
    public class Hewan
    {
        public string Nama;
        public int Umur;

        public Hewan(string nama, int umur)
        {
            Nama = nama;
            Umur = umur;
        }

        public virtual void CetakInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Umur: {Umur}");
        }
    }

    public class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.jumlahKaki = jumlahKaki;  
        }

        public override void CetakInfo()  
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Umur: {Umur}");
            Console.WriteLine($"Banyak kaki: {jumlahKaki}");
        }
    }

    public class Reptil : Hewan
    {
        public int panjangTubuh;

        public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
        {
            this.panjangTubuh = panjangTubuh;
        }

        public override void CetakInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Umur: {Umur}");
            Console.WriteLine($"Panjang tubuh: {panjangTubuh}");
        }
    }

}