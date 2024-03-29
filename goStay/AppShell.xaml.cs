﻿using System.Windows.Input;
using goStay.Views;
namespace goStay;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public AppShell()
    {
        InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routes.Add("monkeydetails", typeof(MonkeyDetailPage));
        Routes.Add("beardetails", typeof(BearDetailPage));
        Routes.Add("catdetails", typeof(CatDetailPage));
        Routes.Add("dogdetails", typeof(DogDetailPage));
        Routes.Add("elephantdetails", typeof(ElephantDetailPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }
}
