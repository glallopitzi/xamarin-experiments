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
		public Button searchButton;

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			logMsg ("OnCreate");
		}



		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.Search, container, false);
			searchButton = view.FindViewById<Button> (Resource.Id.searchButton);

			searchButton.Click += (object sender, EventArgs e) => {

			};

			return view;
		}

	}
}

