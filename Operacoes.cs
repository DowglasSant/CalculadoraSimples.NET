namespace Calculator
{
    public class Operacoes
    {
        public void Menu()
        {
            Console.Clear();

            Console.WriteLine("Qual operação deseja utilizar?");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5- Sair");

            Console.WriteLine("---------------------");
            Console.WriteLine("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Somar();
                    break;

                case 2:
                    Subtrair();
                    break;

                case 3:
                    Multiplicar();
                    break;

                case 4:
                    Dividir();
                    break;

                case 5:
                    Console.WriteLine("Programa Encerrado.");
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opção Inválida.");
                    Console.ReadKey();
                    break;
            }

        }
        public void Somar()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da soma é: {valor1 + valor2}");
            Console.ReadKey();
        }

        public void Subtrair()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da subtração é: {valor1 - valor2}");
            Console.ReadKey();
        }

        public void Multiplicar()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da multiplicação é: {valor1 * valor2}");
            Console.ReadKey();
        }

        public void Dividir()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"O resultado da divisão é: {valor1 / valor2}");
            Console.ReadKey();
        }
    }
}