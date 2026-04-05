namespace SnakeAttempt2;

public class TailHandler(Snake snake)
{
    public (int X, int Y)? possibleLastMember { get; private set; }
    
    public Queue<(int X, int Y)> tailMembers { get; private set; } = new Queue<(int X, int Y)>();

    public void Update((int X, int Y) coordinates)
    {
        tailMembers.Enqueue(coordinates);
        
        if (snake.Length <= tailMembers.Count)
        {
            possibleLastMember = tailMembers.Dequeue();
        }
        else
        {
            possibleLastMember = null;
        }
    }
}