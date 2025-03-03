using System.Security.Cryptography.X509Certificates;
using KimTerrence_Activity2.resource;

namespace KimTerrence_Activity2;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
		InitializeComponent();
	}
		public void diplayData(string name, string col)
	{
		fullnamelbl.Text = "Fullname: " + name;
		collbl.Text = "College: " +col;
	}
    
}