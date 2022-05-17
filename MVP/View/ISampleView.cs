namespace G3.Blazor.MVP.Example.MVP.View;

public interface ISampleView
{
    IEnumerable<string> SomeData { get; set; }
    event EventHandler<EventArgs> LoadDataRequested;
    void RequestData();
    bool IsLoadingData { get; set; }
}

