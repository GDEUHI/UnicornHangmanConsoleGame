using System;
using System.Collections.Generic;
using System.IO;

namespace HangmanUnicorn
{
    public class HangmanGame
    {
        public string SecretWord { get; private set; } = "";
        private string displayWord = "";
        private readonly HashSet<char> guessedLetters = new();
        private int errors = 0;
        private const int MaxErrors = 8;

        public bool Play()
        {
            LoadWord();
            InitDisplayWord();

            while (errors < MaxErrors && displayWord.Contains('_'))
            {
                Console.Clear();
                Program.ShowBanner();
                Console.WriteLine($"Mot à trouver :  {BeautifyDisplayWord()}");
                HangmanArt.Draw(errors);
                Console.WriteLine($"\n🔠 Lettres proposées : {string.Join(", ", guessedLetters)}");
                Console.WriteLine($"❤️ Tentatives restantes : {MaxErrors - errors}");

                Console.Write("\nEntrez une lettre : ");
                string? input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("⚠️ Entrée invalide. Appuyez sur une touche pour continuer...");
                    Console.ReadKey();
                    continue;
                }

                char letter = input[0];

                if (guessedLetters.Contains(letter))
                {
                    Console.WriteLine("⛔ Lettre déjà proposée. Essayez encore. Press any key...");
                    Console.ReadKey();
                    continue;
                }

                guessedLetters.Add(letter);

                if (SecretWord.Contains(letter))
                    UpdateDisplayWord(letter);
                else
                    errors++;
            }

            Console.Clear();
            HangmanArt.Draw(errors);
            return !displayWord.Contains('_');
        }

        private void LoadWord()
        {
            try
            {
                var words = File.ReadAllLines("mots.txt");
                var rnd = new Random();
                SecretWord = words[rnd.Next(words.Length)].Trim().ToLower();
            }
            catch
            {
                SecretWord = "licorne"; // fallback
            }
        }

        private void InitDisplayWord()
        {
            foreach (char c in SecretWord)
                displayWord += c == '-' ? '-' : '_';
        }

        private void UpdateDisplayWord(char letter)
        {
            char[] chars = displayWord.ToCharArray();
            for (int i = 0; i < SecretWord.Length; i++)
            {
                if (SecretWord[i] == letter)
                    chars[i] = letter;
            }
            displayWord = new string(chars);
        }

        private string BeautifyDisplayWord()
        {
            char[] chars = displayWord.ToCharArray();
            return string.Join(" ", chars).ToUpper();
        }
    }
}
