using UnityEngine;

public class AnimTriggerOne : MonoBehaviour
{
    private Animator PlayerAnimControl1;

    private void Start() 
   {
      PlayerAnimControl1 = GameObject.FindGameObjectWithTag("Player").GetComponent<Animator>();    
   }



  private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
          FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           //Animation passes
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
       else if(this.PlayerAnimControl1.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           FindObjectOfType<GameManager>().EndGame();
       }
   }
}
