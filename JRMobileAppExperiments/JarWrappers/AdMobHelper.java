/*
 * Copyright (C) 2014 giancarlo lallopizzi
 * 
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 */

package JRMobileAppExperiments.admob;

import android.view.View;
import com.google.ads.*;
import com.google.ads.searchads.SearchAdRequest;
import android.content.Context;
import android.widget.LinearLayout;

public class AdMobHelper {
 	
 	private static String LOG_KEY = "[JOBRAPIDO|JAVA]";

	public static void logMsg(String msg) {
		System.out.println(LOG_KEY + msg);
	}

	//this method will refresh the ad, you can add more to the AdRequest if you want
	public static void loadAd(View view)
	{
		logMsg("loadAd");
		logMsg("loadAd|view.toString()|" + view.toString());
		// Initiate a generic request.
		try{
			AdRequest adRequest = new AdRequest();
			logMsg("loadAd|adRequest.toString()|" + adRequest.toString());
			((AdView)view).loadAd(adRequest);
			
		} catch(Exception ex){
			logMsg(ex.getMessage());
		}
	}

	
	public static void addSearchTermToAdMobRequest(View view, String what, String where){
		logMsg("addSearchTermToAdMobRequest, view: " + view.toString() + ", what: " + what + ", where: " + where);
		
		String query = "";
		if (what != "" && where != ""){
			query = what + "+" + where;
		} else {
			if(what != "") query = what;
			if(where != "") query = where;
		}
		
		logMsg ("query: " + query);
		
		// Initiate a generic request.
		try{
			SearchAdRequest adRequest = new SearchAdRequest();
			adRequest.setQuery(query);

			logMsg("loadAd|adRequest.toString()|" + adRequest.toString());
			((AdView)view).loadAd(adRequest);
		
			logMsg ("received view: " + view.toString());
		} catch(Exception ex){
			logMsg(ex.getMessage());
		}
	}
	

	/*public static void makeRequestForSearch(Context context, LinearLayout layout, String what, String where){
		logMsg("makeRequestForSearch, context: " + context.toString() + ", layout: " + layout + ", what: " + what + ", where: " + where);
		String query = what + "+" + where;
		
		// Initiate a generic request.
		try{
			AdView adView = new AdView(context, AdSize.BANNER, "ca-mb-app-pub-3395770861839852/5702551918");

			SearchAdRequest adRequest = new SearchAdRequest();
			adRequest.setQuery(query);

			logMsg("loadAd|adRequest.toString()|" + adRequest.toString());
			adView.loadAd(adRequest);
			layout.add(adView);

			logMsg ("received adView: " + adView.toString());
		} catch(Exception ex){
			logMsg(ex.getMessage());
		}
	}*/

	//destroys the add, should be called in the override of the destory in the activity.
	public static void destroy(View view)
	{
		logMsg("destroy");
		((AdView)view).destroy();
	}

}