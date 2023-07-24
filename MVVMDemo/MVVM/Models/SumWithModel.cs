using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]
	public class SumWithModel
	{
		public int Num1 { get; set; }
		public int Num2 { get; set; }
		public int Num3 { get; set; }
	}
}
