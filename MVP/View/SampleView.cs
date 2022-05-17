using System.ComponentModel;

namespace G3.Blazor.MVP.Example.MVP.View;

public class SampleView : ISampleView, INotifyPropertyChanged
{
    private bool isLoadingData;
    public IEnumerable<string> SomeData { get; set; } = new List<string>();
    public event EventHandler<EventArgs> LoadDataRequested = default!;
    public event PropertyChangedEventHandler? PropertyChanged;
    public void RequestData() => LoadDataRequested?.Invoke(this, EventArgs.Empty);

    public bool IsLoadingData
    {
        get => isLoadingData;
        set
        {
            isLoadingData = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoadingData)));
        }
    }
}
