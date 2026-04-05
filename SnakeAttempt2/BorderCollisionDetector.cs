namespace SnakeAttempt2;

public class BorderCollisionDetector(Gameboard gameboard) : ICollisionDetector
{
    public event Action? OnBorderHit;

    public void Check((int X, int Y) coordinates)
    {
        if (coordinates.X == 0 || coordinates.Y == 0 || coordinates.X == gameboard.Width ||
            coordinates.Y == gameboard.Height)
        {
            OnBorderHit?.Invoke();
        }
    }
} 