using Adapters;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new Vatandas();

            SelamVer("Cahit");
            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer();

            int sonuc = Topla(6, 58);

            // Arrays
            string ogrenci1 = "Cahit";
            string ogrenci2 = "Engin";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = ogrenci1;
            ogrenciler[1] = ogrenci2;
            ogrenciler[2] = ogrenci3;

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;

            Console.WriteLine(sayi2);

            Vatandas vatandas1 = new Vatandas();
            vatandas1.Ad = "Cahit";

            Vatandas vatandas2 = new Vatandas();
            vatandas2.Ad = "Engin";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            MyList<int> numbers = new MyList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }



            // MERNIS Test ---------------------------------------------------------

            Person person = new Person();
            person.FirstName = "CAHİT";
            person.LastName = "ARSLAN";
            person.DateOfBirth = new DateTime(1993, 11, 23);
            person.NationalIdentity = "12345678910";

            //PttManager pttManager = new PttManager(new PersonCheckManager()); -> For test
            PttManager pttManager = new PttManager(new MernisServiceAdapter());
            pttManager.GiveMask(person);
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Cahit";
            string soyad = "Arslan";
            int dogumYili = 1993;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);
        }

        private static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        private static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

    public class MyList<T>
    {
        private T[] _items;
        private int _count;
        private const int _defaultCapacity = 4;

        public MyList()
        {
            _items = new T[_defaultCapacity];
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                IncreaseCapacity();
            }
            _items[_count++] = item;
        }

        private void IncreaseCapacity()
        {
            int newCapacity = _items.Length == 0 ? _defaultCapacity : _items.Length * 2;
            T[] newArray = new T[newCapacity];
            _items.CopyTo(newArray, 0);
            _items = newArray;
        }

        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }

        public int Count => _count;

        public int Capacity => _items.Length;
    }
}