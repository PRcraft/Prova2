using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string extenso = null;
            int codigo, dia, ano, mes;
            string dataatual;
            Console.WriteLine("1 – Atibaia 2 – Bragança Paulista 3 – Mairiporã 4 – Nazaré 5 – Terra Preta 6 – Extrema 7 – Vargem ");
            Console.Write("Digite o código da cidade: ");
            codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a data 00/00/0000: ");
            var dt = Convert.ToDateTime(Console.ReadLine());
            dia = dt.Day;
            mes = dt.Month;
            ano = dt.Year;


            switch (mes)
            {
                case 01:
                    extenso = "Janeiro";
                    break;
                case 02:
                    extenso = "Fevereiro";
                    break;
                case 03:
                    extenso = "Março";
                    break;
                case 04:
                    extenso = "Abril";
                    break;
                case 05:
                    extenso = "Maio";
                    break;
                case 06:
                    extenso = "Junho";
                    break;
                case 07:
                    extenso = "Julho";
                    break;
                case 08:
                    extenso = "Agosto";
                    break;
                case 09:
                    extenso = "Setembro";
                    break;
                case 10:
                    extenso = "Outubro";
                    break;
                case 11:
                    extenso = "Novembro";
                    break;
                case 12:
                    extenso = "Dezembro";
                    break;
            }

            dataatual = dia + " de " + extenso + " de " + ano;

            if (codigo == 1)
            {
                Console.WriteLine("Atibaia, " + dataatual);
            }
            if (codigo == 2)
            {
                Console.WriteLine("Bragança Paulista, " + dataatual);
            }
            if (codigo == 3)
            {
                Console.WriteLine("Mairiporã, " + dataatual);
            }
            if (codigo == 4)
            {
                Console.WriteLine("Nazaré, " + dataatual);
            }
            if (codigo == 5)
            {
                Console.WriteLine("Terra Preta, " + dataatual);
            }
            if (codigo == 6)
            {
                Console.WriteLine("Extrema, " + dataatual);
            }
            if (codigo == 7)
            {
                Console.WriteLine("Vargem, " + dataatual);
            }

            Console.ReadKey();
        }
    }
}
