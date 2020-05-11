using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "Transports.csv";

            Trolleybus trolleybus = new Trolleybus();
            trolleybus.Type = "Trolleybus";
            trolleybus.ReleaseYear = 2018;
            trolleybus.RegistrationNumber = "n8ji52";
            trolleybus.RouteNumber = 478;
            trolleybus.Mileage = 59;

            TransportCollection<Transport> transports;

            try
            {
                transports = new TransportCollection<Transport>(FileExtensions.FileExtensions.GetTransports(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            foreach (var transport in transports.Transports)
            {
                Console.WriteLine(transport);
            }

            Console.WriteLine("___________________________________________________________________");

            transports.Sort();
            transports.Add(trolleybus);

            foreach (var transport in transports.Transports)
            {
                Console.WriteLine(transport);
            }

            Console.WriteLine("___________________________________________________________________");

            foreach (var transport in transports.GetTrolleybus(52, 78))
            {
                Console.WriteLine(transport);
            }
        }
    }
}
