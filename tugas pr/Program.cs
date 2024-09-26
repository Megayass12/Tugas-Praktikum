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

        public virtual string Suara()
        {
            return "Hewan ini bersuara";
        }

        public virtual string InfoHewan()
        {
            return $"Nama: {Nama}, Umur: {Umur}";
        }
    }

    public class Mamalia : Hewan
    {
        public int jumlahKaki;

        public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
        {
            this.jumlahKaki = jumlahKaki;
        }

        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Jumlah Kaki: {jumlahKaki}";
        }
    }

    public class Reptil : Hewan
    {
        public int panjangTubuh;

        public Reptil(string nama, int umur, int panjangTubuh) : base(nama, umur)
        {
            this.panjangTubuh = panjangTubuh;
        }

        public override string InfoHewan()
        {
            return base.InfoHewan() + $", Panjang Tubuh: {panjangTubuh}";
        }
    }

    public class Singa : Mamalia
    {
        public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

        public override string Suara()
        {
            return "Suara singa mengaum wrauwhm!";
        }

        public void Mengaum()
        {
            Console.WriteLine("Singa ini sedang mengaum!");
        }
    }

    public class Gajah : Mamalia
    {
        public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

        public override string Suara()
        {
            return "Suara Gajah wreeeeekkkkkk!";
        }
    }

    public class Ular : Reptil
    {
        public Ular(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh) { }

        public override string Suara()
        {
            return "Suara ular mendesis Sssstttstttttt!";
        }

        public void Merayap()
        {
            Console.WriteLine("Ularnya merayap weeeee!");
        }
    }

    public class Buaya : Reptil
    {
        public Buaya(string nama, int umur, int panjangTubuh) : base(nama, umur, panjangTubuh) { }

        public override string Suara()
        {
            return "Buaya mengaum!";
        }
    }

    public class KebunBinatang
    {
        public List<Hewan> koleksiHewan;

        public KebunBinatang()
        {
            koleksiHewan = new List<Hewan>();
        }

        public void TambahHewan(Hewan hewan)
        {
            koleksiHewan.Add(hewan);
        }

        public void DaftarHewan()
        {
            for (int i = 0; i < koleksiHewan.Count; i++)
            {
                Console.WriteLine(koleksiHewan[i].InfoHewan());
                Console.WriteLine(koleksiHewan[i].Suara());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KebunBinatang kebun = new KebunBinatang();

            Singa singa = new Singa("Simba", 5, 4);
            //Console.WriteLine(singa.InfoHewan());
            Gajah gajah = new Gajah("Sumatera", 10, 4);
            Ular ular = new Ular("Naga", 3, 2);
            Buaya buaya = new Buaya("Aligator", 6, 3);

            //Reptil reptil = new Buaya("Buaya darat", 6, 3);
            //Console.WriteLine(reptil.InfoHewan());
            //Console.WriteLine(reptil.Suara());


            kebun.TambahHewan(singa);
            kebun.TambahHewan(gajah);
            kebun.TambahHewan(ular);
            kebun.TambahHewan(buaya);

            Console.WriteLine("Daftar hewan di Kebun Binatang:");
            kebun.DaftarHewan();

            Console.WriteLine("\nDemonstrasi Polymorphism:");
            Hewan[] beberapaHewan = { singa, gajah, ular };
            for (int i = 0; i < beberapaHewan.Length; i++)
            {
                Console.WriteLine(beberapaHewan[i].Suara());
            }

            Console.WriteLine("\nMethod Khusus:");
            singa.Mengaum();
            ular.Merayap();
        }
    }
}
