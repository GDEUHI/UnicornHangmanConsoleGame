# 🦄 Unicorn Hangman Console Game
Goa Dane 
C#
A colorful, emoji-filled Hangman game built in C# for the console.  
Designed to showcase programming logic, personalization, and unicorn vibes 🌈✨

---

## 🎮 Features
- Word guessing with real-time letter reveals
- 8 chances to guess before the unicorn gets hanged 💀
- Victory/defeat animations and colorful banners
- Rainbow-colored letter display 🌈
- Replay mode with score tracking
- Random word selection from `mots.txt`

---

## 🧠 Built With
- C# (.NET 7 Console App)
- `System.IO` (for loading word list)
- `ConsoleColor` and ASCII art
- Programming concepts from:
  - Variables, conditionals, loops
  - Arrays and sub-programs
  - File I/O

---

## 🗂️ File Structure
🦄  Program.cs – Main Entry Point

🦄  Responsibilities:
	•	Display the unicorn banner
	•	Track win/loss score
	•	Ask player if they want to play again
	•	Launch the game loop using HangmanGame

🦄 UnicornHangman/
├── Program.cs            → Entry point of the program (main method)
├── HangmanGame.cs        → Game logic (word selection, guessing loop, scoring)
├── HangmanArt.cs         → Hangman ASCII visuals based on error count
├── mots.txt              → External file with unicorn-themed words
└── README.md             → Project documentation

🦄  HangmanGame.cs – Core Game Logic

🦄  Responsibilities:
	•	Load a random word from mots.txt
	•	Loop until the word is guessed or max errors reached
	•	Track used letters and handle input
	•	Display messages and call HangmanArt
 
🎨 HangmanArt.cs – Visual Feedback

🔍 Responsibilities:
	•	Display ASCII drawing of hangman stage
	•	Called with Draw(int stage)
	•	9 stages total, using indexed string array

🦄 mots.txt – External Word Source using StreamReader
	•	One word per line
	•	Loaded at runtime from:
