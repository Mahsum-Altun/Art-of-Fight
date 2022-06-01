using UnityEngine;

public class AnimTriggerTwo : MonoBehaviour
{
    private Animator PlayerAnimControl2;

    private void Start() 
   {
      PlayerAnimControl2 = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();    
   }



  private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
          FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           //Animation passes
       }
       else if(this.PlayerAnimControl2.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}
