namespace SnakeAttempt2;

public class Snake
{
    public int XCoordinate = 1;
    public int YCoordinate = 1;
    public uint Length { get; private set; } = 3;

    public void Grow()
    {
        Length++;
    }
}