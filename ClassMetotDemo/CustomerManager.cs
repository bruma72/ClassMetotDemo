using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(customer.CustomerName + " adlı müşteri sisteme eklendi."  );
            Console.WriteLine("-------------------------------------------------------");

        }

        public void List(Customer customer)

        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Müşteri İD: " + customer.CustomerId);
            Console.WriteLine("Müşteri Adı: " + customer.CustomerName);
            Console.WriteLine("Müşteri Soyadı: " + customer.CustomerSurname);
            Console.WriteLine("Müşteri Şehir: " + customer.CustomerCity);
            

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine(customer.CustomerName+"   " + customer.CustomerSurname + "   " + "Müşteri bilgisi silindi." );
            Console.WriteLine("-------------------------------------------------------");


        }


    }
}
