using System;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Engin Arslan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Cahit Arslan";

            bool result3 = sentence.EndsWith("n");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("namee"); //Bulunduğu index'i döner -> Yoksa -1 döner
            var result6 = sentence.IndexOf(" "); //2.index

            var result7 = sentence.LastIndexOf(" "); //Aramaya sondan başlar --> 16.index

            var result8 = sentence.Insert(0, "Hello, ");

            var result9 = sentence.Substring(3, 4); //name

            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();

            var result12 = sentence.Replace(" ", "-");

            var result13 = sentence.Remove(2, 5); //My is Cahit Arslan

            Console.WriteLine(result13);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
