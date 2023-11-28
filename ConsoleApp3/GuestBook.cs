using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

                Console.Write("Please enter your family name: ");
                guest.partyName = Console.ReadLine();

                Console.WriteLine();

                Console.Write("Please enter how many of you are in the party: ");
                guest.partySize = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                return guest;
            }
    }
