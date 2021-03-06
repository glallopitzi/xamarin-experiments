﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace XamarinExperiments
{
	public class AdvertList : BaseFragment
	{

		public Advert[] adverts;
		public ListView advertsListView;
		public AdvertListAdapter adapter;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate (Resource.Layout.AdvertList, container, false);
			advertsListView = view.FindViewById<ListView> (Resource.Id.advertListView);
			adapter = new AdvertListAdapter (Activity, getAdverts());
			advertsListView.Adapter = adapter;

			advertsListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				// TODO set on click here

				Toast.MakeText(((AdvertListAdapter)((ListView)sender).Adapter).context, "Short clicked!", ToastLength.Long).Show();
			};

			advertsListView.ItemLongClick += (object sender, AdapterView.ItemLongClickEventArgs e) => {
				// TODO set on long click here
				Toast.MakeText(((AdvertListAdapter)((ListView)sender).Adapter).context, "Long clicked!", ToastLength.Long).Show();
			};

			var adMob = view.FindViewById<View> (Resource.Id.adMobView);
			AdMobHelper.AddSearchTermToAdMobRequest (adMob, "java", "milano");

			return view;
		}


		private Advert[] getAdverts() {
			Advert[] adverts = new Advert[20];
			for (int i = 0; i < adverts.Length; i++) {
				adverts [i] = new Advert ("title "+i, "url", "location", "company", "website", "date");
			}
			return adverts;
		}

	}

	public class Advert {
		public string title { get; set; }
		public string url { get; set; }
		public string location { get; set; }
		public string company { get; set; }
		public string website { get; set; }
		public string date { get; set; }

		public Advert (string title, string url, string location, string company, string website, string date)
		{
			this.title = title;
			this.url = url;
			this.location = location;
			this.company = company;
			this.website = website;
			this.date = date;
		}
		
	}
}

