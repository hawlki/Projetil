using System;

namespace projetil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("----------------------------");
            Console.WriteLine("          Projétil          ");
            Console.WriteLine("----------------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Escreva um valor para a velocidade em (m/s): ");
            String velocidade = Console.ReadLine();
            Console.Write("Escreva o valor de um ângulo em graus: ");
            String angulog = Console.ReadLine(); //angulog: ângulo em graus
            Console.WriteLine();

            const double g = 9.80665;
            Double v = Convert.ToDouble(velocidade);
            Double a = Convert.ToDouble(angulog);
            Double ar = a * (Math.PI / 180); //ar: ângulo em radianos
            Double alcance = (Math.Pow(v, 2) * Math.Sin(2 * ar)) / g;
            Double altura = Math.Pow((v * Math.Sin(ar)), 2) / (2 * g);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"O alcance é {alcance} m");
            Console.WriteLine($"A altura é {altura} m");
            Console.WriteLine();

            Console.ResetColor();
            Console.WriteLine("Toque em uma tecla para finalizar o programa");
            Console.ReadKey();

            Console.Clear();
        }
    }
}
