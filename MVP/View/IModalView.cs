namespace G3.Blazor.MVP.Example.MVP.View;

public interface IModalView
{
    bool IsLoadingData { get; set; }
    IEnumerable<string> SomeData { get; set; }
    event EventHandler<EventArgs> LoadDataRequested;
    void RequestData();
}