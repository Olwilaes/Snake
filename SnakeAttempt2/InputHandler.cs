namespace SnakeAttempt2;

public class InputHandler(DirectionSetter directionSetter)
{
    public void Handle(ConsoleKeyInfo keyInfo)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                directionSetter.Set(Direction.Up);
                break;
            case ConsoleKey.LeftArrow:
                directionSetter.Set(Direction.Left); 
                break;
            case ConsoleKey.DownArrow:
                directionSetter.Set(Direction.Down); 
                break;
            case ConsoleKey.RightArrow:
                directionSetter.Set(Direction.Right);
                break;
        }
    }
}