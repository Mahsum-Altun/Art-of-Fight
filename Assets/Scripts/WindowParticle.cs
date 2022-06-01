using UnityEngine;


public class WindowParticle : MonoBehaviour
{
   public AudioClip Break;
   public AudioSource window;
   public ParticleSystem windowParticle;
   public ParticleSystem windowParticle2;


   private void OnTriggerEnter(Collider other) 
   {
       if(other.gameObject.tag == "Player")
       {
          window.PlayOneShot(Break);    
          windowParticle.Play();
          windowParticle2.Play();
       }
   }
}
