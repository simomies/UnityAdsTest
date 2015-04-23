using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Check if valid platform for ads
        if (Advertisement.isSupported)
        {
            //Reduce the amount of waiting the user has to do in optimal situation
            Advertisement.allowPrecache = true;
            //GameID @ unityads.unity3d.com = 33116, test mode and not going to store => testMode = true to not anger the great gods of the ads
            Advertisement.Initialize("33116", true);
            Debug.Log("Ads initialized successfully!");
        }
        else
        {
            Debug.Log("Oh noes! Ads not supported on this platform!");
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowAdsPlox()
    {
        if (Advertisement.isReady())
        {
            Advertisement.Show(null, new ShowOptions
            {
                pause = true, //Pause the game for the duration of the ad
                resultCallback = result =>
                { //Set your function as the callback and get the way the ad ended to var result

                    if (result.ToString() == "Finished")
                    {
                        Debug.Log("Rewarding player!");
                    };
                }
            });
            
        }
        else
        {
            Debug.Log("Oh noes! No ads available!");
        }
    }
}
