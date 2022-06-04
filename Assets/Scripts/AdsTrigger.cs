using UnityEngine;

public class AdsTrigger : MonoBehaviour
{
   public AdsManager adsManager;

  private void OnTriggerEnter(Collider other) 
  {
      if (other.gameObject.tag == "AdsTrigger")
      {
          adsManager.interstitial();
      }
  }
}
