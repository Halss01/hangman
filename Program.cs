using System;

namespace projekt_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxTryes = 7;

            int hangmanStatus = 0; 
            int guessStatus = 0;
            string guessedWord;

            //game start
            //load a word
            var LoadWord = new LoadWord();
            var hangman = new Display();
            string wordToGuess = LoadWord.getrandomWord();

            int letterCount = LoadWord.getLetterCount();
            Console.WriteLine("The word you are looking for has: " + letterCount + " letters.");
            
            Console.WriteLine(LoadWord.getGuessedWord("KN2001"));
            
            while(hangmanStatus < maxTryes && guessStatus <= letterCount){
                if(hangmanStatus < 0 && guessStatus < 0){Console.Clear();}
                int canBeWrong = -1*(hangmanStatus - maxTryes);

                Console.WriteLine("Guess a letter That you think might be in this word you still have: " + canBeWrong.ToString() +" tries.");
                Console.WriteLine(hangman.setupDisplay(hangmanStatus));

                string userInput = Console.ReadLine();
                
                if(LoadWord.checkLetter(userInput) == false){
                    hangmanStatus++;
                    guessedWord = LoadWord.getGuessedWord("CH2006");
                }else{
                    guessedWord = LoadWord.getGuessedWord(userInput);
                    guessStatus++;
                }
                Console.WriteLine(guessedWord);
            }
            if(guessStatus == letterCount){
                Console.WriteLine("Congratulation you wont !!");
            }else {
                Console.WriteLine("Im sorry you lose and the word was: " + wordToGuess);
            }
            Console.ReadLine();
        }
    }
}
