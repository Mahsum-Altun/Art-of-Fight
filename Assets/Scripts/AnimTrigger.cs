using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
   private Animator PlayerAnimControl;

   private void Start() 
   {
      PlayerAnimControl = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();    
   }

   private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
           //Animation passes
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}
