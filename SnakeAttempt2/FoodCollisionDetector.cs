namespace SnakeAttempt2;

public class FoodCollisionDetector(FoodRepository foodRepository) : ICollisionDetector
{
    public event Action? OnFoodEaten;
    
    public void Check((int X, int Y) coordinates)
    {
        if (coordinates.X == foodRepository.Current.XCoordinate && coordinates.Y == foodRepository.Current.YCoordinate)
        {
            OnFoodEaten.Invoke();
        }
    }
}