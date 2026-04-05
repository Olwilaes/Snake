namespace SnakeAttempt2;

public interface ICollisionDetector
{
    public void Check((int X, int Y) coordinates);
}