namespace AntiFileDelete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var stream = new FileStream(args[0], FileMode.Open, FileAccess.Read, FileShare.Read);
            while (true)
            {
                Thread.Sleep(1000);
            }

        }
    }
}
