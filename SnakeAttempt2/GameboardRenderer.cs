namespace SnakeAttempt2;

public class GameboardRenderer(Gameboard gameboard)
{
    public void Render()
    {
        for (int i = 0; i < gameboard.Width; i++)
        {
            Console.SetCursorPosition(i, 0);
            Console.Write('+');
        }
        for (int i = 0; i < gameboard.Width; i++)
        {
            Console.SetCursorPosition(i, gameboard.Height);
            Console.Write('+');
        }
        for (int i = 0; i < gameboard.Height; i++)
        {
            Console.SetCursorPosition(0, i);
            Console.Write('+');
        }
        for (int i = 0; i < gameboard.Height; i++)
        {
            Console.SetCursorPosition(gameboard.Width, i);
            Console.Write('+');
        }
    }
    
}