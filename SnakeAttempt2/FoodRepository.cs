namespace SnakeAttempt2;

public class FoodRepository(FoodFactory foodFactory)
{
    public Food Current { get; set; } = foodFactory.Spawn();
}