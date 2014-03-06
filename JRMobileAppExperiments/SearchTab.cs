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
	class SearchTab : BaseFragment
	{
		public Context context;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("context: " + context.ToString());
			var view = inflater.Inflate (Resource.Layout.Search, container, false);


			return view;
		}

	}
}

