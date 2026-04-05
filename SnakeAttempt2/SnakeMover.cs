namespace SnakeAttempt2;

public class SnakeMover(DirectionSetter directionSetter, Snake snake)
{
    private bool _running;
    public event Action<(int X, int Y)> OnSnakeMoved;
    
    public void Move()
    {
        while (_running)
        {
            switch (directionSetter.CurrentDirection)
            {
                case Direction.Up:
                    snake.YCoordinate--;
                    break;
                case Direction.Left:
                    snake.XCoordinate--;
                    break;
                case Direction.Down:
                    snake.YCoordinate++;
                    break;
                case Direction.Right:
                    snake.XCoordinate++;
                    break;
            }
            OnSnakeMoved.Invoke((snake.XCoordinate, snake.YCoordinate));
            Thread.Sleep(200);   
        }
    }

    public void Start()
    {
        new Thread(Move).Start();
        _running = true;
    }

    public void Stop()
    {
        _running = false;
    }
}