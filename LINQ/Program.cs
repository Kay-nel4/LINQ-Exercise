namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string>();
            videoGames.Add("Mario Party");
            videoGames.Add("Super Mario 64");
            videoGames.Add("Super Mario Galaxy");
            videoGames.Add("Mario Maker");
            videoGames.Add("Mario Odyssey");
            videoGames.Add("Mario Kart");
            videoGames.Add("Wario World");

            var lengthOfName = videoGames.OrderBy(videoGames => videoGames.Length).ToArray();
            foreach (var videoGame in lengthOfName)
            {
                Console.WriteLine(videoGame);
            }
            
            Console.WriteLine("----");
            Console.WriteLine("Count Method");
            
            var howManyGames = videoGames.Count();
            Console.WriteLine($"There are {howManyGames} in this List!");
            
            Console.WriteLine("----");
            Console.WriteLine("Filter The Names / Split Method");
            
            var namesWithTwoWords = videoGames.Where(videoGames => videoGames.Split(new char[]{ ' '}, StringSplitOptions.RemoveEmptyEntries).Count()== 2).ToArray();
            foreach (var videoGame in namesWithTwoWords)
            {
                Console.WriteLine($"This is a game name with two words! {videoGame}");
            }
            
            Console.WriteLine("----");
            Console.WriteLine("Filter by First Letter.");

            var alphabetizeGames = videoGames.OrderBy(videoGames => videoGames.FirstOrDefault());
            foreach (var name in alphabetizeGames)
            {
                Console.WriteLine($"{name}");
            }
            
            Console.WriteLine("----");
            Console.WriteLine("How Many Marios?");

            string word = "Mario";
            int wordCount = videoGames.Count(videoGames => videoGames.Contains(word));
            Console.WriteLine($"There are {wordCount} {word}s in this List!");






        }
    }
}
