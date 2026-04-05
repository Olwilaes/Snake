namespace SnakeAttempt2;

public class FoodHandler(FoodRepository foodRepository, FoodFactory foodFactory)
{
    public event Action<(int x, int y)> OnFoodSpawned;
    
    public void Handle()
    {
        foodRepository.Current = foodFactory.Spawn();
        OnFoodSpawned?.Invoke((foodRepository.Current.XCoordinate, foodRepository.Current.YCoordinate));
    }
}