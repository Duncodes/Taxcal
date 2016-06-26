using System;
using Gtk;
using Tax;
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel){
		Build ();

		//onclick event for find object
		find.Clicked += new EventHandler (OnButtonClicked);
		var buffer = System.IO.File.ReadAllBytes ("./img/info.png");
		var pixbuf = new Gdk.Pixbuf (buffer);
		image.Pixbuf = pixbuf;
		Help.Text="This is a simple Tax Calculator.Just Enter income and the vale of your tax is caculated.";

	}



	//Close window event handler 	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}


	//onclick handler
	void OnButtonClicked (object obj, EventArgs args){
		float GrossAmmout=0;
		try{
			GrossAmmout=float.Parse(data.Text);
			TaxMethod tax = new  TaxMethod ();
			TaxValue.Text = tax.procedure (GrossAmmout);
			TaxValue1.Text="The Value of Tax is: ";

		}catch(FormatException){
			TaxValue.Text ="The Value "+ data.Text +" is not a number.Try Numbers only";

		}

	}
}

	

		

