// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/* - 01  Use a do-while loop to output "Hello, World!" in a loop. Each time you output "Hello, World!"
 * ask the user whether they would like to continue
 * Would you like to continue (y/n)? <<y
>>Hello, World!
Would you like to continue (y/n)? <<n
>>Goodbye!
 */


using System;

do
{
    Console.WriteLine("Hello World!");

    Console.Write("Would you like to continue Y/N? ");
    string userInput = Console.ReadLine();

    if (userInput.ToLower() == "y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("GoodBye!");
        break;
    }

} while (true);


/* - 02 Prompt the user for a number. Use a for loop to output all the numbers from that number to 0.
 * After that loop finishes, use another loop to output all the numbers from 0 to that number
 * >>Enter a number: <<5
>>5 4 3 2 1 0
>>0 1 2 3 4 5  */

Console.Write("Enter a whole number: ");
int userNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Descending Order: ");

for (int i = userNumber; i >= 0; i--)
{
    Console.Write($"{i} ");

}

Console.WriteLine();

Console.WriteLine("Ascending Order: ");

for (int i = 0; i <= userNumber; i++)
{
    Console.Write($"{i} ");

}
Console.WriteLine();

/* - 03 A door has a keypad entry. The combination to get in is 13579. 
 * Write a while loop (not a do while loop) that asks the user to enter a key code. 
 * The loop will repeat as long as the user enters the wrong code. After the user enters the correct code,
 * the program will print out a welcome message.

Hint: There are many ways to accomplish this, but one way is to create a boolean variable that represents 
if the door is locked or unlocked. Then think about real life, when you approach a door with a keypad, 
what state is it initially in before you type anything into the keypad? */

int keyCode = 0;
int numberOfTries = 0;

while (keyCode != 13579)
{
    Console.Write("Enter your key Code: ");
    keyCode = int.Parse(Console.ReadLine());

    //Without limited number of tries

    if (keyCode == 13579)
    {
        Console.WriteLine("Welcome to home sweet home!");
    }
    else
    {
        Console.WriteLine("Incorrect key code. Please try again");
    }

    //********************************************************************

    // - 04 With limited number of tries i.e 5
    if (keyCode == 13579 && numberOfTries <= 5)
    {
        Console.WriteLine($"Welcome to home sweet home with {numberOfTries+1} try/tries!");
    }
    else
    {
        numberOfTries++;
    }

    if (numberOfTries >= 5)
    {
        Console.WriteLine($"Warning: there were too many incorrect attempts. Try again Later. ");
        break;
    }
}

// - 05 with Do While loop
// Start a new console project, and repeat the same exercise as the previous, except this time implement it with a do while loop.


bool tryAgain = true;

do
{
    if (keyCode == 13579 && numberOfTries <= 5)
    {
        Console.WriteLine($"Welcome to home sweet home with {numberOfTries + 1} try/tries with do loop!");
    }
    else
    {
        numberOfTries++;
    }

    if (numberOfTries >= 5)
    {
        Console.WriteLine($"Warning: there were too many incorrect attempts 'with do loop'. Try again Later. ");
        break;
    }

} while(tryAgain == false);