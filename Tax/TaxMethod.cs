using System;
using Gtk;
namespace Tax
{
	public class TaxMethod
	{
		
		public TaxMethod ()
		{
			//Constractor

		}
		public String procedure(float GrossAmmout)
		{
			//Label taxValue = new Label ();
			if (GrossAmmout < 0)
				return  "The Ammout is not taxable.";
			else if (GrossAmmout <= 10165)
				return (1016).ToString ();
			else if (GrossAmmout <= 19741)
				return ((1016 + 1436).ToString ());
			else if (GrossAmmout <= 29317)
				return ((2452 + 1915).ToString ());
			else if (GrossAmmout <= 38893)
				return ((4367 + 2394).ToString ());
			else if (GrossAmmout > 38893)
				return ((6761 + ((4367 + 2394) * 0.3)).ToString ());
			else {
				return "The Ammout is not taxable.";
		}
	}
}

}
