namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> shenGame = new List<string>()
        {
            "ShenPop Quiz",
            "ShenMind Game",
            "ShenLove Text",
            "ShenCrazy Creative",

        };

            shenGame.Add("ShenMatch Up");
            shenGame.Add("ShenMake Codes");

            var orderShenGames = shenGame.OrderBy(shen => shen.Length);

            Console.WriteLine("Below is the list of Shen Games Sorted by Lenght.");
            Console.WriteLine();

            foreach (var shen in orderShenGames)
            {
               
                
                Console.WriteLine(shen);
            }
        }
    }
}
