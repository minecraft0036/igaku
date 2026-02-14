namespace easy_beep_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Beep();
            while (true)
            {
                
                d.Fre = int.Parse(Console.ReadLine()??"1000");
                d.Time = int.Parse(Console.ReadLine() ?? "1000");
                Console.Beep(d.Fre, d.Time);
                

            }
        }
        class Beep
        {
            public int Fre;
            public int Time;

        }
    }
}
