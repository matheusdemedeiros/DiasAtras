using System;

namespace DiasAatras.ConsoleApp
{
    public class VerificadorDeTempo
    {
        public DateTime dataInputada;
        public DateTime agora = DateTime.Now;
        public TimeSpan periodoDeTempo;
        public double ano, mes, semana, contDias;

        private double CalcularPeriodoDeTempo()
        {
            periodoDeTempo = agora - dataInputada;

            double dias = periodoDeTempo.Days;

            return dias;
        }

        public void CalcularTempo()
        {
            double dia = CalcularPeriodoDeTempo();

            string resultado = "";

            if (dia == 0)
            {
                periodoDeTempo = agora - DateTime.UtcNow.AddHours(3);

                resultado = periodoDeTempo.ToString();

                Console.WriteLine(resultado + " hora(s) atras!");

                Console.ReadLine();

                return;
            }
            while (dia > 0)
            {
                if (dia > 365)
                {
                    ano++;

                    dia = dia - 365;

                }
                else if (dia > 30)
                {
                    mes++;

                    dia = dia - 30;
                }
                else if (dia > 7)
                {
                    semana++;

                    dia = dia - 7;
                }

                else if (dia > 0)
                {
                    contDias++;

                    dia = dia - 1;
                }
            }
            if (ano > 0)
            {
                resultado = ConversaoNumero(ano) + " anos atras!";
                if (mes > 0)
                {
                    resultado = ConversaoNumero(ano) + " anos e " + ConversaoNumero(mes) + " mes(es) atras!";
                }

            }
            else if (mes > 0)
            {
                resultado = ConversaoNumero(mes) + " mes(es) atras!";
                if (semana > 0)
                {
                    resultado = ConversaoNumero(mes) + " mes(es) e " + ConversaoNumero(mes) + " semana(s) atras!";
                }

            }
            else if (semana > 0)
            {
                resultado = ConversaoNumero(semana)+ " semana(s) atras!";
                if (semana > 0)
                {
                    resultado = ConversaoNumero(semana) + " semana(s) e " + ConversaoNumero(dia) + " dia(s) atras!";
                }

            }
            else if (contDias > 0)
            {
                resultado = ConversaoNumero(contDias) + " dia(s) atras!";

            }
            Console.WriteLine(resultado);
        }

        public string ConversaoNumero(double valor)
        {

            string retorno = "";

            if (valor == 0)
            {
                retorno = "Zero";

            }
            else if (valor == 1)
            {
                retorno = "Um";

            }
            else if (valor == 2)
            {
                retorno = "Dois";

            }
            else if (valor == 3)
            {
                retorno = "Três";

            }
            else if (valor == 4)
            {
                retorno = "Quatro";

            }
            else if (valor == 5)
            {
                retorno = "Cinco";

            }
            else if (valor == 6)
            {
                retorno = "Seis";

            }
            else if (valor == 7)
            {
                retorno = "Sete";

            }
            else if (valor == 8)
            {
                retorno = "Oito";

            }
            else if (valor == 9)
            {
                retorno = "Nove";

            }

            return retorno;
        }

        //public int CalcularAnos()
        //{
        //    dataAuxiliar = dataInputada;

        //    CalcularPeriodoDeTempo();

        //    int qtdDeAnos = RetornaAhQuantidadeDeAnos();

        //    return qtdDeAnos;
        //}

        //public int CalcularMeses()
        //{
        //    int anos = CalcularAnos();

        //    dataAuxiliar = dataInputada;

        //    if (anos > 0)
        //        dataAuxiliar.AddYears(anos);

        //    int quantidadeDeMeses = RetornaAhQuantidadeDeMeses();

        //    return quantidadeDeMeses;

        //}


        //public int RetornaAhQuantidadeDeAnosBissextos()
        //{
        //    DateTime dataTemp = dataInputada;

        //    int quantidadeDeAnosBissextos = 0;

        //    while (dataTemp.Year != agora.Year)
        //    {
        //        if (DateTime.IsLeapYear(dataTemp.Year))
        //            quantidadeDeAnosBissextos++;

        //        dataTemp.AddYears(1);

        //    }

        //    return quantidadeDeAnosBissextos;
        //}

        //public int RetornaAhQuantidadeDeMeses()
        //{
        //    CalcularPeriodoDeTempo();

        //    int quantidadeDeMeses = 0;

        //    DateTime dataTemp = dataAuxiliar;

        //    bool anosIguais = false, mesesIguais = false, mesAgoraMaior = false;

        //    while (!anosIguais && !mesesIguais)
        //    {
        //        if (dataTemp.Year == agora.Year)
        //        {
        //            anosIguais = true;

        //            if (dataTemp.Month < agora.Year)

        //                while (!mesesIguais)
        //                {

        //                }
        //        }
        //        dataTemp = dataTemp.AddMonths(1);
        //    }

        //    return quantidadeDeMeses;
        //}


        //public int RetornaAhQuantidadeDeAnos()
        //{
        //    DateTime dataTemp = dataInputada;

        //    int quantidadeDeAnos = 0;

        //    while (dataTemp.Year < agora.Year)
        //    {
        //        dataTemp = dataTemp.AddYears(1);

        //        if (dataTemp.Year == agora.Year)
        //        {
        //            if (dataTemp.Month < agora.Month)
        //            {
        //                quantidadeDeAnos++;
        //            }
        //            else if (dataTemp.Month == agora.Month)
        //            {
        //                if (dataTemp.Day <= agora.Day)
        //                {
        //                    quantidadeDeAnos++;
        //                }
        //            }
        //        }
        //        else if (dataTemp.Year <= agora.Year)
        //            quantidadeDeAnos++;

        //    }

        //    return quantidadeDeAnos;
        //}
    }
}
