using System;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //guid é um identificador global unico. Gera valores aleatorios.
            id.ToString(); //transforma o id em string. o Console.WriteLine ja esta fazendo isso no caso.

            id = new Guid("0f880d15-4f11-4b7a-9339-1f7451ea9139"); //usado para gerar um guid que ja existe. Caso esteja vazio será tudo zero.

            Console.WriteLine(id.ToString().Substring(0, 8)); //ira pegar apenas os 8 primeiros numeros.
        }
    }
}
