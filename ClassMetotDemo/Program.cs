using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "İsmail";
            customer1.CustomerSurname = "Moneymaker";
            customer1.CustomerCity = "Diyarbakır";

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Michael";
            customer2.CustomerSurname = "Scofield";
            customer2.CustomerCity = "Fox River";

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerName = "Elon ";
            customer3.CustomerSurname = "Musk";
            customer3.CustomerCity = "Mars";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var x in customers)
            {
                
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Müşteri İD : " + x.CustomerId);
                Console.WriteLine("Müşteri isim : " + x.CustomerName);
                Console.WriteLine("Müşteri soyisim : "+ x.CustomerSurname);
                Console.WriteLine("Müşteri şehir : "+ x.CustomerCity);
                Console.WriteLine("-------------------------------------------------------");
                
            }


            Console.WriteLine("Müşteriler Ekleniyor...");
            Console.WriteLine("-------------------------------------------------------");
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Müşteriler Listeleniyor...");
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Müşteri Siliniyor...");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");






        }
    }
}
