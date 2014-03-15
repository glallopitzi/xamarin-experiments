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
using Android.Views.Animations;

namespace XamarinExperiments
{
	public class AdvertListAdapter : BaseAdapter
	{
		public Activity context;
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

//			Animation fadeIn = AnimationUtils.LoadAnimation (context, Resource.Animation.fade_in);
//			Animation slideUp = AnimationUtils.LoadAnimation (context, Resource.Animation.slide_up);
			Animation flyIn = AnimationUtils.LoadAnimation (context, Resource.Animation.fly_in);

//			view.StartAnimation (fadeIn);
//			view.StartAnimation (slideUp);
			view.StartAnimation (flyIn);

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

