using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
	public class CommandsViewModel
	{
		public ICommand clickCommand { get; }
		public ICommand serachCommand { get; }

		public CommandsViewModel() 
		{
			this.clickCommand = new Command(showAlert);
			this.serachCommand = new Command<string>(this.searchAlert);
		}

		private void showAlert()
		{
			App.Current.MainPage.DisplayAlert("Titel", "Message", "Ok");
		}

		private void searchAlert(string text)
		{
			App.Current.MainPage.DisplayAlert(text, "message", "ok");
		}
	}
}
