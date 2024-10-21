using System;

class TicTacToe
{
    static char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
    static char currentPlayer = 'X';
    static bool isGameOver = false; 
    static int movesCount = 0;

    static void Main(string[] args)
    {
        while (!isGameOver)
        {
            Console.Clear();
            DrawBoard();
            PlayerMove();
            CheckForWinner();
            ChangePlayer();
        }

        Console.Clear();
        DrawBoard();
        Console.WriteLine("Game Over!");
    }

    static void DrawBoard()
    {
        Console.WriteLine(" 0 | 1 | 2 ");
        Console.WriteLine("---|---|---");
        Console.WriteLine(" 3 | 4 | 5 ");
        Console.WriteLine("---|---|---");
        Console.WriteLine(" 6 | 7 | 8 ");
        Console.WriteLine();
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine("--|---|--");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    static void PlayerMove()
    {
        int move;
        bool validMove = false;

        while (!validMove)
        {
            Console.WriteLine($"Player {currentPlayer}, enter a number (0-8):");
            move = Convert.ToInt32(Console.ReadLine());

            if (move >= 0 && move <= 8 && board[move] == ' ')
            {
                board[move] = currentPlayer;
                validMove = true;
                movesCount++;
            }
            else
            {
                Console.WriteLine("Invalid move! Try again.");
            }
        }
    }

    static void CheckForWinner()
    {
        int[][] winPatterns = {
            new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8}, 
            new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8}, 
            new int[] {0, 4, 8}, new int[] {2, 4, 6}                       
        };

        foreach (var pattern in winPatterns)
        {
            if (board[pattern[0]] == currentPlayer && board[pattern[1]] == currentPlayer && board[pattern[2]] == currentPlayer)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                isGameOver = true;
                return;
            }
        }

        if (movesCount == 9)
        {
            Console.WriteLine("It's a draw!");
            isGameOver = true;
        }
    }

    static void ChangePlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}
