namespace SnakeAttempt2;

public class SnakeRenderer(TailHandler tailHandler)
{
    public void Render((int x, int y) coordinates)
    {
        Console.SetCursorPosition(coordinates.x, coordinates.y);
        Console.Write('#');
        
        if (tailHandler.possibleLastMember != null)
        {
            Console.SetCursorPosition(tailHandler.possibleLastMember.Value.X, tailHandler.possibleLastMember.Value.Y);
            Console.Write(' ');
        }
    }
}