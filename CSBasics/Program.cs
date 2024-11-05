namespace CSBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
           

            bool isLearningCSharp = true;
      

            string favouriteFilm = "Gladiator";
            

            favouriteFilm = "High School Musical 2";

            printGreeting("James");

            int difference = subtractNumber(10, 5);

           
        }
        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        private static int subtractNumber(int num1, int num2) => num1 - num2;

        private static bool isLongerThan(string word, int number)
        {
            if (word.Length > number)
            {
                return true;
            }
            return false;
        }
    }
}
