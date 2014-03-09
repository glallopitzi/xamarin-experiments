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
	public class RecentSearchesTab : BaseFragment
	{
//		public Button searchButton;
		public ListView recentSearchesListView;
		RecentSearchesListAdapter adapter;

		public JobSeekerSearches[] jobSeekerSearches = new JobSeekerSearches[] { 
			new JobSeekerSearches("java", "dublin"),
			new JobSeekerSearches("", "dublin"),
			new JobSeekerSearches("java", ""),
			new JobSeekerSearches("java developer", ""),
			new JobSeekerSearches("developer", "")
		};

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.RecentSearches, container, false);

//			searchButton = view.FindViewById<Button> (Resource.Id.searchButton);
//			searchButton.Click += (object sender, EventArgs e) => {
//				Android.Support.V4.App.FragmentTransaction trans = FragmentManager.BeginTransaction();
//				trans.Replace(Resource.Id.recentSearchesFragmentContainer, new AdvertList());
//				trans.SetTransition(1);
//				trans.AddToBackStack(null);
//				trans.Commit();
//			};

			recentSearchesListView = view.FindViewById<ListView> (Resource.Id.recentSearchesListView);
			adapter = new RecentSearchesListAdapter (Activity, jobSeekerSearches);
			recentSearchesListView.Adapter = adapter;

			return view;
		}

	}

	public class JobSeekerSearches {
		public string what { get; set; }
		public string where { get; set; }

		public JobSeekerSearches (string what, string where)
		{
			this.what = what;
			this.where = where;
		}
		
	}
}

