using System.Runtime.CompilerServices;
using Prism.Mvvm;

namespace DemoBindings.Mvvm;

public abstract class ViewModelBase : BindableBase
{
    protected T GetValue<T>([CallerMemberName] string propertyName = null)
    {
        if (_values.ContainsKey(propertyName))
        {
            return (T)_values[propertyName];
        }

        return default(T);
    }

    protected void SetValue<T>(T value, [CallerMemberName] string propertyName = null)
    {
        _values[propertyName] = value;
        RaisePropertyChanged(propertyName);
    }
    private Dictionary<string, object> _values = new();
}