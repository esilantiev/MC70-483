using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        } 
        static void Main(string[] args)
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(()=>ThreadMethod(5)));

            t.IsBackground = true;
            t.Start();          
            
            t.Join();
        }
    }
}
