using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace JRMobileAppExperiments
{
	class TabsPagerAdapter 
		: FragmentPagerAdapter
	{
		public TabsPagerAdapter (Android.Support.V4.App.FragmentManager fm) : base (fm)
		{
		}


		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			switch (position) {

			case 0:
				return new HomeTab ();
			case 1:
				return new SearchTab ();
			case 2:
				return new RecentSearchesTab ();
			}

			return null;
		}

		public override int Count {
			get {
				return 3;
			}
		}
	}
}

