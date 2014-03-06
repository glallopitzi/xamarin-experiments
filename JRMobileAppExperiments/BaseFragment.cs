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
	public abstract class BaseFragment 
		: Android.Support.V4.App.Fragment
	{


		protected void logMsg(string msg)
		{
			System.Diagnostics.Debug.WriteLine (this.Class+"|"+msg);
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);
			logMsg ("OnViewCreated");
		}

		public override void OnResume ()
		{
			base.OnResume ();
			logMsg ("OnResume");
		}

		public override void OnPause ()
		{
			base.OnPause ();
			logMsg ("OnPause");
		}
	}
}

