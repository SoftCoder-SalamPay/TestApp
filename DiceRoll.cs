namespace TestApp;

public class DiceRoll
{
    public static void DiceEngine()
    {
        Random random = new();

        int dice1 = random.Next(1, 7);
        int dice2 = random.Next(1, 7);
        int dice3 = random.Next(1, 7);
        const int doubleScore = 2;
        const int tripleScore = 7;
        const int tresholdPoint = 15;

        PrintColoredOutput($" Dice 1: {dice1} \n Dice 2: {dice2} \n Dice 3: {dice3}");

        int totalRolled = dice1 + dice2 + dice3; // D1: 1, D2: 5, D3: 7
    
        if (dice1 == dice2 && dice1 == dice3)
        {
            totalRolled += tripleScore;
            Console.WriteLine($"You rolled a triple. You have been awarded +{tripleScore} points");
        }
        else if (dice1 == dice2 || dice2 == dice3 || dice1 == dice3)
        {
            totalRolled += doubleScore;
            Console.WriteLine($"You rolled a double. You have been awarded +{doubleScore} points");
        }

        string finalMessage = (totalRolled < tresholdPoint) ? $"Total Point: {totalRolled} - You failed to hit the threshold!" : $"Total Point: {totalRolled} - Welldone boss!";

        Console.WriteLine(finalMessage);
    }

    public static void PrintColoredOutput(string inputString)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(inputString);
        Console.ResetColor();
        Console.WriteLine();
    }

}
