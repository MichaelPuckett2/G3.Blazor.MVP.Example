using G3.Blazor.MVP.Example;
using G3.Blazor.MVP.Example.MVP.Model;
using G3.Blazor.MVP.Example.MVP.Presenter;
using G3.Blazor.MVP.Example.MVP.View;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services
    .AddSingleton<SampleModel>() //Model
    .AddSingleton<ISampleView, SampleView>() //View
    .AddSingleton<SamplePresenter>(); //Presenter

builder.Services
    .AddSingleton<ModalModel>() //Model
    .AddSingleton<IModalView, ModalView>() //View
    .AddSingleton<ModalPresenter>(); //Presenter

var host = builder.Build();

//The hack to init Presenters
host.Services.GetService<SamplePresenter>(); 
host.Services.GetService<ModalPresenter>();

await host.RunAsync();
