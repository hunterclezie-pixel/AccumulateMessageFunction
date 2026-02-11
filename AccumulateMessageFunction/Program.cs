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
            Console.WriteLine("Enter a message to accumulate or 'Q' to quit):");

            do
            {
                userInput = Console.ReadLine();

                // small adjustment: append the new input into `message` and update `addedValue`
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

            Console.Clear();
            Console.WriteLine($"Your accumulated message is: \n{addedValue}");
            Console.WriteLine("What a beautiful list! Have a good day!");

            //pause
            Console.Read();

        }
    }
}