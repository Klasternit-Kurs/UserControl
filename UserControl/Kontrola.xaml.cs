using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControldsa
{
	/// <summary>
	/// Interaction logic for Kontrola.xaml
	/// </summary>
	public partial class Kontrola : UserControl
	{
		public string Bla { get; set; }
		public string Labela { get; set; } = "Nesto drugo:";
		public Kontrola()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void Test(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(Bla);
		}
	}
}
