using System;

class MainClass {
  public static void Main (string[] args) {
    // Greet User
    Console.WriteLine("Welcome to Rock, Paper, Scissors");

    // Prompt User To Select Rock, Paper, or Scissors
    Console.Write("Pick Rock, Paper, or Scissors: ");
    string userSelection = Console.ReadLine();

    //Random Selection
    Random random = new Random();
    int computerSelection = random.Next(0, 3);

    //winner determiner
    if (userSelection == "rock" && computerSelection == 0) {
        Console.WriteLine("Computer throws rock... Tie Game.");
    } else if (userSelection == "rock" && computerSelection == 1) {
        Console.WriteLine("Computer throws paper... You Lose.");
    } else if (userSelection == "rock" && computerSelection == 2) {
        Console.WriteLine("Computer throws scissors... You Win!");
    } else if (userSelection == "paper" && computerSelection == 0){
        Console.WriteLine("Computer throws rock... You Win!");
    } else if (userSelection == "paper" && computerSelection == 1){
        Console.WriteLine("Computer throws paper... Tie Game.");
    } else if (userSelection == "paper" && computerSelection == 2){
        Console.WriteLine("Computer throws scissors... You Lose.");
    } else if (userSelection == "scissors" && computerSelection == 0){
        Console.WriteLine("Computer throws rock... You Lose.");
    } else if (userSelection == "scissors" && computerSelection == 1){
        Console.WriteLine("Computer throws paper... You Win!");
    } else if (userSelection == " scissors" && computerSelection == 2){
        Console.WriteLine("Computer throws scissors... Tie Game.");
    }
  }
}
