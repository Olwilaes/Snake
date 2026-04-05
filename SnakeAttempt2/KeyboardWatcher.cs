namespace SnakeAttempt2;

public class KeyboardWatcher
{
    public event Action<ConsoleKeyInfo>? OnKeyPressed;
    
    private bool _running;
    
    public void Watch()
    {
        while (_running)
        {
            var keyInfo = Console.ReadKey(true);

            OnKeyPressed?.Invoke(keyInfo);
        }
    }

    public void Start()
    {
        _running = true;
        new Thread(Watch).Start();
    }

    public void Stop()
    {
        _running = false;
    }
}