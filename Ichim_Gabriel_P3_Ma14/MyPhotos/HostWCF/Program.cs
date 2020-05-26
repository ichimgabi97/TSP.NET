using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using MyphotoWCF;

namespace HostWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lansare server WCF...");
            ServiceHost host = new ServiceHost(typeof(API), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints) {
                Console.WriteLine("address: " + se.Address);
                Console.WriteLine("binding: " + se.Binding.Name);
                Console.WriteLine("Contract: " + se.Contract.Name);
            }
            host.Open();
            Console.WriteLine("Server in executie. Se asteapta conexiuni...");
            Console.WriteLine("Apasati Enter pentru a opri serverul!");
            Console.ReadKey();
            host.Close();
        }
    }
}