namespace G3.Blazor.MVP.Example.MVP.Model;

public class ModalModel
{
    private IList<string> strings = new List<string>();
    public IEnumerable<string> Strings => strings.ToList().AsReadOnly();

    public async Task LoadDataAsync()
    {
        await Task.Delay(3000); //pretend to load
        strings = new List<string>
        {
            "Some",
            "more",
            "data",
            "to",
            "show"
        };
        await Task.Yield();
    }
}
