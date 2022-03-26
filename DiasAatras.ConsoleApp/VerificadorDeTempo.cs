using System;

namespace DiasAatras.ConsoleApp
{
    public class VerificadorDeTempo
    {
        public DateTime dataInputada;
        public DateTime agora = DateTime.Now;
        public TimeSpan periodoDeTempo;
        private DateTime dataAuxiliar;

        private void CalcularPeriodoDeTempo()
        {
            periodoDeTempo = agora - dataAuxiliar;
        }

        public int CalcularAnos()
        {
            dataAuxiliar = dataInputada;

            CalcularPeriodoDeTempo();

            int qtdDeAnos = RetornaAhQuantidadeDeAnos();

            return qtdDeAnos;
        }

        public int CalcularMeses()
        {
            int anos = CalcularAnos();

            dataAuxiliar = dataInputada;

            if (anos > 0)
                dataAuxiliar.AddYears(anos);

            int quantidadeDeMeses = RetornaAhQuantidadeDeMeses();

            return quantidadeDeMeses;

        }


        public int RetornaAhQuantidadeDeAnosBissextos()
        {
            DateTime dataTemp = dataInputada;

            int quantidadeDeAnosBissextos = 0;

            while (dataTemp.Year != agora.Year)
            {
                if (DateTime.IsLeapYear(dataTemp.Year))
                    quantidadeDeAnosBissextos++;

                dataTemp.AddYears(1);

            }

            return quantidadeDeAnosBissextos;
        }

        public int RetornaAhQuantidadeDeMeses()
        {
            CalcularPeriodoDeTempo();

            int quantidadeDeMeses = 0;

            DateTime dataTemp = dataAuxiliar;

            bool anosIguais = false, mesesIguais = false, mesAgoraMaior = false;

            while (!anosIguais && !mesesIguais)
            {
                if (dataTemp.Year == agora.Year)
                {
                    anosIguais = true;

                    if(dataTemp.Month < agora.Year)

                    while (!mesesIguais)
                    {

                    }
                }
                dataTemp = dataTemp.AddMonths(1);
            }

            return quantidadeDeMeses;
        }


        public int RetornaAhQuantidadeDeAnos()
        {
            DateTime dataTemp = dataInputada;

            int quantidadeDeAnos = 0;

            while (dataTemp.Year < agora.Year)
            {
                dataTemp = dataTemp.AddYears(1);

                if (dataTemp.Year == agora.Year)
                {
                    if (dataTemp.Month < agora.Month)
                    {
                        quantidadeDeAnos++;
                    }
                    else if (dataTemp.Month == agora.Month)
                    {
                        if (dataTemp.Day <= agora.Day)
                        {
                            quantidadeDeAnos++;
                        }
                    }
                }
                else if (dataTemp.Year <= agora.Year)
                    quantidadeDeAnos++;

            }

            return quantidadeDeAnos;
        }
    }
}
