namespace SnakeAttempt2;

public class TailCollisionDetector(TailHandler tailHandler) : ICollisionDetector
{
    public event Action OnTailHit;
    
    public void Check((int X, int Y) coordinates)
    {
        foreach (var tailMember in tailHandler.tailMembers.SkipLast(1))
        {
            if (coordinates.X == tailMember.X && coordinates.Y == tailMember.Y)
            {
                OnTailHit?.Invoke();
            }
        }
    }
}