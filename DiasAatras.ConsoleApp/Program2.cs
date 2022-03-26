using System;

namespace DiasAatras.ConsoleApp
{
    internal class Program2
    {
        static void Main2(string[] args)
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

            int segundos, minutos, horas, diasDiferenca, semanas, meses, anos, dias, resto;

            diasDiferenca = diferenca.Days;

            semanas = diasDiferenca / 7;

            meses = diasDiferenca / 30;

            anos = diasDiferenca / 365;


            //Verificar se o período é maior que um ano
            if (anos > 0)
            {
                if (anos == 1)
                    anoTexto += anos + " ano";
                else if (anos > 1)
                    anoTexto += anos + " anos";

                anos = diasDiferenca / 365;
                resto = diasDiferenca % 365;
                if (resto > 0)
                    meses = resto;
            }

            //Verificar se o período é maior que um mês
            if (meses > 0)
            {
                if (meses == 1)
                    mesTexto += meses + " mês ";
                else if (meses > 1)
                    mesTexto += meses + " meses ";
                resto = meses % 30;
                if (resto > 0)
                    semanas = resto;
            }

            //Verificar se o período é maior que uma semana
            if (semanas > 0)
            {
                if (semanas == 1)
                    semanaTexto += semanas + " semana ";
                else if (semanas > 1)
                    semanaTexto += semanas + " semanas ";
                resto = semanas % 7;
                if (resto > 0)
                    diasDiferenca = resto;
            }

            //Verificar se o período é maior que um dia
            if (diasDiferenca > 0)
            {
                if (diasDiferenca == 1)
                    diaTexto += diasDiferenca + " dia ";
                else if (diasDiferenca > 1)
                    diaTexto += diasDiferenca + " dias ";
            
            }

            mensagemFinal = anoTexto + mesTexto + semanaTexto + diaTexto + "atrás";

            Console.WriteLine(mensagemFinal);

        }
    }
}
