// See https://aka.ms/new-console-template for more information
using System;

//1- l'utente inserisce due numeri in successione, il software stama il maggiore

//int limit = 2;
//int[] numbers = new int[2];
//int num1;
//int num2;


//    Console.WriteLine("inserisci il primo numero");
//    int userNumber1 = Convert.ToInt32(Console.ReadLine());
//    num1 = userNumber1;

//    Console.WriteLine("inserisci il secondo numero");
//    int userNumber2 = Convert.ToInt32(Console.ReadLine());
//    num2 = userNumber2;

//if (num1 > num2)
//{
//    Console.WriteLine($"il primo numero({num1}) è maggiore");

//}else if(num2 > num1)
//{
//    Console.WriteLine($"il secondo numero ({num2}) è maggiore");
//}
//else
//{
//    Console.WriteLine("i due numeri sono uguali");

//}

//2-L'utente inserisce due parole in successione, il software scrive prima quella piu corta e poi quella piu lunga

//string[] words = new string[2];
//Console.WriteLine($"ti chiederò di inserire due parole");

//for (int i=0; i< words.Length; i++)
//{
//    Console.WriteLine($"scrivi la {i+1}' parola");
//    words[i]= Console.ReadLine();

//}

//if(words[0].Length > words[1].Length)
//{
//    Console.WriteLine($"la parola piu corta: {words[1]}");
//    Console.WriteLine($"la parola piu lunga: {words[0]}");
//}else if(words[1].Length > words[0].Length)
//{
//    Console.WriteLine($"la parola piu corta: {words[0]}");
//    Console.WriteLine($"la parola piu lunga: {words[1]}");
//}
//else
//{
//    Console.WriteLine($"le due parole sono lunghe uguali");
//}

//3- Chiedre 10 volte all'utente di inserire un numero, il software stampa la somma dei 10 numeri

//Console.WriteLine($"Ti chiederò di inserire dieci numeri");
//int total = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"inserisci il {i+1}' numero");
//    int userNum = Convert.ToInt32(Console.ReadLine());
//    total =  userNum + total;

//}

//Console.WriteLine($"La somma dei tuoi numeri è {total}");

//4- calcola la somma e la media dei numeri da 2 a 10

int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int sum = default;
int numAverage = default;

for (int i = 0; i < numbers.Length; i++)
{
    sum = numbers[i] + sum;

}

numAverage = sum / numbers.Length;

Console.WriteLine($"la somma dei numeri da 2 a 10 è {sum}");
Console.WriteLine($"la media dei numeri da 2 a 10 è {numAverage}");








