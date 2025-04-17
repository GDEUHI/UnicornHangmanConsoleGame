using System;

namespace HangmanUnicorn
{
    public static class HangmanArt
    {
        public static void Draw(int stage)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            string[] states = new string[]
            {
                """
                   +---+
                       |
                       |
                       |
                      ===
                """,
                """
                   +---+
                   |   |
                       |
                       |
                      ===
                """,
                """
                   +---+
                   |   |
                   O   |
                       |
                      ===
                """,
                """
                   +---+
                   |   |
                   O   |
                   |   |
                      ===
                """,
                """
                   +---+
                   |   |
                   O   |
                  /|   |
                      ===
                """,
                """
                   +---+
                   |   |
                   O   |
                  /|\\  |
                      ===
                """,
                """
                   +---+
                   |   |
                   O   |
                  /|\\  |
                  /    ===
                """,
                """
                   +---+
                   |   |
                   O   |
                  /|\\  |
                  / \\  ===
                """,
                """
                   +---+
                   |   |
                  [O]  |
                  /|\\  |
                  / \\  ===
                """
            };

            int index = Math.Min(stage, states.Length - 1);
            Console.WriteLine(states[index]);
            Console.ResetColor();
        }
    }
}