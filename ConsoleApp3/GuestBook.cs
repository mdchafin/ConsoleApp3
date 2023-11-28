namespace ConsoleApp3;

public class GuestBook
{
    public List<Guest> Book { get; set; }
    private bool continueEnteringInfo;
    public GuestBook()
    {
        Book = new List<Guest>();
        continueEnteringInfo = true;
        GetGuests();
    }
    public void GetGuests()
    {
        // Entering Info ----------------------------------------------------------------------------------------------------
        while (continueEnteringInfo == true)
        {
            Book.Add(GetGuestListInfo());

            Console.Write("Would you like to continue entering information (Y or N): ");
            string? answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                continueEnteringInfo = true;
            }
            else if (answer == "n")
            {
                continueEnteringInfo = false;
            }
            else
            {
                Console.WriteLine("Looks like you didnt enter Y or N, try harder next time!");
            }
        }
    }
    public Guest GetGuestListInfo()
    {
        Guest guest = new Guest();
        int numberOfGuests = 0;
        Console.Write("Please enter your family name: ");
        guest.partyName = Console.ReadLine();

        Console.WriteLine();
        do
        {
            Console.Write("Please enter how many of you are in the party: ");
            if(int.TryParse(Console.ReadLine(), out numberOfGuests))
            {
                guest.partySize = numberOfGuests;
            }
        } while( numberOfGuests  == 0);

        Console.WriteLine();

        return guest;
    }
}
