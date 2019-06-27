using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultyThreading
{
    class Controller
    {
        public Data data;
        public void increase()
        {
            for (int i = 0; i < 500000; i++)
            {
                Monitor.Enter(data);
                int count = data.count;

                //Thread.Sleep(10);
                count++;

                //Thread.Sleep(10);
                data.count = count;
                Monitor.Exit(data);
            }

            // Parallel.Invoke(() => { Console.WriteLine("Hello "); }, () => { Console.WriteLine("World"); });

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
        }
    }
}
