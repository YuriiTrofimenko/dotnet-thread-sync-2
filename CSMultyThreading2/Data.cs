using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMultyThreading2
{
    class Data
    {
        private int state = 1;

        public void SayHello() {
            Console.Write("Hello ");
            state = 2;
        }

        public void SayWorld()
        {
            Console.WriteLine("World");
            state = 1;
        }

        public int GetState() {
            return state;
        }
    }
}
