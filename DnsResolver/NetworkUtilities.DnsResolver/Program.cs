using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtilities.DnsResolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DNS Resolver.");
            Console.WriteLine("Write a DNS Name: ");
            var stringDnsName = Console.ReadLine();
            try
            {
                var addresses = System.Net.Dns.GetHostAddresses(stringDnsName);
                Console.WriteLine($"Direcciones encontradas para {stringDnsName}");
                Console.WriteLine(); 

                foreach (var address in addresses)
                {
                    Console.WriteLine($"{address.ToString()}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nPrograma finalizado. Presione Enter para finalizar. ");
                Console.ReadLine();
            }
        }
    }
}
