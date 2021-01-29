using System;

namespace InputExample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new InputExampleGame())
                game.Run();
        }
    }
}
