namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videogames = new List<string>();
            videogames.Add("Mega Man X");
            videogames.Add("Dark Souls 1");
            videogames.Add("Hades");
            videogames.Add("Super Mario World");
            videogames.Add("Hollow Knight");

            videogames.Sort((game1, game2) =>
            {
                Console.WriteLine($"Comparing {game1} with {game2}");
                Console.WriteLine($"Game 1 Length: {game1.Length}, Game 2 Length: {game2.Length}");
                return game1.Length.CompareTo(game2.Length);
            });
        }
    }
}
