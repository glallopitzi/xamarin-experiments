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
using System.Collections.Generic;
//using Android.Content.PM;

namespace JRMobileAppExperiments
{
	[Activity (
		Label = "JRMobileAppExperiments",
//		Theme = "@style/Jobrapido",
//		ConfigurationChanges = Android.Content.PM.ConfigChanges.KeyboardHidden, 
//		WindowSoftInputMode = Android.Views.SoftInput.StateHidden,
//		ScreenOrientation = ScreenOrientation.Portrait,
		MainLauncher = true
	)]
	public class MainActivity 
		: FragmentActivity, ActionBar.ITabListener
	{

		private bool gcmNotificationEnabled = false;

		private ViewPager _viewPager;
		private TabsPagerAdapter _tabsAdapter;
		private ActionBar _actionBar;

		private string[] titles = { "Search", "Recent searches" };

//		private string currentSelectedTabTag = "";
//		private Dictionary<string, List<Android.Support.V4.App.Fragment>> fragmentsStack = new Dictionary<string, List<Android.Support.V4.App.Fragment>> ();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.TabMain);

			if (gcmNotificationEnabled) initializeGoogleCloudMessage ();

			_viewPager = FindViewById<ViewPager> (Resource.Id.pager);
			_actionBar = ActionBar;
			_tabsAdapter = new TabsPagerAdapter (SupportFragmentManager);

			_viewPager.Adapter = _tabsAdapter;
			_actionBar.SetHomeButtonEnabled (false);
			_actionBar.NavigationMode = ActionBarNavigationMode.Tabs;

			foreach (string item in titles) {
				_actionBar.AddTab (_actionBar.NewTab ().SetText (item).SetTabListener (this));
			}

			_viewPager.SetOnPageChangeListener (new MyPageChangeListener(_actionBar));

		}

		public override void OnBackPressed ()
		{
			base.OnBackPressed ();
		}

		public void OnTabReselected (ActionBar.Tab tab, Android.App.FragmentTransaction ft){}

		public void OnTabSelected (ActionBar.Tab tab, Android.App.FragmentTransaction ft)
		{
			_viewPager.CurrentItem = tab.Position;
		}

		public void OnTabUnselected (ActionBar.Tab tab, Android.App.FragmentTransaction ft){}




		public void showFragment(Android.Support.V4.App.Fragment fragment){}

		public void createStackForTab(string tabTag){}

		public void addFragmentToStack(Android.Support.V4.App.Fragment fragment){}

		public Android.Support.V4.App.Fragment getLastFragment(){
			return null;
		}

		public void onBackPressed(){}











		/// <summary>
		/// Initializes the google cloud message.
		/// </summary>
		void initializeGoogleCloudMessage ()
		{
			//Check to ensure everything's setup right
			GcmClient.CheckDevice(this);
			GcmClient.CheckManifest(this);

			//Get the stored latest registration id
			var registrationId = GcmClient.GetRegistrationId(this);
			if (string.IsNullOrEmpty (registrationId)) {
				//Call to register
				GcmClient.Register(this, GcmBroadcastReceiver.SENDER_IDS);
			}
		}
	}

	class MyPageChangeListener : Java.Lang.Object, ViewPager.IOnPageChangeListener {

		ActionBar actionBar;

		public MyPageChangeListener ()
		{
		}

		public MyPageChangeListener (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		public MyPageChangeListener (ActionBar actionBar)
		{
			this.actionBar = actionBar;
		}

		public void OnPageScrollStateChanged (int state)
		{
		}

		public void OnPageScrolled (int position, float positionOffset, int positionOffsetPixels)
		{
		}

		public void OnPageSelected (int position)
		{
			actionBar.SetSelectedNavigationItem (position);
		}
	}
}


