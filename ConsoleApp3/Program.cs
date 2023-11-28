using ConsoleApp3;
/*
 * Build a Console Guest Book
 * 
 *  --> Ask the user for their party name i.e., family name and how many are in their party.
 *  
 *  --> Keep track of how many people are at the party.
 *  
 *  --> At the end, print out the guest list (all family names) and the total number of guests
 */

IntroToApp();
var guestBook = new GuestBook();
ListGuests(guestBook.Book);
OutroToApp();


void IntroToApp()
{
    Console.WriteLine("######################################");
    Console.WriteLine("#       Guest List Application       #");
    Console.WriteLine("######################################");

    Console.WriteLine("Welcome to the 'Guest List' application!");
    Console.WriteLine();
}
void ListGuests(List<Guest> Book)
{
    foreach(Guest guest in Book)
    {
        Console.WriteLine($"Party: {guest.partyName} Number in Party: {guest.partySize}");
    }
}

void OutroToApp()
{
    Console.WriteLine();
    Console.WriteLine("Thanks for using the 'Guest List' application!");
    Console.ReadLine();
}


