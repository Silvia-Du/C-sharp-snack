// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

//l'utente inserisce due numeri in successione, il software stama il maggiore

//int limit = 2;
//int[] numbers = new int[2];
int num1;
int num2;


    Console.WriteLine("inserisci il primo numero");
    int userNumber1 = Convert.ToInt32(Console.ReadLine());
    num1 = userNumber1;

    Console.WriteLine("inserisci il secondo numero");
    int userNumber2 = Convert.ToInt32(Console.ReadLine());
    num2 = userNumber2;

if (num1 > num2)
{
    Console.WriteLine($"il primo numero({num1}) è maggiore");

}else if(num2 > num1)
{
    Console.WriteLine($"il secondo numero ({num2}) è maggiore");
}
else
{
    Console.WriteLine("i due numeri sono uguali");

}



