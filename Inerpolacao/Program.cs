using System;

namespace Inerpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.2;

            //Primeira forma
            //var texto = "O preço do produto é " + price;

            //Segunda forma
            //var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            /*Format é outra forma de adicionar o valor que desejamos, usamos as chaves e definimos o valor depois da virgula.
            podemos adiconar varios valores nas chaves, cada um em uma posição.*/

            //Terceira forma
            var texto = $"O preço do produto é {price} apenas na promoção";

            Console.WriteLine(texto);
        }
    }
}
