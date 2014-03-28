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
using Android.Support.V4.View;

namespace XamarinExperiments
{
	public class DynamicTabsPagerAdapter 
		: FragmentStatePagerAdapter
	{
		Android.Support.V4.App.FragmentManager fm;
		public Android.Support.V4.App.Fragment tabSearch;
		public Android.Support.V4.App.Fragment tabRecent;

		public DynamicTabsPagerAdapter (Android.Support.V4.App.FragmentManager fm) : base (fm)
		{
			this.fm = fm;
			tabSearch = new SearchTab (fm, this);
			tabRecent = new RecentSearchesTab ();
		}

		public override int GetItemPosition (Java.Lang.Object @object)
		{
			return PagerAdapter.PositionNone;
//			return base.GetItemPosition (@object);
		}

		public override void NotifyDataSetChanged ()
		{
			base.NotifyDataSetChanged ();
		}

		public override int Count {
			get {
				return 2;
			}
		}

		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			Console.WriteLine ("GetItem, position; " + position);
			switch (position) {
				case 0:
					return tabSearch;

				case 1:
					return tabRecent;

			}
			return null;
		}
	}
}

