namespace AccumulateMessageFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            string message = userInput;
            string accumulatedMessage = AccumulateMessage(message);

            do
            { 
                Console.WriteLine(accumulatedMessage);
                Console.ReadLine();

            } while (userInput != "Q" && userInput != "q") ;

            //pause
            Console.Read();
        }

        static string AccumulateMessage(string message)
        {
            Console.WriteLine("Enter a message to accumulate (or 'Q' to quit):");
            string userInput = "";
            userInput = Console.ReadLine();
            message = userInput;
            return $"Accumulated: {message}";
        }
    }
}
