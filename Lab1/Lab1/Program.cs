using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab1
{
    class Program
    {

        public bool isPrim = true;
        public bool gasit = false;

        static void Main(string[] args)
        {
            Program a = new Program();
            Thread thread1 = new Thread(() => a.NrPrim1(100));
            thread1.Name = "Thread One";
            thread1.Start();
            Console.WriteLine("Start fir: " + Thread.CurrentThread.Name);
            
            
            a.isPrim = true;
            a.gasit = false;
            Thread thread2 = new Thread(() => a.NrPrim2(100));
            
            Console.Read();
        }

        public int NrPrim1(int number)
        {
            int nrPrim = 0;

            for (int i = number - 1; i >= 1 && !gasit; i--)
            {
                //Console.WriteLine(i);
                for (int j = 2; j < i && isPrim; j++)
                    if (i % j == 0) 
                        isPrim = false;
                
                if (isPrim)
                {
                    gasit = true;
                    nrPrim = i;
                }
                else
                {
                    isPrim = true;
                }
            }
            
            return nrPrim;
        }

        public int NrPrim2(int number)
        {
            int nrPrim = 0;

            for (int i = number - 1; i >= 1 && !gasit; i--)
            {
                for (int j = 2; j < i/2 && isPrim; j++)
                    if (i % j == 0) isPrim = false;
                if (isPrim)
                {
                    gasit = true;
                    nrPrim = i;
                }
                else
                {
                    isPrim = true;
                }
            }

            return nrPrim;
        }
    }
}
