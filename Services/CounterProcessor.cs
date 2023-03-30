using BlazorServer.Models;

namespace BlazorServer.Services;

public class CounterProcessor
{
    public event Action? OnChange;

    public Counter counter = new Counter();

    public void UpdateCounter(int currentCounter)
    {
        switch (currentCounter)
        {
            case 1:
                counter.Counter1 = counter.Counter1 + 1;
                Log(1, counter.Counter1);
                break;
            case 2:
                counter.Counter2 = counter.Counter1 + 1;
                Log(2, counter.Counter2);
                break;
            case 3:
                counter.Counter3 = counter.Counter2 + 1;
                Log(3, counter.Counter3);
                break;
            case 4:
                counter.Counter4 = counter.Counter3 + 1;
                Log(4, counter.Counter4);
                break;
        }

        NotifyStateChanged();
    }

    private void Log(int currentCounter, int value)
    {
        counter.Log.Append(Environment.NewLine);
        counter.Log.Append($"Dynamic Component {currentCounter} is starting – Counter {value - 1}");
        counter.Log.Append(Environment.NewLine);
        counter.Log.Append($"Dynamic Component {currentCounter} is finishing – Counter {value}");
        counter.Log.Append(Environment.NewLine);
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}
