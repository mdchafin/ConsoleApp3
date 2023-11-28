using _8_MiniProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class GuestBook
    {
        public GuestBook()
        {
            NewMethod(out continueEnteringInfo, out guestList);

        }

        private static void NewMethod(out bool continueEnteringInfo, out Dictionary<string, int> guestList)
        {
            while (continueEnteringInfo == true)
            {
                var guestListInfo = GuestBookMethod.GetGuestListInfo();

                guestList = GuestBookMethod.AddToDictionary(guestList, guestListInfo.partyName, guestListInfo.partySize);

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
    }
}
