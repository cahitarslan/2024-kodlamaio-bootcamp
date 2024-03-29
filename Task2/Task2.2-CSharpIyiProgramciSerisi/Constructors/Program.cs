﻿namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Id = 1;
            //customer1.FirstName = "Engin";
            //customer1.LastName = "Demiroğ";
            //customer1.City = "Ankara";
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };

            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
