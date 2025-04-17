using System;

namespace HangmanUnicorn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int wins = 0, losses = 0;
            string replay;

            do
            {
                Console.Clear();
                ShowBanner();

                var game = new HangmanGame();
                bool won = game.Play();

                if (won)
                {
                    wins++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n🏆 Victoire ! Bien joué !");
                }
                else
                {
                    losses++;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n💀 Défaite... Le mot était : " + game.SecretWord);
                }

                Console.ResetColor();
                Console.WriteLine($"\n🎯 Score: {wins} gagnée(s), {losses} perdue(s)");

                Console.Write("\n🔁 Voulez-vous rejouer ? (o/n): ");
                replay = Console.ReadLine()?.ToLower();
            }
            while (replay == "o");

            Console.WriteLine("\n🌈 Merci d'avoir joué au Pendu Licorne!");
            Console.WriteLine("🌟 À bientôt!");
        }

        public static void ShowBanner()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("╔═══════════════════════════════════════╗");
            Console.WriteLine("║        🦄 Le Pendu de la Licorne       ║");
            Console.WriteLine("╚═══════════════════════════════════════╝");
            Console.ResetColor();
        }
    }
}