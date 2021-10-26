using System;

namespace MovableArrow
{
    class Program
    {
        static int posX = 60;
        static int posY = 20;

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Borders();
            while (true)
            {
                while (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
                    posX--;
                    PosChanging("←");
                }
                while (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                    posX++;
                    PosChanging("→");
                }
                while (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    posY--;
                    PosChanging("↑");
                }
                while (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    posY++;
                    PosChanging("↓");
                }
            }
            
        }

        static void Borders()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("   *     *     * * *       * * *     ");
            Console.WriteLine("   *     *   *       *   *           ");
            Console.WriteLine("   * * * *   *       *     * * *     ");
            Console.WriteLine("   *     *   *       *           *   ");
            Console.WriteLine("   *     *     * * *       * * *     ");
            Console.WriteLine();
            Console.WriteLine("     * * *   * * * * *   *           * * * *     *   *       *   *   * * * * *   ");
            Console.WriteLine("   *         *           *           *       *   *   * *     *   *         *     ");
            Console.WriteLine("   * * *     * * * * *   *           *       *   *   *   *   *   *       *       ");
            Console.WriteLine("   *     *   *           *           *       *   *   *     * *   *     *         ");
            Console.WriteLine("     * *     * * * * *   * * * * *   * * * *     *   *       *   *   * * * * *   ");
            Console.WriteLine();
            Console.WriteLine("Başlamak için yön tuşlarına basın.");
            /*
            //üst kenar

            for (int i = 0; i < 60; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            //sol kenar

            for (int i = 0; i < 28; i++)
            {
                Console.Write("*");
                //aradaki boşluklar
                for (int j = 0; j < 58; j++)
                {
                    Console.Write("  ");
                }
                //sağ kenar
                Console.Write(" *");
                Console.WriteLine();
            }

            //alt kenar

            for (int i = 0; i < 60; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            */
        }

        static void PosChanging(string arrow)
        {
            Console.Clear();
            try
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(arrow);
            }
            catch
            {
                Console.Write("YANDINIZ");
            }
            
        }
    }
}
