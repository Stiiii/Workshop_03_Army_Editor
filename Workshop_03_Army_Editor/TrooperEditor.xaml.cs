using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Workshop_03_Army_Editor
{
	/// <summary>
	/// Interaction logic for TrooperEditor.xaml
	/// </summary>
	public partial class TrooperEditor : Window
	{
		public TrooperEditor()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			foreach (var item in stack.Children)
			{
				if (item is TextBox tb)
				{
					tb.GetBindingExpression(TextBox.TextProperty).UpdateSource();
				}
			}
			this.DialogResult = true;
		}
	}
}
