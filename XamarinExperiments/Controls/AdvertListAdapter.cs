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
	public class AdvertListAdapter : BaseAdapter
	{
		Activity context;
		public Advert[] items;

		public AdvertListAdapter (IntPtr javaReference, JniHandleOwnership transfer, Activity context, Advert[] items) : base (javaReference, transfer)
		{
			this.context = context;
			this.items = items;
		}
		

		public AdvertListAdapter (Activity context, Advert[] items)
		{
			this.context = context;
			this.items = items;
		}
		

		#region implemented abstract members of BaseAdapter
		public override Java.Lang.Object GetItem (int position)
		{
			return null;
		}
		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			View view = convertView;
			if (view == null)
				view = context.LayoutInflater.Inflate (Resource.Layout.AdvertListItem, parent, false);
			view.FindViewById <TextView> (Resource.Id.advertTitle).Text = items [position].title;
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

