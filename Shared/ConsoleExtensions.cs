namespace Shared;

public static class ConsoleExtensions
{
    public static int GetInt(string message)
        {
            Console.Write(message);
            var numberString = Console.ReadLine();
            if (int.TryParse(numberString, out int numberInt))
            {
                return numberInt;
            }

            return 0;
        }
 
}
