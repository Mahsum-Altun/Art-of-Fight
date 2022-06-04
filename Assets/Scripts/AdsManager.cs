using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
   private string gameID = "4780645";
   private string Interstitial = "Interstitial_Android";
   private string Banner = "Banner_Android";
   public bool testMode = false;


    void Start() 
     {
        Advertisement.AddListener(this);
        Advertisement.Initialize(gameID, testMode);
        StartCoroutine (ShowBannerWhenReady ());
     }  

     IEnumerator ShowBannerWhenReady () 
     {
        while (!Advertisement.IsReady (Banner)) 
        {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.Show(Banner);
        Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
    }

     public void HideBanner()
     {
         Advertisement.Banner.Hide();
     }

    public void interstitial()
     {
        if (Advertisement.IsReady(Interstitial))
        {
            Advertisement.Show(Interstitial);
        }
        else
        {
            Debug.Log("Interstitial not loaded");
        }
     }

     /*public void banner()
     {
        if (Advertisement.IsReady(Banner))
        {
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            Advertisement.Banner.Show(Banner);
        }
        else
        {
            Debug.Log("Banner not loaded");
        }
     }*/

     public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
     {
         if (showResult == ShowResult.Finished)
         {
             Debug.Log("Rewarded");
         }
         
         if (showResult == ShowResult.Skipped)
         {
             Debug.Log("Ads Skip");
         }
         
         if (showResult == ShowResult.Failed)
         {
             Debug.LogWarning("Error ADS Failed");
         }
     }

     public void OnUnityAdsDidError(string message)
     {
        Debug.Log("Ads not loaded:" + message);
     }

     public void OnUnityAdsDidStart(string placementId)
     {
         Debug.Log("Ads started:" + placementId);
     }

     public void OnUnityAdsReady(string placementId)
     {
         Debug.Log("Ready" + placementId);
     }

      public void OnDestroy()
    {
       Advertisement.RemoveListener(this);
    }
}
