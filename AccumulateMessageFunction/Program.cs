/* 
Hunter Clezie 
Spring 2026
RCET2265
AccumulateMessageFunction
github url: https://github.com/hunterclezie-pixel/AccumulateMessageFunction.git
*/
namespace AccumulateMessageFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string message = "";
            string addedValue = message + userInput;

            // Prompt the user for input
            Console.WriteLine("Enter a message to accumulate");
            Console.WriteLine("when you're ready to complete your list press 'Q' to quit):");

            do
            {
                userInput = Console.ReadLine();

                //stores the user input in a variable and adds it to the message variable if the user does not enter 'Q' or 'q'
                if (userInput != "Q" && userInput != "q")
                {
                    if (string.IsNullOrEmpty(message))
                    { 
                        message = userInput;
                    }

                    else
                    {
                        message = message + "\n" + userInput;
                    }

                    addedValue = message;
                }

                Console.Clear();
                Console.WriteLine(message);

            } while (userInput != "Q" && userInput != "q");

            //clears the console and displays the accumulated messages before quitting
            Console.Clear();
            Console.WriteLine($"Your accumulated message is: \n{addedValue}");
            Console.WriteLine("What a beautiful list! Have a good day!");

            //pause
            Console.Read();

        }
    }
}