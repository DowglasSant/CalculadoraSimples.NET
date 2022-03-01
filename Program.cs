using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes operacoes = new Operacoes();

            while (true)
            {
                operacoes.Menu();
            }
        }
    }
}
