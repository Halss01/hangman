public class Display{

    string output;
    public string setupDisplay(int hangmanStatus){
        switch(hangmanStatus){
            case 0:
                output = "  +---+ \n  |   | \n      |\n      |\n      |\n      |\n =========";
                break;
            case 1:
                output = "  +---+ \n  |   |\n  o   |\n      |\n      |\n      |\n =========";
                break;
            case 2:
                output = "  +---+ \n  |   |\n  o   |\n  |   |\n      |\n      |\n =========";
                break;
            case 3:
                output = "  +---+ \n  |   |\n  o   |\n /|   |\n      |\n      |\n =========";
                break;
            case 4:
                output = "  +---+ \n  |   |\n  o   |\n /|\\  |\n      |\n      |\n =========";
                break;
            case 5:
                output = "  +---+ \n  |   |\n  o   |\n /|\\  |\n /    |\n      |\n =========";
                break;
            case 6:
                output = "  +---+ \n  |   |\n  o   |\n /|\\  |\n / \\  |\n      |\n =========";
                break;
        }
        return output;
    }
    
}