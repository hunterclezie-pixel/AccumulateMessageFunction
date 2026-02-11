namespace AccumulateMessageFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string message = userInput;
            List<string> addedValue = new List<string>();

            // Prompt the user for input
            Console.WriteLine("Enter a message to accumulate or 'Q' to quit):");

            do
            {
                userInput = Console.ReadLine();
                addedValue.Add(userInput);
                Console.WriteLine(userInput);

            } while (userInput != "Q" && userInput != "q");

            Console.Clear();
            Console.WriteLine($"Your accumulated message is: {userInput}");
            Console.WriteLine("Have a good day!");

            //pause
            Console.Read();

        }
    }
}