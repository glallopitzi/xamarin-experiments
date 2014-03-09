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
	class RecentSearchesListAdapter : BaseAdapter
	{
		Activity context;
		public JobSeekerSearches[] items;

		public RecentSearchesListAdapter (IntPtr javaReference, JniHandleOwnership transfer, Activity context, JobSeekerSearches[] items) : base (javaReference, transfer)
		{
			this.context = context;
			this.items = items;
		}
		

		public RecentSearchesListAdapter (Activity context, JobSeekerSearches[] items)
		{
			this.context = context;
			this.items = items;
		}
		

		#region implemented abstract members of BaseAdapter
		public override Java.Lang.Object GetItem (int position)
		{
			throw null;
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;
			if (view == null)
				view = context.LayoutInflater.Inflate (Resource.Layout.RecentSearchesItem, parent, false);
			view.FindViewById<TextView> (Resource.Id.recentSearchesItemLabel).Text = items [position].what + " / " + items [position].where; 
		
			// TODO

			return view;

		}

		public override int Count {
			get {
				return items.Length;
			}
		}
		#endregion
	}
}

