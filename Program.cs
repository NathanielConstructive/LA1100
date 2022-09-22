
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;






static int GetPlayerSelection()
{


  

Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Geben Sie eine Zahl zwischen 1 und 100 ein: ", ConsoleColor.Blue, "Zahl" );

    var input = Console.ReadLine();

    if (int.TryParse(input, out int intVariable))
    {
        if (intVariable >= 1 && intVariable <= 100)
           
            return intVariable;
    }

    return GetPlayerSelection();
}

   
Console.ForegroundColor = ConsoleColor.Blue;    
Console.WriteLine("Geben Sie ihren Namen ein");

string Name = Console.ReadLine();



start:

    
    var player = GetPlayerSelection();
    var Laptop = new Random().Next(1, 101);
    var counter = 1;
    
    
while (player != Laptop)
{
    if (player > Laptop)
    {
        Console.WriteLine("Die eingegebene Zahl ist zu hoch!");
    }
    else
    {
        Console.WriteLine("Die eingegebene Zahl ist zu niedrig!");
    }

    counter++;
    player = GetPlayerSelection();
}



Console.WriteLine($"Glückwunsch! {Name} Du hast {counter} Schritte gebraucht!\n\n");




char eingabe;

Console.WriteLine("Geben Sie j oder J ein um das Programm neuzustarten oder schliesse es mit n oder N");
eingabe = Convert.ToChar(Console.ReadLine());

if (eingabe == 'J' || eingabe == 'j')
{
    goto start;
}

if (eingabe == 'N' || eingabe == 'n')
{
    Environment.Exit(0);

}















