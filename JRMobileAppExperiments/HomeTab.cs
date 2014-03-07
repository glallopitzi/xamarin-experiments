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

namespace JRMobileAppExperiments
{
	public class HomeTab : BaseFragment
	{
		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.Home, container, false);

			var adMob = view.FindViewById<View> (Resource.Id.adMobView);

			AdMobHelper.AddSearchTermToAdMobRequest (adMob, "java", "milano");

			return view;
		}

	}
}

