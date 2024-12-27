namespace delegats
{
    public class Task1
    {
        public delegate void MessageDelegate(string message);

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayMessageInUppercase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public static void DisplayMessageInLowercase(string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }
}
