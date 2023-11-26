using DemoBindings.Mvvm;
using Prism.Mvvm;

namespace DemoBindings;

public class MainWindowViewModel : ViewModelBase
{
    public string OneWay
    {
        get => GetValue<string>();
        set => SetValue(value);
    }

    public string TwoWay
    {
        get => GetValue<string>();
        set => SetValue(value);
    }

    public string OneWayToSource
    {
        get => GetValue<string>();
        set => SetValue(value);
    }
}