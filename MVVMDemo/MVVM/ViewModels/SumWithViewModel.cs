using MVVMDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.ViewModels
{
	public class SumWithViewModel
	{
		public SumWithModel SumWithModel { get; set; }

		public SumWithViewModel()
		{
			this.SumWithModel = new SumWithModel();
		}

		public ICommand CalculateCommand =>new Command(() => { this.SumWithModel.Num3 = this.SumWithModel.Num1 + this.SumWithModel.Num2; });

	}
}
