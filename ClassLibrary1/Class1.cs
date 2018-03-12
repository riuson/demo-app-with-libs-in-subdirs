using System;
using System.Threading;

namespace ClassLibrary1
{
    public class Class1
    {
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }
}
