using IotTesting_1.Models;
using System;

namespace DeviceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var device = new DeviceClientService("HostName=Uppgift3.azure-devices.net;DeviceId=DeviceApp;SharedAccessKey=5zdg12x2b5Kx0OQBpNfRs28ERLoKLkoOSw7aJa6ietQ=");
           
            DeviceClientService.SendMessageAsync().GetAwaiter();
            Console.ReadKey();
        }
    }
}
