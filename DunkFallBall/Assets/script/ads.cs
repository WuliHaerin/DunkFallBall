using System.Collections;
using System.Collections.Generic;
using UnityEngine.Advertisements;
using UnityEngine;

public class ads : MonoBehaviour {

	public shop Shop;
	public gameManager gm;
	private int scene;

	//public void showAds(int n){

	//	scene = n;

	//	if (Advertisement.IsReady ()) {

	//		Advertisement.Show ("rewardedVideo", new ShowOptions (){ resultCallback = handelAds });
	//	}
	//}
	//public void showAdsSkip(){

	//	if (Advertisement.IsReady ()) {

	//		Advertisement.Show ("video", new ShowOptions (){ resultCallback = handelAds });
	//	}
	//}

	//public void handelAds(ShowResult result){

	//	switch (result) {

	//	case ShowResult.Finished:
	//		print ("ads finished");
	//		if (scene == 1) {
	//			Shop.watch ();
	//		} else if (scene == 2) {
	//			print ("ads watched");
	//			gm.revive ();
	//		}
	//		break;
	//	case ShowResult.Skipped:
	//		print ("ads skipped");
	//		break;
	//	case ShowResult.Failed:
	//		print ("ads failed");
	//		break;
	//	}

	//}
	
}
