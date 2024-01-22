
//Verifica se as palavras são iguais. Retorna 0 = True, 1 = False.
using System.Text;

var texto = "teste";
Console.WriteLine(texto.CompareTo("teste"));

var texto2 = "Este texto é um teste";

//Verifica se o texto contem a palavra informada.
Console.WriteLine(texto2.Contains("teste")); 

//Verifica se começa com a palavra informada.
Console.WriteLine(texto2.StartsWith("Este"));

//Verifica se o texto termina com a palavra informada.
Console.WriteLine(texto2.EndsWith("teste"));

//Equals compara se os valores são exatamente iguais.
Console.WriteLine(texto2.Equals("Este texto é um teste"));

var num = 10;
Console.WriteLine(num.Equals(10));

//Indice ou Index

//ira mostrar em qual posiçao do array a letra esta.
Console.WriteLine(texto2.IndexOf("é")); 

//aqui ele ira mostrar a posiçao da ultima letra s na frase.
Console.WriteLine(texto2.LastIndexOf("s"));


//Converter texto maiusculo ou minusculo

Console.WriteLine(texto2.ToUpper());
Console.WriteLine(texto2.ToLower());

//Insert

//Insere um texto na posição desejada.
Console.WriteLine(texto2.Insert(2, "AQUI"));

//Definimos o inicio e o fim que queremos remover.
//Começa no caractere 5, e remove os 5 proximos.
Console.WriteLine(texto2.Remove(5, 5));

//Mostra a quantidade de caractere que a string tem.
Console.WriteLine(texto2.Length);


//Replace

//Serve para substituir um texto antigo por um novo.
//Informamos o que vai ser substituido primeiro e o novo texto depois.
Console.WriteLine(texto2.Replace("Este", "isto"));

//Tambem serve para alterar letras do texto.
Console.WriteLine(texto2.Replace("e", "x"));

//Split

//Vai dividir o texto sempre que ouver um espaço, como informado nas aspas.
//Tambem pode ser informada virgula entre outras coisas.
//Como resultado vamos ter uma lista de strings, ou seja um array, cada palavra em uma posiçao.
var divisao = texto2.Split(" ");
Console.WriteLine(divisao[0]);
Console.WriteLine(divisao[1]);
Console.WriteLine(divisao[2]);
Console.WriteLine(divisao[3]);

//SubString

//Vai começar no 5 caractere e pegar os proximos 5.
var resultado = texto2.Substring(5, 5);

//Vai começar da posição 5 e pegar até a ultima letra desejada, no caso "o".
var resultado2 = texto2.Substring(5, texto2.LastIndexOf("o"));
Console.WriteLine(resultado2);


//Trim

//Remove os espaços do começo e do fim do texto.
Console.WriteLine(texto2.Trim());

//StringBuilder
//Serve para juntar linhas de textos, util em textos grandes com diversas linhas.
var texto3 = new StringBuilder();
texto3.Append("Este texto é um teste");
texto3.Append("é um teste");
texto3.Append("Este texto");
texto3.Append("Este é um teste");

texto.ToString();
Console.WriteLine(texto3);