using IotTesting_1.Models;
using System;
using System.Threading.Tasks;

namespace IoT_Testing_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new ServiceClientService("HostName=Uppgift3.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=7wIVTaZwXFEk8T3lCVBpWE5FN1xlqnp7I9m2CPetOYc=");
         
            Console.ReadKey();
        }
    }
}
