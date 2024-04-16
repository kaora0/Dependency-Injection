using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace LabAAA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddTransient<IMessageService, GreetingService>()
            //.AddTransient<IMessageService, AlternateMessageService>()
            .BuildServiceProvider();

            var messageService = serviceProvider.GetRequiredService<IMessageService>();
            messageService.PrintMessage();
        }
    }
    public interface IMessageService
    {
        void PrintMessage();
    }

    public class GreetingService : IMessageService
    {
        public void PrintMessage()
        {
            Console.WriteLine("Здравия желаю!");
        }
    }

    public class AlternateMessageService : IMessageService
    {
        public void PrintMessage()
        {
            Console.WriteLine("Как жизнь, товарищ?");
        }
    }
}
