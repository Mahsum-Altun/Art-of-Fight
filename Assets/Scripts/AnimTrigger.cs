using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
   public Animator PlayerAnimControl;

   private void OnTriggerEnter(Collider other)
   {
       if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("1"))
       {
          Debug.Log("animasyon 1 geçti");
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("2"))
       {
           Debug.Log("GG anmim 2");
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("3"))
       {
           Debug.Log("GG anmim 3");
       }
       else if(this.PlayerAnimControl.GetCurrentAnimatorStateInfo(0).IsTag("4"))
       {
           Debug.Log("GG");
       }
   }
}
