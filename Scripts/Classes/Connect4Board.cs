using Mono.Cecil;
using UnityEngine;

public class Connect4Board
{
    private Checker[][] theBoard;
    private int row = 6; //Legal Rows are 0-6
    private int column = 7; //Legal Columns are 0-7 

    public Connect4Board()
    {
        this.theBoard = new Checker[this.row][];
        for(int i = 0; i < this.theBoard.Length; i++)
        {
            this.theBoard[i] = new Checker[this.column];
        }
    }

    public bool isWinner(MoveResult)
    {
        //check to see if result was involved in a horizontal, vertical, or diagonal win
        //return true if yes, and false if no

    }

    public MoveResult makeMove(int column, string color)
    {
        MoveResult result = new MoveResult();

        if(column < 0 || column > this.column - 1)
        {
            return result; //invalid column
        }

        if (this.theBoard[0][column] != null)
        {
            return result; //Column is full
        }

        //a legal move and room for a new checker, so drop the checker onto the board
        for (int i = this.row - 1; i >= 0; i--) //start bottom row and work up
        {
            if (this.theBoard[i][column] == null)
            {
                this.theBoard[i][column] = new Checker(color);
                result.success = true;
                result.row = i;
                result.column = column;
                result.color = color;
                break;
            }
        }
        return result;
    }
}
