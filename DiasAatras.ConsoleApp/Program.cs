using System;

namespace DiasAatras.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            VerificadorDeTempo verificador = new VerificadorDeTempo();

            bool dataValida;
            while (true)
            {
                do
                {
                    dataValida = false;

                    Console.Write("\nInforme uma data: ");

                    dataValida = DateTime.TryParse(Console.ReadLine(), out verificador.dataInputada);

                } while (dataValida == false);

                verificador.CalcularTempo();
            }
        }
    }
}

