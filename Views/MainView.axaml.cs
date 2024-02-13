using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using KalkulatorLeasinguSamochod.ViewModels;
using System;

namespace KalkulatorLeasinguSamochod.Views;

public partial class MainView : UserControl
{
	MainViewModel dataView = new MainViewModel();
	private static double VAT_CONST = 0.23;
	private static double MAX_CAR_VALUE = 150000;

	public MainView()
	{
		InitializeComponent();
		this.DataContext = dataView;
	}

	private void Binding(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
	{
	}

	public void CalculateClickHandler(object sender, RoutedEventArgs args)
	{
		//DataSet
		string Tag = dataView.SelectedPercentage.Tag?.ToString() ?? "";
		double nettoCarValue = dataView.NettoCarValue;
		double carVatValue = nettoCarValue * VAT_CONST;
		float vatPercentage = float.Parse(Tag);
		double leasingRateNetto = dataView.NettoLeasingRateValue;
		double leasingRateVat = leasingRateNetto * VAT_CONST;

		//Calculation
		double initialCarValue = nettoCarValue + (carVatValue * vatPercentage);
		double lesingNonRateVat = leasingRateVat * vatPercentage;
		double nonCalculatedVatRate = leasingRateNetto + lesingNonRateVat;
		double finishedPayRate = nonCalculatedVatRate * MAX_CAR_VALUE / initialCarValue;

		dataView.FinalNonCalculatedValue = nonCalculatedVatRate;
		dataView.FinalValue = finishedPayRate;

	}
}
