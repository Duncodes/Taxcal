using System;
using Gtk;
namespace Tax
{
	public class TaxMethod
	{
		
		public TaxMethod ()
		{
			
		}
		public String procedure(float GrossAmmout)
		{
			Label taxValue = new Label ();
			if (GrossAmmout < 0)
				return taxValue.Text = "The Ammout is not taxable";
			else if (GrossAmmout <= 10165)
				return taxValue.Text = (1016).ToString ();
			else if (GrossAmmout <= 19741)
				return taxValue.Text = ((1016 + 1436).ToString ());
			else if (GrossAmmout <= 29317)
				return taxValue.Text = ((2452 + 1915).ToString ());
			else if (GrossAmmout <= 38893)
				return taxValue.Text = ((4367 + 2394).ToString ());
			else if (GrossAmmout > 38893)
				return taxValue.Text = ((6761 + ((4367 + 2394) * 0.3)).ToString ());
			else {
				Console.WriteLine ();
				return taxValue.Text = "The Ammout is not taxable";
		}
	}
}

}
