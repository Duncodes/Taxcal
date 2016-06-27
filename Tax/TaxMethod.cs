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
			if (GrossAmmout <=0)
				return  "The Ammout is not taxable.";
			else if (GrossAmmout>0 && GrossAmmout <= 10165)
				return (1016*0.1).ToString ();
			else if (GrossAmmout > 10165 && GrossAmmout <= 19741)
				return ((1016 + (GrossAmmout-10164)*0.15).ToString ());
			else if (GrossAmmout > 19740 && GrossAmmout <= 29317)
				return ((2452 + (GrossAmmout-19741)*0.2).ToString ());
			else if (GrossAmmout >29316 && GrossAmmout <= 38893)
				return ((4367 +(GrossAmmout-29371)*0.25).ToString ());
			else if (GrossAmmout > 38892)
				return ((6761 + ((GrossAmmout -38893)* 0.3)).ToString ());
			else {
				return "The Ammout is not taxable.";
		}
	}
}

}
