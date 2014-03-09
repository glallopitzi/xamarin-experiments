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
using Android.Webkit;

namespace JRMobileAppExperiments
{
	public class OpenAdvert : BaseFragment
	{
		public WebView webView;
		string url = "http://it.jobrapido.com";

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			context = inflater.Context;
			logMsg ("OnCreateView, context: " + context.ToString());

			var view = inflater.Inflate (Resource.Layout.OpenAdvert, container, false);

			webView = (WebView) view.FindViewById(Resource.Id.advert_frame_webView);
			webView.Settings.BuiltInZoomControls = true;

			var advertWebViewClient = new AdvertWebViewClient ();
			webView.SetWebViewClient (advertWebViewClient);
			webView.Settings.LoadWithOverviewMode = true;
			webView.Settings.UseWideViewPort = true;
			webView.Settings.JavaScriptEnabled = true;
			webView.LoadUrl (url);

			return view;
		}

	}

	internal class AdvertWebViewClient 
		: WebViewClient 
	{
		public override bool ShouldOverrideUrlLoading (WebView view, string url)
		{
			view.LoadUrl (url);
			return true;
		}

		public override void OnPageFinished(WebView view, String url) {
			// do your stuff here
//			AndroidHUD.AndHUD.Shared.Dismiss ();
		}
	}
}

