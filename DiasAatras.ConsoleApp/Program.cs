using System;

namespace DiasAatras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataInformada;
            bool dataValida;

            do
            {
                dataValida = false;

                Console.Write("\nInforme uma data: ");

                dataValida = DateTime.TryParse(Console.ReadLine(), out dataInformada);

            } while (dataValida == false);

            string mensagemFinal = "", anoTexto = "", mesTexto = "", semanaTexto = "", diaTexto = "", horaTexto = "", minutoTexto = "", segundoTexto = "";

            DateTime hoje = DateTime.Today;

            TimeSpan diferenca = new TimeSpan();

            diferenca = hoje - dataInformada;

            int segundos, minutos, horas, dias, semanas, meses, anos, resto;

            dias = diferenca.Days;

            semanas = dias / 7;

            meses = dias / 30;

            anos = dias / 365;

            //Verificar se o período é maior que um ano
            if (anos > 0)
            {
                if (anos == 1)
                    anoTexto += anos + " ano";
                else if (anos > 1)
                    anoTexto += anos + " anos";
                int diferencaDias = dias - (anos * 365);
                resto = diferencaDias / 12;
                if (resto > 0)
                    meses = diferencaDias;
            }

            //Verificar se o período é maior que um mês
            if (meses > 0)
            {
                if (meses == 1)
                    mesTexto += meses + " mês ";
                else if (meses > 1)
                    mesTexto += meses + " meses ";
                int diferencaDias = dias - (meses * 30);
                resto = diferencaDias / 4;
                if (resto > 0)
                    semanas = diferencaDias;
            }

            //Verificar se o período é maior que uma semana
            if (semanas > 0)
            {
                if (semanas == 1)
                    semanaTexto += semanas + " semana ";
                else if (semanas > 1)
                    semanaTexto += semanas + " semanas ";
                int diferencaDias = dias - (semanas * 7);
                resto = diferencaDias / 7;
                if (resto > 0)
                    dias = diferencaDias;
            }

            //Verificar se o período é maior que um dia
            if (dias > 0)
            {
                if (dias == 1)
                    diaTexto += dias + " dia ";
                else if (dias > 1)
                    diaTexto += dias + " dias ";

            }

            mensagemFinal = anoTexto + mesTexto + semanaTexto + diaTexto + "atrás";

            Console.WriteLine(mensagemFinal);

        }
    }
}
