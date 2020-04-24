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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Kontrola UC = new Kontrola();

		public MainWindow()
		{
			InitializeComponent();
			UC.Labela = "Nesto trece:";
			sp.Children.Add(UC);
		}

		private void Dohvati(object sender, RoutedEventArgs e)
		{
			MessageBox.Show(UC.Bla);
		}
	}
}
