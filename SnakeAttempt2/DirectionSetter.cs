namespace SnakeAttempt2;

public class DirectionSetter()
{
    public Direction CurrentDirection { get; private set; } = Direction.Right;

    public void Set(Direction inputDirection)
    {
        CurrentDirection = inputDirection;
    }
}