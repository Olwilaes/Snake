namespace SnakeAttempt2;

public class FoodFactory(Gameboard gameboard)
{
    private readonly Random _random = new Random();
    
    public Food Spawn()
    {
        int x = _random.Next(1, gameboard.Width);
        int y = _random.Next(1, gameboard.Height);

        return new Food(x, y);
    }
}