using System;
using System.Net;

namespace RoPaSci
{
    public class Program
    {

        GameStatus draw = Enum.Parse<GameStatus>("Draw");
        GameStatus player1Win = Enum.Parse<GameStatus>("Player1Wins");
        GameStatus player2Win = Enum.Parse<GameStatus>("Player2Wins");

        GameItem rock = Enum.Parse<GameItem>("Rock");
        GameItem scissors = Enum.Parse<GameItem>("Scissors");

        GameItem paper = Enum.Parse<GameItem>("Paper");

        private static void Main(string[] args)
        {



            int result = (int)RockPaperScissors(GameItem.Rock, GameItem.Paper);



            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }



        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {

            GameStatus status;
            
            if (player1 == player2)
            {
                status = GameStatus.Draw; // Draw
            }
            if (((player1 == GameItem.Rock) && (player2 == GameItem.Scissors)) ||
                ((player1 == GameItem.Scissors) && (player2 == GameItem.Paper)) ||
                ((player1 == GameItem.Paper) && (player2 == GameItem.Rock)))
            {
                status = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                status = GameStatus.Player2wins; // Player 2 wins
            }
            return status;
        }
    }
}
