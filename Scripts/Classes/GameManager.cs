using UnityEngine;

public class GameManager
{
    private Connect4Board theBoard;
    
    public GameManager()
    {
        this.theBoard = new Connect4Board();
    }

    public void play()
    {
        MoveResult result = this.theBoard.makeMove(2, "Red");
        do
        {
            result = this.theBoard.makeMove(2, "Red");
        }
        while (!result.success);

        //we have a successful move
        //check to see if that move was involved in a winning move!!!
        if(this.theBoard.isWinner(result))
        {
            //We have a winner, print to screen and end the game

        }
    }
}
