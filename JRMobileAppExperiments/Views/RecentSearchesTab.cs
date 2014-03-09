﻿using System;
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
	public class RecentSearchesTab : BaseFragment
	{
		public Button searchButton;
		public ListView advertListView;

		public string[] items = { "Apple", "Avocado", "Banana",
			"Blueberry", "Coconut", "Durian", "Guava", "Kiwifruit",
			"Jackfruit", "Mango", "Olive", "Pear", "Sugar-apple" };


		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.RecentSearches, container, false);
			searchButton = view.FindViewById<Button> (Resource.Id.searchButton);
			searchButton.Click += (object sender, EventArgs e) => {
				Android.Support.V4.App.FragmentTransaction trans = FragmentManager.BeginTransaction();
				trans.Replace(Resource.Id.searchFragmentContainer, new AdvertList());
				trans.SetTransition(1);
				trans.AddToBackStack(null);
				trans.Commit();
			};

			advertListView = view.FindViewById<ListView> (Resource.Id.advertList);
//			advertListView.Adapter = new ArrayAdapter<string> (context, 

			return view;
		}
	}
}

