using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{

    public delegate void CounterDelegete(int limit);
    class SuperCounter
    {

        private CounterDelegete count;

        public SuperCounter()
        {

            count = delegate (int limit)
            {
                for (int i = 1; i <= limit; i++)
                {
                    Console.Write($" {i}");
                }

            };

        }

        public SuperCounter(CounterDelegete count)
        {
            this.count = count;
        }

        public void Set_algo(CounterDelegete count)
        {
            this.count = count;
        }

        public void Calculate(int limit)
        {
            count.Invoke(limit);
        }

    }





    class Program
    {
        static void Main(string[] args)
        {



            void Factorial(int limit)
            {
                for (int i = 1; i < limit; i++)
                {
                    Console.Write(Fact(i) + " ");
                }
            }

            int Fact(int x)
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Fact(x - 1);
                }
            }

            void Fibanachi(int limit)
            {
                int fibon = 1;
                int fibon1 = 1;
                int fibon2 = 0;

                while (fibon <= limit)
                {
                    Console.Write(" " + fibon1);
                    fibon1 = fibon2 + fibon;
                    fibon2 = fibon;
                    fibon = fibon1;

                }
            }

            void Stepen(int limit)
            {
                int number=2;

                for (int i = 1; i < limit; i++)
                {
                    
                     Console.Write(Math.Pow(number,i) + " ");
                   
                }
            }


            SuperCounter counter = new SuperCounter();

            counter.Set_algo(Stepen);

            counter.Calculate(10);
        }
    }
}
