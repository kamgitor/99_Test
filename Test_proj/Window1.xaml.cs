using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_proj
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		// *********************************************************************************************
		public Window1()
		{
			InitializeComponent();


			Test();

		}	// Window1


		// *********************************************************************************************
		public void Test()
		{
			CanSetClass test1 = new CanSetClass(5);
			const CanSetClass test2 = new CanSetClass(10);			// nie moge zrobic const instance
			// readonly CanSetClass test2 = new CanSetClass(10);
			
			// Size s = new Size(2, 3);
			// static readonly Size s = new Size(2, 3);
			
			string name = "Stefan";
			const string test_str = "Jozek";


			switch (name)
			{
			case "Staszek":
				break;

			case "Mietek":
				break;

			case test_str:
				break;
			}


			/*
			// to powinno dzialac jak uda sie zrobic const test2 instance ??????
			switch (test1)
			{
			case test2:

				break;
			}
			*/


		}	// Test

	}



	/// <summary>
	/// Klasa z przeciazonym operatorem przypisania
	/// </summary>
	public class CanSetClass
	{
		public int val;

		// *********************************************************************************************
		public CanSetClass(int v)
		{
			val = v;
		}


		// *********************************************************************************************
		/// <summary>
		/// przeciazony operator dodawania
		/// </summary>
		/// <param name="val1"></param>
		/// <param name="val2"></param>
		/// <returns></returns>
		public static CanSetClass operator + (CanSetClass val1, CanSetClass val2)
		{
			return new CanSetClass(val1.val + val2.val);
		
		}	// operator +


		// *********************************************************************************************
		/// <summary>
		/// przeciazony operator porownania
		/// </summary>
		/// <param name="val1"></param>
		/// <param name="val2"></param>
		/// <returns></returns>
		public static bool operator ==(CanSetClass val1, CanSetClass val2)
		{
			return val1.val == val2.val;
		
		}	// operator ==


		// *********************************************************************************************
		/// <summary>
		/// przeciazony operator if rozne
		/// </summary>
		/// <param name="val1"></param>
		/// <param name="val2"></param>
		/// <returns></returns>
		public static bool operator !=(CanSetClass val1, CanSetClass val2)
		{
			return val1.val != val2.val;

		}	// operator !=


	}	// CanSetClass




}
