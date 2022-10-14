namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string planetName = "Neptune";
            int planetAge = 50;
            char planetSymbol = 'c';
            bool isInhabitable = false;
            double distance = 100.52;
            decimal mass = 30.9m;
                
            Console.WriteLine($"My favorite planet is {planetName}. It is about {planetAge} days old. \nI call it {planetSymbol}. Is {planetSymbol} a fun place to be? {isInhabitable}. It's too far. \nIt's like {distance} feet from my house and weighs like {mass} pounds. It's a cool planet.");




        }
    }
}