using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.App;
using Gcm.Client;

namespace JRMobileAppExperiments
{
	[Activity (Label = "JRMobileAppExperiments", MainLauncher = true)]
	public class MainActivity 
		: FragmentActivity, ActionBar.ITabListener
	{

		private ViewPager _viewPager;
		private TabsPagerAdapter _tabsAdapter;
		private ActionBar _actionBar;

		private string[] titles = { "Search", "Recent searches", "Third" };

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.TabMain);




			//Check to ensure everything's setup right
			GcmClient.CheckDevice(this);
			GcmClient.CheckManifest(this);


			//Get the stored latest registration id
			var registrationId = GcmClient.GetRegistrationId(this);
			if (string.IsNullOrEmpty (registrationId)) {
				//Call to register
				GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);
			}



			_viewPager = FindViewById<ViewPager> (Resource.Id.pager);
			_actionBar = ActionBar;
			_tabsAdapter = new TabsPagerAdapter (SupportFragmentManager);

			_viewPager.Adapter = _tabsAdapter;
			_actionBar.SetHomeButtonEnabled (false);
			_actionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			foreach (string item in titles) {
				_actionBar.AddTab (_actionBar.NewTab ().SetText (item).SetTabListener (this));
			}


			var simpleOnPageChangeListener = new ViewPager.SimpleOnPageChangeListener ();
			_viewPager.SetOnPageChangeListener (simpleOnPageChangeListener);

		}


		protected override void OnResume ()
		{
			base.OnResume ();

		}


		public void OnTabReselected (ActionBar.Tab tab, Android.App.FragmentTransaction ft)
		{
		}

		public void OnTabSelected (ActionBar.Tab tab, Android.App.FragmentTransaction ft)
		{
			_viewPager.CurrentItem = tab.Position;
		}

		public void OnTabUnselected (ActionBar.Tab tab, Android.App.FragmentTransaction ft)
		{
		}

	}
}


