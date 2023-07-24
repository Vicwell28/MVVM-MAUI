using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
	public class SumWithoutViewModel
	{
		public SumWithOutModel sumWithOutModel { set; get; }
		public ICommand CalculateCommand { get; }

		public SumWithoutViewModel()
		{
			this.sumWithOutModel = new SumWithOutModel();
			this.CalculateCommand = new Command(this.CalculateSum);
		}

		private void CalculateSum()
		{
			this.sumWithOutModel.Num3 = this.sumWithOutModel.Num1 + this.sumWithOutModel.Num2;
		}
	}
}
