using G3.Blazor.MVP.Example.MVP.Model;
using G3.Blazor.MVP.Example.MVP.View;

namespace G3.Blazor.MVP.Example.MVP.Presenter;

public class SamplePresenter
{
    private readonly ISampleView sampleView;
    private readonly SampleModel sampleModel;

    public SamplePresenter(ISampleView sampleView, SampleModel sampleModel)
    {
        this.sampleView = sampleView;
        this.sampleModel = sampleModel;
        this.sampleView.LoadDataRequested += SampleView_LoadDataRequested;
    }

    private async void SampleView_LoadDataRequested(object? sender, EventArgs e)
    {
        sampleView.IsLoadingData = true;
        await sampleModel.LoadDataAsync();
        sampleView.SomeData = sampleModel.Strings;
        sampleView.IsLoadingData = false;
    }
}
