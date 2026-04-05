namespace SnakeAttempt2;

public class Game
{
    private KeyboardWatcher _keyboardWatcher;
    private Snake _snake;
    private SnakeMover _snakeMover;
    private Gameboard _gameboard;
    
    public void Start()
    {
        Console.CursorVisible = false;

        _keyboardWatcher = new KeyboardWatcher();
        var directionSetter = new DirectionSetter();
        var inputHandler = new InputHandler(directionSetter);

        _snake = new Snake();
        _snakeMover = new SnakeMover(directionSetter, _snake);
        var tailHandler = new TailHandler(_snake);
        var snakeRenderer = new SnakeRenderer(tailHandler);
        var tailCollisionDetector = new TailCollisionDetector(tailHandler);

        _gameboard = new Gameboard(40, 10);
        var borderCollisionDetector = new BorderCollisionDetector(_gameboard);
        var gameboardRenderer = new GameboardRenderer(_gameboard);

        var foodFactory = new FoodFactory(_gameboard);
        var foodRepository = new FoodRepository(foodFactory);
        var foodCollisionDetector = new FoodCollisionDetector(foodRepository);
        var foodHandler = new FoodHandler(foodRepository, foodFactory);
        var foodRenderer = new FoodRenderer(foodRepository);
    
        _keyboardWatcher.OnKeyPressed += inputHandler.Handle;

        _snakeMover.OnSnakeMoved += snakeRenderer.Render;
        _snakeMover.OnSnakeMoved += foodCollisionDetector.Check;
        _snakeMover.OnSnakeMoved += borderCollisionDetector.Check;
        _snakeMover.OnSnakeMoved += tailHandler.Update;
        _snakeMover.OnSnakeMoved += tailCollisionDetector.Check;

        foodCollisionDetector.OnFoodEaten += _snake.Grow;
        foodCollisionDetector.OnFoodEaten += foodHandler.Handle;
        foodCollisionDetector.OnFoodEaten += foodRenderer.Render;

        borderCollisionDetector.OnBorderHit += RenderGameOver;
        tailCollisionDetector.OnTailHit += RenderGameOver;

        foodRenderer.Render();
        gameboardRenderer.Render();

        _keyboardWatcher.Start();
        _snakeMover.Start();
    }

    public void RenderGameOver()
    {
        Console.SetCursorPosition(0, _gameboard.Height + 2);

        Console.WriteLine("GAME OVER");
        Console.WriteLine("Score: " + _snake.Length);
        
        _keyboardWatcher.Stop();
        _snakeMover.Stop();
    }
}