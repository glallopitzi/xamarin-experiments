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

namespace XamarinExperiments
{
	public class SearchTab : BaseFragment
	{
		Android.Support.V4.App.FragmentManager fm;
		DynamicTabsPagerAdapter adapter;

		public Button searchButton;
		public EditText whatEditText;
		public EditText whereEditText;

		public SearchTab(Android.Support.V4.App.FragmentManager fm, DynamicTabsPagerAdapter adapter) : base() {
			this.fm = fm;
			this.adapter = adapter;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.Search, container, false);
			searchButton = view.FindViewById<Button> (Resource.Id.searchButton);
			whatEditText = view.FindViewById<EditText> (Resource.Id.whatEditText);
			whereEditText = view.FindViewById<EditText> (Resource.Id.whereEditText);

			searchButton.Click += (object sender, EventArgs e) => {
				Android.Support.V4.App.Fragment tabNew = new AdvertList();
				Android.Support.V4.App.FragmentTransaction trans = fm.BeginTransaction();
				trans.Replace(Resource.Id.pager, tabNew);
				trans.SetTransition(1);
				trans.AddToBackStack(null);
				trans.Commit();
				adapter.tabSearch = tabNew;
				adapter.NotifyDataSetChanged();
			};

			return view;
		}

	}
}

