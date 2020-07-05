using System;

namespace Aula25Recursividade
{
    public class Fibonacci
    {
        //Gerar uma sequencia Fibonnaci a partir de um valor, um intervalo específico e quantidade de repetições
        public void GerarSequenciaFibonnaci(int numero1, int numero2, int vezes)
        {
            //Condição obriatória pra quebrar a recursividade do método
            if(vezes > 0){
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(numero1);
                GerarSequenciaFibonnaci(numero2, numero1 + numero2, vezes - 1);
                Console.ResetColor();
            }
        }


        public void GerarSequenciaTribonnaci(int numero1, int numero2, int numero3, int vezes){
            if(vezes > 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(numero1);
                GerarSequenciaTribonnaci(numero2, numero3, numero1 + numero2 + numero3, vezes - 1);
                Console.ResetColor();
            }
        }


        public int GerarFatorial(int numero){

            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }


    }
}