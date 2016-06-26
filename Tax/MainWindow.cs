using System;
using Gtk;
using Tax;
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel){
		Build ();

		find.Clicked += new EventHandler (OnButtonClicked);

	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}
	void OnButtonClicked (object obj, EventArgs args){
		float  GrossAmmout= float.Parse(data.Text);
		//TaxValue.Text="Hi";
		TaxMethod tax =new  TaxMethod();
		TaxValue.Text=tax.procedure (GrossAmmout);
		}
		}

	

		

