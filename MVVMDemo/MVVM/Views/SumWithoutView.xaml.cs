using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class SumWithoutView : ContentPage
{
	public SumWithoutView()
	{
		InitializeComponent();

		this.BindingContext = new SumWithoutViewModel();
	}
}