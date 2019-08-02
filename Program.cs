using System;

namespace MyGame
{
  class Program
  {
    static void Main(string[] args)
    {
      /* 
      1. Computer prompts with 3 choices
      2. User Input
      3. Computer randomizes 3 choices
      4. There will be 3 tries
        4a. if user loses, computer wins
        4b. if computer loses, user wins
      5. total the amount of wins and loses  
      6. Play again? 
      7. Quit game at any point
       */
      Console.Clear();

      #region info
      void displayPic()
      {
        Console.WriteLine(@" 
      =============================
      　　      ＿＿_＿＿
　            ／ 　／  ／|
      　      |￣￣￣￣| |
     　       | 　  　 |／
　              ￣￣￣￣
       
           Let's play a game!

  　            _∧＿∧＿
　　         ／(´･ω･`) ／＼ 
　          ／| ￣￣￣|＼／
              |　 　  |／
　             ￣￣￣￣
      ==============================
           Type QUIT to end Game

      ");
      }

      string inputHuman;
      int compChoice;

      int humanScore = 0;
      int compScore = 0;

      bool playAgain = true;

      #endregion

      void displayScore()
      {
        System.Console.WriteLine($"Human: {humanScore} " + $"Computer: {compScore} \n\n");
      }


      while (playAgain == true)
      {


        Console.WriteLine(@" 
      =============================
      　　      ＿＿_＿＿
　            ／ 　／  ／|
      　      |￣￣￣￣| |
     　       | 　  　 |／
　              ￣￣￣￣
       
           Let's play a game!

  　            _∧＿∧＿
　　         ／(´･ω･`) ／＼ 
　          ／| ￣￣￣|＼／
              |　 　  |／
　             ￣￣￣￣
      ==============================

      ");
        while (humanScore < 3 && compScore < 3)
        {

          Console.Write("Choose between ROCK, PAPER, OR SCISSORS:  ");
          inputHuman = Console.ReadLine().ToLower();
          Random rnd = new Random();
          Console.Clear();
          compChoice = rnd.Next(0, 3); //0: rock 1: paper, 2: scissors
          displayPic();

          switch (inputHuman)
          {
            case "rock":
              if (compChoice == 0)
              {
                System.Console.WriteLine("I chose ROCK too! It's a draw!\n\nLet's try again\n\n");
              }
              else if (compChoice == 2)
              {
                System.Console.WriteLine("HAH! I chose PAPER - You lose!\n\n");
                compScore++;
              }
              else if (compChoice == 1)
              {
                System.Console.WriteLine("Dang! I chose SCISSORS - Nicely done!\n\n");
                humanScore++;
              }
              break;
            case "paper":
              if (compChoice == 1)
              {
                System.Console.WriteLine("I chose PAPER too! It's a draw!\n\nLet's try again\n\n");
              }
              else if (compChoice == 2)
              {
                System.Console.WriteLine("HAH! I chose SCISSORS - You lose!\n\n");
                compScore++;
              }
              else if (compChoice == 0)
              {
                System.Console.WriteLine("Dang! I chose ROCK - Nicely done!\n\n");
                humanScore++;
              }
              break;

            case "scissors":
              if (compChoice == 2)
              {
                System.Console.WriteLine("I chose SCISSORS too! It's a draw!\n\nLet's try again\n\n");
              }
              else if (compChoice == 1)
              {
                System.Console.WriteLine("HAH! I chose ROCK - You lose!\n\n");
                compScore++;
              }
              else if (compChoice == 0)
              {
                System.Console.WriteLine("Dang! I chose PAPER - Nicely done!\n\n");
                humanScore++;
              }
              break;
            case "quit":
              System.Console.WriteLine("Thanks for playing! - Goodbye!\n");
              playAgain = false;
              return;
            default:
              System.Console.WriteLine("Don't be silly, you know that isn't an option!\n\n");
              break;
          }
          displayScore();

        }
        Console.Clear();
        displayPic();
        displayScore();

        if (humanScore == 3)
        {
          System.Console.WriteLine("\nCONGRATULATIONS! You won!\n\nGood game!\n\n");
        }
        else if (compScore == 3)
        {
          System.Console.WriteLine("\nHah I WON! Sucks to be you... Better luck next time\n\nGood game though!\n\n");
        }

        System.Console.WriteLine("Do you want to play again? (yes/no)\n");
        string newGame = Console.ReadLine().ToLower();
        if (newGame == "yes")
        {
          playAgain = true;
          humanScore = 0;
          compScore = 0;
          System.Console.Clear();
        }
        else if (newGame == "no")
        {
          System.Console.WriteLine("Thanks for playing! - Goodbye!\n");
          playAgain = false;
        }

      }
    }
  }
}