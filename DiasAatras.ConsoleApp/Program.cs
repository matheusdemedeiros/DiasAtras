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


                Console.Write("\nA quantidade de anos entre as datas é: {0}\n", verificador.CalcularAnos());
                
                Console.Write("\nA quantidade de meses entre as datas é: {0}\n", verificador.CalcularMeses());
            }
        }
    }
}

