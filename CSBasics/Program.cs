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

            Book theHobbit = new Book("The Hobbit", 350);
            Console.WriteLine($"Title: {theHobbit.Title}, currentPage: {theHobbit.CurrentPage}");
            for (int i = 0; i < 10; i++)
            {
                theHobbit.TurnPage();
            }
            Console.WriteLine($"Title: {theHobbit.Title}, currentPage: {theHobbit.CurrentPage}");


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
