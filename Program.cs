// See https://aka.ms/new-console-template for more information
using System;

//1- l'utente inserisce due numeri in successione, il software stama il maggiore

//int limit = 2;
//int[] numbers = new int[2];
//int userNumber;
//int num2;

//for(int i = 0; i < numbers.Length; i++)
//{

//    Console.WriteLine($"inserisci il {i+1}' numero");
//    userNumber = Convert.ToInt32(Console.ReadLine());
//    numbers[i] = userNumber;
//}

//if (numbers[0] > numbers[1])
//{
//    Console.WriteLine($"il primo numero({numbers[0]}) è maggiore");

//}
//else if (numbers[1] > numbers[0])
//{
//    Console.WriteLine($"il secondo numero ({numbers[1]}) è maggiore");
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

//int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int sum = default;
//float numAverage = default;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum = numbers[i] + sum;

//}

//numAverage = sum / numbers.Length;

//Console.WriteLine($"la somma dei numeri da 2 a 10 è {sum}");
//Console.WriteLine($"la media dei numeri da 2 a 10 è {numAverage}");

//5- chiedo all'utente di inserire un numero se è pari lo stampo , se no stampo il numero successivo


//Console.WriteLine("Inserisci un numero");
//int userNumber = Convert.ToInt32(Console.ReadLine());
//if( userNumber % 2 == 0)
//{
//    Console.WriteLine($"Ecco il tuo numero perchè è pari: {userNumber}");
//}
//else
//{
//    Console.WriteLine($"Ecco il numero successivo perchè il tuo numero è dispari: {userNumber +1}");

//}


//6- Nell'array ci sono gli invitati di Gatsby, se il nome dell'utente è presente e dai feedback di accesso
Console.WriteLine("La festa di Gatsby è gia iniziata! sei inviatat@?");

string[] vipList = { "silvia", "manuel", "sebastiano", "paolo", "francesco" };

Console.WriteLine("Inserisci il tuo nome, verifico che tu sia nella lista degli invitati");
string userName = Console.ReadLine().ToLower();
bool isInvited = false;

for (int i = 0; i < vipList.Length; i++)
{
    if (userName.Equals(vipList[i]))
    {
        Console.WriteLine($"Benvenut@ alla festa {userName}");
        isInvited = true;
        break;

    }
    else
    {
        Console.WriteLine($"Mi dispiace {userName}, non posso farti entrare, torna quando sarai ivitato!");

    }
}

if (isInvited)
{

}


//7- creo un'array vuoto, chiedo per sei volte all'utente di inserire un numero, se è dispari lo inserisco nell'array

//int[] evenNumbers = new int[6];
//Console.WriteLine("Ti chiederò per 6 volte di inserire un numero");

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine($"Inserisci il {i+1}' numero");
//    int userNumber = Convert.ToInt32(Console.ReadLine());
//    if (userNumber % 2 != 0)
//    {
//        evenNumbers[i] = userNumber;

//    }
//    Console.WriteLine(evenNumbers[i]);
//}

//avrei preferito una soluzione in cui la lunghezza dell'array è determinata dalla quantità dei numeri dispari dell'utente


//8- creao un'array di numeri interi, sommo i numeri nelle posizioni dispari

//int[] numbers = { 5, 21, 4, 3, 1, 8, 6, 9 };

//int sum = default;

//for(int i = 0; i < numbers.Length; i++)
//{
//    if(i % 2 != 0)
//    {
//        sum = numbers[i] + sum;
//    }
//}

//Console.WriteLine($"La somma dei numeri nelle posizioni dispari è {sum}");


//9- creo un'array vuoto e chiedo un numero all'utente, finche la somma dei numeri inseriti è minore di 50


int[] numbers = new int[50];
int sum = default;
int position = default;

for (int i = 0; i < numbers.Length; i++)
    while (sum < 50)
    {
        if (i % 2 != 0)
        {
            sum += numbers[i];
        }
        Console.WriteLine("inserisci un numero");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if(userNumber != 0)
        {

            numbers[position] = userNumber;
            position ++;
            sum += userNumber;
        }
    }




//10- chiedo all'utente di inserire un numero n , genero n array ogniuno formato da 10 numeri casuali tra 1 e 100, quando lo creo lo stampo


Console.WriteLine("Inserisci un numero");
int arrayNumber = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();

for(int i = 0; i < arrayNumber; i++)
{
    int[] newArray = new int[10];
    Console.WriteLine($"Array {i+1}:");
    for (int k = 0; k < newArray.Length; k++)
    {
        newArray[k] = rand.Next(1, 100);
        Console.Write(newArray[k] + "-");

    }

}

//random posso anche crearlo nel ciclo e darlo subito all'elemento
// tipo: newArray[k] = new Random().next(1,100);












