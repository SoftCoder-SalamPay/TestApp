
do 
{
    DiceEngine();
    Console.WriteLine("Do you want to roll the dice again ? \nEnter 'Y' to continueor 'n' to Exit ");
    playerChoice =Console.ReadLineLine();
    while (playerChoice.ToUpper() != "Y" && playerChoice.ToUpper() != "N")
    {
        Console.WriteLine("Invalid Player choice  . Enter valid choice'Y'or 'N' ");
        playerChoice = Console.ReadLineLine();
    
    }
}while (playerChoice.ToUpper() == "Y");
 Console.WriteLine("Game over");
  