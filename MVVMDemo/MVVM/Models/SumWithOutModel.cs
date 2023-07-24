using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.MVVM.Models
{
	public class SumWithOutModel: INotifyPropertyChanged
	{
		private int num1;
		private int num2;
		private int num3;

		public int Num1
		{
			get => num1; set
			{
				num1 = value;
				OnPropertyChanged();
			}
		}
		public int Num2
		{
			get => num2; set
			{
				num2 = value;
				OnPropertyChanged();
			}
		}
		public int Num3
		{
			get => num3; set
			{
				num3 = value;
				OnPropertyChanged();
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
