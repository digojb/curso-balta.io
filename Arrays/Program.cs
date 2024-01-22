namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var meuArray = new int[5] { 11, 22, 33, 44, 55 };

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]);

            meuArray[0] = 12;
            Console.WriteLine(meuArray[0]);


            //Struct

            //var meuArray = new Teste[2];
            // meuArray[0] = new Teste();
            //Console.WriteLine(meuArray[0].Id);


            //Percorrendo um array

            var meuArray2 = new int[5] { 11, 22, 33, 44, 55 };
            meuArray2[0] = 12;

            for (var index = 0; index < meuArray2.Length; index++)
            {
                Console.WriteLine(meuArray2[index]);
            }


            //Foreach
            /*
                        var meuArray3 = new int[5] { 11, 22, 33, 44, 55 };
                        meuArray3[0] = 12;

                        foreach (var item in meuArray3)
                        {
                            Console.WriteLine(item);
                        }

                        var funcionarios = new Funcionario[5]; //Inicializando Array.
                        funcionarios[0] = new Funcionario() { Id = 2323 }; //Inicializando Struct.

                        foreach (var funcionario in funcionarios)
                        {
                            Console.WriteLine(funcionario.Id);
                        }
                        */

            //Ultimo

            //Quando passamos dessa forma estamos apenas apontando o valor na memoria, ou seja, n estamos trocando ele.
            //Embora sejam em variaveis diferentes estao apontando para o mesmo lugar na memoria.
            var primeiro = new int[4];
            var segundo = primeiro;

            primeiro[0] = 23;
            Console.WriteLine(segundo[0]);

            //Caso queremos criar um novo array, devemos utilizar a palavra new.
            var primeiro2 = new int[4];
            var segundo2 = new int[4];

            segundo2[0] = primeiro2[0];
            primeiro2[0] = 23;
            Console.WriteLine(segundo2[0]);
        }
        /*
                  struct Teste
                  {
                      public int Id { get; set; }
                  }

                struct Funcionario
                {
                    public int Id { get; set; }
                }
                */
    }
}