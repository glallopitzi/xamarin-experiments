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

namespace XamarinExperiments
{
	public class TabsPagerAdapter 
		: FragmentPagerAdapter
	{
		Android.Support.V4.App.FragmentManager fm;
		List<Android.Support.V4.App.Fragment> tabs;

		public TabsPagerAdapter (Android.Support.V4.App.FragmentManager fm) : base (fm) { 
			this.fm = fm; 
			tabs = new List<Android.Support.V4.App.Fragment> ();
//			tabs.Add (new SearchTab (fm, this));
			tabs.Add (new RecentSearchesTab ());
		}

		public override Android.Support.V4.App.Fragment GetItem (int position)
		{
			Console.WriteLine ("GetItem, position; " + position);
			return tabs [position];
		}

		public override long GetItemId (int position)
		{
			return base.GetItemId (position);
		}

		public override bool IsViewFromObject (View view, Java.Lang.Object @object)
		{
			return base.IsViewFromObject (view, @object);
		}

		public override int GetItemPosition (Java.Lang.Object @object)
		{
			return base.GetItemPosition (@object);
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
	}
}

