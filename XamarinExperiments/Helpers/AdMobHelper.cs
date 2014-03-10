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
	public static class AdMobHelper
	{
		//this is where we had specified: admob6sample.admob;
		private static IntPtr _helperClass = JNIEnv.FindClass("XamarinExperiments/admob/AdMobHelper");


		/// <summary>
		/// Refreshed the ad for the view
		/// </summary>
		/// <param name="view"></param>
		public static void LoadAd(View view)
		{
			IntPtr methodId = JNIEnv.GetStaticMethodID(_helperClass, "loadAd", "(Landroid/view/View;)V");
			JNIEnv.CallStaticVoidMethod(_helperClass, methodId, new JValue(view));
		}

		/// <summary>
		/// Destroys the ad
		/// </summary>
		/// <param name="view"></param>
		public static void Destroy(View view)
		{
			IntPtr methodId = JNIEnv.GetStaticMethodID(_helperClass, "destroy", "(Landroid/view/View;)V");
			JNIEnv.CallStaticVoidMethod(_helperClass, methodId, new JValue(view));
		}

		public static void AddSearchTermToAdMobRequest(View view, string what, string where)
		{
			IntPtr methodId = JNIEnv.GetStaticMethodID(_helperClass, "addSearchTermToAdMobRequest", "(Landroid/view/View;Ljava/lang/String;Ljava/lang/String;)V");
			JNIEnv.CallStaticVoidMethod(_helperClass, methodId, new JValue(view), new JValue( new Java.Lang.String(what)), new JValue( new Java.Lang.String(where)));
		}
	}
}

