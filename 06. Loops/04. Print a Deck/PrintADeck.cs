using System;

namespace PrintADeck
{
    class PrintADeck
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] deck = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
            int? card = null;
            switch (input)
                {
                case "2": case "3": case "4": case "5": case "6": case "7": case "8": case "9": case "10":
                    card = int.Parse(input)-2;
                    break;
                case "J":
                    card = 9;
                    break;
                case "Q":
                    card = 10;
                    break;
                case "K":
                    card = 11;
                    break;
                case "A":
                    card = 12;
                    break; 
                default:
                    break;
                }
            for (int i = 0; i <= card; i++)
            {
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", deck[i]);
            }
        }
    }
}
