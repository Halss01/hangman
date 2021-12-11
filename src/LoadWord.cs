using System;
public class LoadWord{

    private string[] words;
    private int randomWordIndex;
    private string randomWord;
    private int letterCount = 0;
    char[] wordLetters;
    char[] hiddenLetter;
    

    public LoadWord(){
        this.words = new string[] {"GPU", "CPU", "Monitor", "Mice", "Keyboard", "Windows", "Mac", "Linux", "Website", "PHP", "JavaScript", "Microphone", "Moist", "School"};
    }

    private int getWordCount(){
        return this.words.Length;
    }

    public string getrandomWord() {
        var rand = new Random();
        int wordCount = getWordCount();

        this.randomWordIndex = rand.Next(0, wordCount);
        this.randomWord = words[this.randomWordIndex];

        return this.randomWord;
    }

    public int getLetterCount(){
        this.wordLetters = this.randomWord.ToCharArray();
        while(this.letterCount < this.wordLetters.Length){
            this.letterCount++;
        }
        hiddenLetter = new char[letterCount];
        return this.letterCount;
    }

    public string getGuessedWord(string userInput){
        int i  = 0;
        

        if(userInput == "KN2001"){
            while(i < letterCount){
                this.hiddenLetter[i] = char.Parse("_");
                i++;
            }
        }else if(userInput == "CH2006"){
        }else{
            while(i < this.letterCount){           
                if(this.wordLetters[i].ToString().ToLower() == userInput.ToLower()){
                    this.hiddenLetter[i] = char.Parse(userInput);
                }
                i++;
            }
        }
        string output = new string(hiddenLetter);
            return output;
    }

    public bool checkLetter(string userInput){
        int i = 0;
        while(i < letterCount){                
            if(this.wordLetters[i].ToString() == userInput){
                return true;
            }
            i++;
        }
        return false;
    }

}