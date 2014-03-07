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
//import com.jobrapido.*;

public class AdMobHelper {
 	
 	private static String LOG_KEY = "[JOBRAPIDO|JAVA]";

	public static void logMsg(String msg) {
		System.out.println(LOG_KEY + msg);
	}

	private AdMobHelper() { logMsg("AdMobHelper"); }

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

	/*
	 * Commented because not working yet
	public static void addSearchTermToAdMobRequest(View view, String what, String where){
		logMsg("addSearchTermToAdMobRequest, view: " + view.toString() + ", what: " + what + ", where: " + where);
		String query = what + " " + where;
		// Initiate a generic request.
		try{
			com.google.android.gms.ads.search.SearchAdRequest adRequest = new com.google.android.gms.ads.search.SearchAdRequest.Builder()
				.setQuery(query)
				.build();

			logMsg("loadAd|adRequest.toString()|" + adRequest.toString());
			((AdView)view).loadAd(adRequest);
			logMsg ("received view: " + view.toString());
		} catch(Exception ex){
			logMsg(ex.getMessage());
		}
	}
	*/


	//destroys the add, should be called in the override of the destory in the activity.
	public static void destroy(View view)
	{
		logMsg("destroy");
		((AdView)view).destroy();
	}

}