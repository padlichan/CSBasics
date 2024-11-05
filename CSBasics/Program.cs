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
           
        }
        private static void printGreeting(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
