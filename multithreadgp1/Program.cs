using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace multithreadgp1
{
    internal class Program
    {
        static void Main(string[]args)
    
         {
            Console.WriteLine("Main Thread Started");

            Thread uno = new Thread(one)
            {
                Name = "Thread 1"
            };
        Thread dos = new Thread(two)
        {
            Name = "Thread 2"
        };
        Thread tres = new Thread(three)
        {
            Name = "Thread 3"
        };

        uno.Start();
            dos.Start();
            tres.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }
    static void one()
    {
        Console.WriteLine("Started " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);

        }
        Console.WriteLine("Ended " + Thread.CurrentThread.Name);
    }
    static void two()
    {
        Console.WriteLine("Started " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 50; i+= 15)
        {
            Console.WriteLine(i);
            if (i == 3)
            {

            }
        }
        Console.WriteLine("Ended " + Thread.CurrentThread.Name);
    }
    static void three()
    {
        Console.WriteLine("Started " + Thread.CurrentThread.Name);
        for (int i = 1; i <= 100; i += 19)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Ended " + Thread.CurrentThread.Name);
    }
}
}