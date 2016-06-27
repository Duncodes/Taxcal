using System;
using Gtk;
using System.IO;
using Tax;
public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel){
		Build ();

		//onclick event for find object
		find.Clicked += new EventHandler (OnButtonFindClicked);
		var buffer = System.IO.File.ReadAllBytes ("./img/info.png");
		var pixbuf = new Gdk.Pixbuf (buffer);
		image.Pixbuf = pixbuf;
		Help.Text="This is a simple Tax Calculator.\nJust Enter income and the value of \nyour tax is caculated and then you \n can save it in cvs file(comman separated\nvalues";
		save1.Clicked += new EventHandler (OnButtonSaveClicked);

	}



	//Close window event handler 	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}


	//onclick  find tax Handler handler
	void OnButtonFindClicked (object obj, EventArgs args){
		float GrossAmmout=0;
		try{
			GrossAmmout=float.Parse(data.Text);
			TaxMethod tax = new  TaxMethod ();
			TaxValue.Text = tax.procedure (GrossAmmout);
			TaxValue1.Text="The Value of Tax is: ";

		}catch(FormatException){
			TaxValue.Text ="The Value "+ data.Text +" is not a number.Try Numbers only";
			TaxValue1.Text="Error";
		}catch(OverflowException e){
			TaxValue.Text = "Unreasonable salary ammount please enter your actual salary";
			Console.WriteLine (e.StackTrace);
		}
	}


	void OnButtonSaveClicked(object sender, System.EventArgs e)
	{
		try{
			float value=float.Parse(TaxValue.Text);
			Console.WriteLine (value);

			if ((TaxPayerName.Text).ToString() == "Enter Tax Payer Name.") {
				TaxValue1.Text =  "You must Enter Tax Payer name";
				TaxValue.Text="Please Enter Valid Name.";
			}else{
				Console.WriteLine(TaxPayerName.Text.ToString());
				StreamWriter sw = new StreamWriter ("./DataFiles/"+TaxPayerName.Text + ".csv");
				sw.Write (("Name,Tax\n"+TaxPayerName.Text.ToString() +","+ TaxValue.Text).ToString ());
				TaxValue.Text = "Saved to" +TaxPayerName.Text.ToString()+".csv.!";
				TaxValue1.Text="Thanks";
				sw.Close ();
			}
		} catch(FormatException){
			TaxValue.Text = "Tax Must be Computed First.";
		}
	}
}
