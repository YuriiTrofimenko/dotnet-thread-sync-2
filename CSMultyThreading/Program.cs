﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultyThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Data shareData = new Data();
            Thread t1 = new Thread(new Controller() {data = shareData }.increase);
            Thread t2 = new Thread(new Controller() { data = shareData }.increase);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();

            Console.WriteLine(shareData.count);
            //Thread.Sleep(1000);
        }
    }
}
