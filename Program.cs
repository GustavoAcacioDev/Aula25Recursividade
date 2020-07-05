using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            //fibo.GerarSequenciaFibonnaci(0,1,15);
            //Console.WriteLine(fibo.GerarFatorial(3));
            

            fibo.GerarSequenciaTribonnaci(1,1,2,10);


        }
    }
}
