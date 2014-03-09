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
	public class SearchTab : BaseFragment
	{
		public Button searchButton;
		public EditText whatEditText;
		public EditText whereEditText;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.Search, container, false);
			searchButton = view.FindViewById<Button> (Resource.Id.searchButton);
			whatEditText = view.FindViewById<EditText> (Resource.Id.whatEditText);
			whereEditText = view.FindViewById<EditText> (Resource.Id.whereEditText);

			searchButton.Click += (object sender, EventArgs e) => {
				Android.Support.V4.App.FragmentTransaction trans = FragmentManager.BeginTransaction();
				trans.Replace(Resource.Id.searchFragmentContainer, new AdvertList());
				trans.SetTransition(1);
				trans.AddToBackStack(null);
				trans.Commit();
			};

			return view;
		}

	}
}

