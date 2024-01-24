//Title: Creating a game that compares too players 
//Date: 24/01/2024
//Author: Genesisbyte
//Description: Using classes to create a minigame.


int userInput = PromptForNumberInRange("Player 1! Enter a number between 1 and 1000: ", 1, 1000); //Call the AskForNumberInRange class to ask player 1 for a number between 0 and 100. Will loop endlessly until player has entered between those values

Console.Clear();//Clear the screen

Console.WriteLine("Player 2! Your Turn!");//Prompt player 2 to get ready.

while (true)//Loop until true.
{
    int userGuess = PromptForAValue("What is your next guess?:");//If p2 decision is unsuccessful this message will occur
    if (userGuess > userInput) Console.WriteLine($"{userGuess} is too high!");//If p2 input is higher than p1s number this will happen. 
    else if (userGuess < userInput) Console.WriteLine($"{userGuess} is too low!");//If p2 input is lower than P1s number this will happen.
    else break;//Else exit the loop
}

Console.WriteLine("Number matches! GAME OVER");//End game as numbers match


int PromptForAValue(string textMessage)//Class for asking for user input
{
    Console.Write(textMessage + ""); //Writing the text to screen user the string variable in class name.
    int number = Convert.ToInt32(Console.ReadLine());//Converting user input to int.
    return number; //Return number.
}
int PromptForNumberInRange(string textMessage, int minValue, int maxValue)//Class for determining if value is in range.
{
    while (true)//Loop until true
    {
        int number = PromptForAValue(textMessage);//Int variable with property of AskForNumber class with message.
        if (number >= minValue && number <= maxValue)//User has to enter a number between 0 and 100.
            return number;//Return number
    }

}
