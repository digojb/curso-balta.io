using System.Globalization;

namespace CultureInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var pt = new System.Globalization.CultureInfo("pt-BR");
            var en = new System.Globalization.CultureInfo("en-US");
            var de = new System.Globalization.CultureInfo("de-DE");

            //Short date time, data resumida (minusculo).
            Console.WriteLine(DateTime.Now.ToString("d", pt));
            Console.WriteLine(DateTime.Now.ToString("d", en));
            Console.WriteLine(DateTime.Now.ToString("d", de));

            //Long date time, data detalhada (maiusculo).
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));

            //Vai pegar o horário global, nao coloca nenhum timezone. 
            var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate);

            //Aqui passamos a variavel da hora global para a hora local.
            Console.WriteLine(utcDate.ToLocalTime());

            //Aqui buscamos o timezone de determinado local.
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            //Aqui estamos pegando a data utc e colocando o timezone da Australia.
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            //Aqui ele ira pegar e exibir todos os timezones que tem no sistema atual.
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("__________");
            }

            //TimeSpan

            //TimeSpan é muito utilizado para realizar calculos de horas.

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            //Ira exibibir 1 nanosegundo.
            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            //Ira exibir a hora, min e seg, de acordo com a ordem que colocamos entre "()".
            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            //Ira exibir dia, hora, min e seg, de acordo com a ordem que colocamos entre "()".
            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            //Ira exibir o dia, hora, min, seg e miliseg de acordo com a ordem que colocamos entre "()".
            var timeSpanDiaHoraMinutoSegundoMilisegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilisegundo);

            //Aqui estamos realizando uma subtraçao entre uma hora e outra. 
            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);

            //Ira mostrar a quantidade de dias.
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);

            //Aqui podemos adicionar horas, min e seg na data atual.
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
        }
    }
}