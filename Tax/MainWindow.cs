using System;
using Gtk;
using System.IO;
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
		Help.Text="This is a simple Tax Calculator.Just Enter income and the value of your tax is caculated.";
		save1.Clicked += new EventHandler (OnButtonSaveClicked);

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


	protected virtual void OnButtonSaveClicked(object sender, System.EventArgs e)
	{
		StreamWriter sw = new StreamWriter(TaxPayerName.Text+".txt");
		sw.Write(("The Tax Payable is "+TaxValue.Text).ToString());
		TaxValue.Text = "Saved to file !";
		sw.Close();
	}
}

	

		

