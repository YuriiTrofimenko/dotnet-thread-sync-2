using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultyThreading2
{
    class Controller
    {
        public Data data;
        public int id;
        public void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Enter(data);
                if (id == data.GetState())
                {
                    if (id == 1)
                    {
                        data.SayHello();
                    }
                    else
                    {
                        data.SayWorld();
                    }
                }
                Monitor.Exit(data);
            }
        }
    }
}
