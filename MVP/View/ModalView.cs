using System.ComponentModel;

namespace G3.Blazor.MVP.Example.MVP.View;

public class ModalView : IModalView, INotifyPropertyChanged
{
    private bool isLoadingData;

    public event PropertyChangedEventHandler? PropertyChanged = default!;
    public event EventHandler<EventArgs> LoadDataRequested = default!;
    public void RequestData() => LoadDataRequested?.Invoke(this, EventArgs.Empty);
    public IEnumerable<string> SomeData { get; set; } = new List<string>();

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
