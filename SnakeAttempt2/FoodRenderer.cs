namespace SnakeAttempt2;

public class FoodRenderer(FoodRepository foodRepository)
{
    public void Render()
    {
        Console.SetCursorPosition(foodRepository.Current.XCoordinate, foodRepository.Current.YCoordinate);
        Console.Write('*');
        
        
    }
}