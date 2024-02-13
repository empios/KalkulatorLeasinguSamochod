using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Media;
using ReactiveUI;

namespace KalkulatorLeasinguSamochod.ViewModels;

public class MainViewModel : ViewModelBase
{
	private float _nettoCarValue = 0;
	private float _nettoLeasingRateValue = 0;
	private ComboBoxItem _selectedPercentage = new ComboBoxItem { Content = "50%", Tag = 0.5 };
	private double _finalValue = 0;
	private double _finalNonCalculatedValue = 0;

	public ComboBoxItem SelectedPercentage
	{
		get => _selectedPercentage;
		set => this.RaiseAndSetIfChanged(ref _selectedPercentage, value);
	}

	public float NettoCarValue
	{
		get => _nettoCarValue;
		set => this.RaiseAndSetIfChanged(ref _nettoCarValue, value);
	}

	public double FinalValue
	{
		get => _finalNonCalculatedValue;
		set => this.RaiseAndSetIfChanged(ref _finalNonCalculatedValue, value);
	}

	public double FinalNonCalculatedValue
	{
		get => _finalValue;
		set => this.RaiseAndSetIfChanged(ref _finalValue, value);
	}

	public float NettoLeasingRateValue
	{
		get => _nettoLeasingRateValue;
		set => this.RaiseAndSetIfChanged(ref _nettoLeasingRateValue, value);
	}

}
