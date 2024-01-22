namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var arr = new int[3];

            try
            {
                /*
                for (var index = 0; index < 10; index++)
                {
                   Console.WriteLine(arr[index]);
                }
                */

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex) //Se o erro for OutOfRange, ira entrar nesse catch. Caso contrario vai para o de baixo.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message); //Exibe qual é a mensagem de erro.
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (ArgumentNullException ex) //Exception espceficia pra null ou vazio.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message); //Exibe qual é a mensagem de erro.
                Console.WriteLine("Falha ao cadastrar o texto");
            }
            catch (MinhaException ex) //Exeção customizada para mostrar quando aconteceu.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.QuandoAconteceu);
                Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex) //Esse exception sempre fica por ultimo. A ordem é do mais especifico para o mais generico.
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message); //Exibe qual é a mensagem de erro.
                Console.WriteLine("Ops, algo deu errado");
            }
            finally //Vai ser executado sempre. Independende se acontecer erro e entrar no catch ou nao.
            {
                Console.WriteLine("Chegou ao fim!");
            }
        }


        //Disparando Exceptions

        /*
        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new ArgumentNullException("O texto nao pode ser nulo ou vazio"); //Essa mensagem é exibida na tela quando chamamos o .Message no catch.
            }
        }
        */

        //Custom Exceptions

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
