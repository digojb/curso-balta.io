using System.Security.Cryptography.X509Certificates;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var dataPadrao = new DateTime(); //data padrao.
            Console.WriteLine(dataPadrao);

            var dataAtual = DateTime.Now; //data atual.
            Console.WriteLine(dataAtual);

            var data2 = new DateTime(2020, 10, 12, 8, 23, 14); //Ano, mes, dia, hora, min, segundo.
            Console.WriteLine(data2);

            //Valores separados.
            Console.WriteLine(data2.Year);
            Console.WriteLine(data2.Month);
            Console.WriteLine(data2.Day);
            Console.WriteLine(data2.Hour);
            Console.WriteLine(data2.Minute);
            Console.WriteLine(data2.Second);
            Console.WriteLine(data2.DayOfWeek);
            Console.WriteLine(data2.DayOfYear);

            var data = DateTime.Now;
            //var formatada = string.Format("{0:yyyy}", data); //Vai exibir apenas o ano da data atual.
            //var formatada = string.Format("{0:m}", data); //Vai exibir o mes e dia atual.
            var formatada = string.Format("{0:yyyy/MM/dd hh:mm:ss}", data); //Vai exibir ano, mes, dia, hora, min e seg atual.
            Console.WriteLine(formatada);

            //var formatada2 = string.Format("{0:t}", data); //Vai exibir somente a hora e minutos
            //var formatada2 = string.Format("{0:T}", data); //Vai exibir a hora, min e seg.
            //var formatada2 = string.Format("{0:r}", data); //Vai exibir as info completa padronizada.
            //var formatada2 = string.Format("{0:s}", data); //Normalmente utilizado nas datas do tipo json.
            var formatada2 = string.Format("{0:u}", data); //Vai exibir no padrao universal.
            Console.WriteLine(formatada2);

            //Adicionando valores
            var dataAdd = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));

            //Comparando datas

            /*Isso nunca ira funcionar pois tera milisegundos de diferença.
            var dataComp = DateTime.Now;
            if (dataComp == DateTime.Now)
                Console.WriteLine("É igual");
            */

            //Dessa forma vai dar certo pois ele ira comparar apenas a data, ignorando a hora.
            var dataComp2 = DateTime.Now;
            if (dataComp2.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }
            Console.WriteLine(dataComp2);

            //Metodos adicionais

            //Aqui ira mostrar quantos dias tem no mes do ano indicado entre "()";
            Console.WriteLine(DateTime.DaysInMonth(2020, 2));

            //Metodo para verificar se é final de semana ou não.
            static bool IsWeekend(DayOfWeek today)
            {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            //Verifica se esta ou nao no horario de verao. Baseado na cultura da data, ou seja, na localização do PC/Usuario.
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        }
    }
}

