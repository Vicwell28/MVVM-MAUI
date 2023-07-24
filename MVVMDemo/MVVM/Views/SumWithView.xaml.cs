using MVVMDemo.MVVM.ViewModels;

namespace MVVMDemo.MVVM.Views;

public partial class SumWithView : ContentPage
{
	public SumWithView()
	{
		InitializeComponent();
		this.BindingContext = new SumWithViewModel();
	}
}