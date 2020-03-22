using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFist_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            TestPerson();
            TesTOneToMany();
            Console.ReadKey();
        }
        static void TestPerson()
        {
            using (Model1Container context = new Model1Container())
            {
                string firstName;
                string midleName;
                string lastName;
                string phoneNumber;

                Console.Write("Enter first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter midle name: ");
                midleName = Console.ReadLine();
                Console.Write("Enter last name: ");
                lastName = Console.ReadLine();
                Console.Write("Enter phone number: ");
                phoneNumber = Console.ReadLine();


                Person p = new Person()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    MidleName = midleName,
                    TelephonNumber = phoneNumber
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }

        static void TesTOneToMany()
        {
            Console.WriteLine("One to many association");
            using (ModelOneTomanyContainer context = new ModelOneTomanyContainer())
            {

                String name;
                String city;
                Decimal totalValue;

                Console.Write("Enter name: ");
                name = Console.ReadLine();
                Console.Write("Enter city: ");
                city = Console.ReadLine();
                Console.Write("Enter totalValue: ");
                totalValue = Convert.ToDecimal(Console.ReadLine());

                Customer c = new Customer()
                {
                    Name = name,
                    City = city
                };
                Orders o1 = new Orders()
                {
                    TotalValue = totalValue,
                    Date = DateTime.Now,
                    Customer = c
                };
                Orders o2 = new Orders()
                {
                    TotalValue = totalValue + 100,
                    Date = DateTime.Now,
                    Customer = c
                };
                context.Customers.Add(c);
                context.Orders.Add(o1);
                context.Orders.Add(o2);
                context.SaveChanges();
                var items = context.Customers;
                foreach (var x in items)
                {
                    Console.WriteLine("Customer : {0}, {1}, {2}",
                   x.CustomerId, x.Name, x.City);
                    foreach (var ox in x.Orders)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}",
                       ox.OrderId, ox.Date, ox.TotalValue);
                }
            }
        }


    }
}
