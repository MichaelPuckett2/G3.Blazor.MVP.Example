using BlazorModal;

using G3.Blazor.MVP.Example.MVP.Model;
using G3.Blazor.MVP.Example.MVP.View;

namespace G3.Blazor.MVP.Example.MVP.Presenter;

public class ModalPresenter
{
    private readonly IModalView modalView;
    private readonly ModalModel modalModel;

    public ModalPresenter(IModalView modalView, ModalModel modalModel)
    {
        this.modalView = modalView;
        this.modalModel = modalModel;
        this.modalView.LoadDataRequested += ModalView_LoadDataRequested;
    }

    private async void ModalView_LoadDataRequested(object? sender, EventArgs e)
    {
        modalView.IsLoadingData = true;
        await modalModel.LoadDataAsync();
        modalView.SomeData = modalModel.Strings;
        modalView.IsLoadingData = false;
    }
}
