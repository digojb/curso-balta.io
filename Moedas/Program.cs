using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            decimal valor = 10.25m; //Decimal é indicado para trabalhar com valores/moedas.

            //Podemos usar o CultureInfo para definir a cultura e formatar o valor correspondente ao país.
            Console.WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("en-US")));

            //Formata colocando no padrão de moeda correspondente a cultura indicada.
            Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("es-ES")));

            //Formata colocando o numero, mas sem a formataçao de moeda.
            Console.WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("es-ES")));

            //Formata colocando no valor de porcentagem.
            Console.WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("es-ES")));


            //Math

            decimal valorMath = 10536.25m;

            //Arredonda o valor.
            Console.WriteLine(Math.Round(valorMath));

            //Arredonda o valor pra cima.
            Console.WriteLine(Math.Ceiling(valorMath));

            //Arredonda o valor pra baixo.
            Console.WriteLine(Math.Floor(valorMath));


        }
    }
}
